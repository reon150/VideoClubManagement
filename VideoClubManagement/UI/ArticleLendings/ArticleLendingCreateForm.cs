using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.UI.ArticleLendings
{
    public partial class ArticleLendingCreateForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private System.Timers.Timer _timer = new System.Timers.Timer(1000);
        private readonly Form _parent;
        private bool _backToList = false;
        private bool _changesSaved = false;

        public ArticleLendingCreateForm(Form parent)
        {
            _parent = parent;
            InitializeComponent();
            _timer.Elapsed += UpdateCurrentDateTimeLabel;

            SetComboBoxes();

            _timer.Start();
        }

        private void UpdateCurrentDateTimeLabel(object sender, ElapsedEventArgs e) =>
            currentDateTimeLabel.Invoke((Action)delegate
            {
                currentDateTimeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            });

        private void SetComboBoxes()
        {
            SetEmployeeComboBox();
            SetClientComboBox();
            SetArticleComboBox();
        }

        private void SetEmployeeComboBox()
        {
            var employees = _applicationDbContext.Employees.AsEnumerable();
            employeeComboBox.DisplayMember = "Name";
            employeeComboBox.ValueMember = "Id";
            foreach (var employee in employees)
                employeeComboBox.Items.Add(new { Id = employee.Id, Name = $"{ employee.FirstName } { employee.LastName }" });
            employeeComboBox.SelectedIndex = 0;
        }

        private void SetClientComboBox()
        {
            var clients = _applicationDbContext.Clients.AsEnumerable();
            clientComboBox.DisplayMember = "Name";
            employeeComboBox.ValueMember = "Id";
            foreach (var client in clients)
                clientComboBox.Items.Add(new { Id = client.Id, Name = $"{ client.FirstName } { client.LastName }" });
            clientComboBox.SelectedIndex = 0;
        }

        private void SetArticleComboBox()
        {
            var articles = _applicationDbContext.Articles.AsEnumerable();
            articleComboBox.DisplayMember = "Name";
            articleComboBox.ValueMember = "Id";
            foreach (var article in articles)
                articleComboBox.Items.Add(new { Id = article.Id, Name = $"{ article.Title }" });
            articleComboBox.SelectedIndex = 0;
        }

        private void createClientButton_Click(object sender, EventArgs e)
        {
            var employeeComboBoxSelectedItem = employeeComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(employeeComboBox.SelectedItem, null);
            var clientComboBoxSelectedItem = clientComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(clientComboBox.SelectedItem, null);
            var articleComboBoxSelectedItem = articleComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(articleComboBox.SelectedItem, null);

            var articleLending = new ArticleLending
            {
                EmployeeId = int.Parse(employeeComboBoxSelectedItem.ToString()),
                ClientId = int.Parse(clientComboBoxSelectedItem.ToString()),
                ArticleId = int.Parse(articleComboBoxSelectedItem.ToString()),
                AmountPerDay = decimal.Parse(amountPerDayTextBox.Text),
                DueDate = dueDateDateTimePicker.Value.Date,
                Comment = commentTextBox.Text,
                IsActive = isActiveCheckBox.Checked,
                ReturnDate = null
            };

            _applicationDbContext.ArticleLendings.Add(articleLending);
            _applicationDbContext.SaveChanges();

            _changesSaved = true;
            _backToList = true;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            bool close = true;

            if (!_changesSaved)
            {
                close = MessageBox.Show($"¿Estás seguro que deseas volver atrás? Los datos no guardados se perderán",
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
    }
}
