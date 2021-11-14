using System;
using System.Data;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.ArticleLendings
{
    public partial class ArticleLendingEditForm : Form
    {
        private readonly Form _parent;
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private System.Timers.Timer _timer = new System.Timers.Timer(1000);
        private bool _backToList = false;
        private bool _changesSaved = false;
        private IValidator<ArticleLending> _validator;

        public ArticleLendingEditForm(Form paren, int id, IValidator<ArticleLending> validator)
        {
            InitializeComponent();
            _parent = paren;
            _validator = validator;
            _timer.Elapsed += UpdateCurrentDateTimeLabel;
            FillData(id);
            var a = _applicationDbContext.Clients;
            _timer.Start();
        }

        private void UpdateCurrentDateTimeLabel(object sender, ElapsedEventArgs e) =>
            currentDateTimeLabel.Invoke((Action)delegate
            {
                currentDateTimeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            });

        private void SetComboBoxes(int currentEmployeeId, int currentClientId, int currentArticleId)
        {
            SetArticleComboBox(currentArticleId);
            SetClientComboBox(currentClientId);
            SetEmployeeComboBox(currentEmployeeId);
        }

        private void SetArticleComboBox(int currentId)
        {
            var articles = _applicationDbContext.Articles.AsEnumerable();
            articleComboBox.DisplayMember = "Name";
            articleComboBox.ValueMember = "Id";
            foreach (var article in articles)
            {
                var item = new { Id = article.Id, Name = $"{ article.Title }" };
                articleComboBox.Items.Add(item);
                if (article.Id == currentId)
                    articleComboBox.SelectedItem = item;
            }
        }

        private void SetClientComboBox(int currentId)
        {
            var clients = _applicationDbContext.Clients.AsEnumerable();
            clientComboBox.DisplayMember = "Name";
            clientComboBox.ValueMember = "Id";
            foreach (var client in clients)
            {
                var item = new { Id = client.Id, Name = $"{ client.FirstName } { client.LastName }" };
                clientComboBox.Items.Add(item);
                if (client.Id == currentId)
                    clientComboBox.SelectedItem = item;
            }
        }

        private void SetEmployeeComboBox(int currentId)
        {
            var employees = _applicationDbContext.Employees.AsEnumerable();
            employeeComboBox.DisplayMember = "Name";
            employeeComboBox.ValueMember = "Id";
            foreach (var employee in employees)
            {
                var item = new { Id = employee.Id, Name = $"{ employee.FirstName } { employee.LastName }" };
                employeeComboBox.Items.Add(item);
                if (employee.Id == currentId)
                    employeeComboBox.SelectedItem = item;
            }
        }

        public void FillData(int id)
        {
            var articleLending = _applicationDbContext.ArticleLendings.Where(c => c.Id == id).FirstOrDefault();

            SetComboBoxes(articleLending.EmployeeId, articleLending.ClientId, articleLending.ArticleId);

            idValueLabel.Text = articleLending.Id.ToString();
            createdDateValueLabel.Text = articleLending.CreatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            dueDateDateTimePicker.Value = articleLending.DueDate;
            returnDateDateTimePicker.Value = articleLending.ReturnDate ?? DateTime.Now;
            amountPerDayTextBox.Text = articleLending.AmountPerDay.ToString("0.##");
            commentTextBox.Text = articleLending.Comment;
            isActiveCheckBox.Checked = articleLending.IsActive;
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            var save = MessageBox.Show($"¿Estás seguro que deseas guardar estos datos?",
                "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
            if (save)
            {
                var employeeComboBoxSelectedItem = employeeComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(employeeComboBox.SelectedItem, null);
                var clientComboBoxSelectedItem = clientComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(clientComboBox.SelectedItem, null);
                var articleComboBoxSelectedItem = articleComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(articleComboBox.SelectedItem, null);

                var id = int.Parse(idValueLabel.Text);
                var articleLending = _applicationDbContext.ArticleLendings.Where(c => c.Id == id).FirstOrDefault();
                articleLending.EmployeeId = int.Parse(employeeComboBoxSelectedItem.ToString());
                articleLending.ClientId = int.Parse(clientComboBoxSelectedItem.ToString());
                articleLending.ArticleId = int.Parse(articleComboBoxSelectedItem.ToString());
                articleLending.AmountPerDay = decimal.Parse(amountPerDayTextBox.Text);
                articleLending.DueDate = dueDateDateTimePicker.Value.Date;
                articleLending.Comment = commentTextBox.Text;
                articleLending.IsActive = isActiveCheckBox.Checked;
                articleLending.ReturnDate = returnDateDateTimePicker.Value.Date;

                var validationErrors = _validator.GetValidationErrors(articleLending);

                if (validationErrors != null && validationErrors.Count > 0)
                {
                    string errors = "";
                    foreach (var validationError in validationErrors)
                        errors += $"{ validationError }{ Environment.NewLine }";

                    MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _applicationDbContext.SaveChanges();

                    _changesSaved = true;
                    _backToList = true;
                    Close();
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            bool close = true;

            if (!_changesSaved)
            {
                close = MessageBox.Show($"¿Estás seguro que deseas volver atrás? Las modificaciones no guardadas se perderán",
                "Adventencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
            }

            if (close)
            {
                if (_backToList)
                {
                    _timer.Close();
                    _parent.Show();
                }
                else
                {
                    _parent.Close();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void backToListButton_Click(object sender, EventArgs e)
        {
            _backToList = true;
            Close();
        }

        private void amountPerDayTextBox_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);   
    }
}
