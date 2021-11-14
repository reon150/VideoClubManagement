using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Data.Enums;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Users
{
    public partial class UserEditForm : Form
    {
        private readonly Form _parent;
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private readonly System.Timers.Timer _timer = new System.Timers.Timer(1000);
        private bool _backToList = false;
        private bool _changesSaved = false;
        private readonly IValidator<User> _validator;

        public UserEditForm(Form parent, int clientId, IValidator<User> validator)
        {
            InitializeComponent();
            _parent = parent;
            _validator = validator;
            _timer.Elapsed += UpdateCurrentDateTimeLabel;
            SetUserRoleComboBox();
            FillUserData(clientId);

            _timer.Start();
        }

        private void UpdateCurrentDateTimeLabel(object sender, ElapsedEventArgs e) =>
            currentDateTimeLabel.Invoke((Action)delegate
            {
                currentDateTimeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            });

        private void FillUserData(int userId)
        {
            var user = _applicationDbContext.Users.Where(c => c.Id == userId)
                .Include(c => c.UserRole)
                .FirstOrDefault();

            idValueLabel.Text = user.Id.ToString();
            identificationNumberTextBox.Text = user.IdentificationNumber;
            usernameTextBox.Text = user.UserName;
            emailTextBox.Text = user.Email;
            createdDateValueLabel.Text = user.CreatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            lastUpdatedValueDateLabel.Text = user.LastUpdatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            isActiveCheckBox.Checked = user.IsActive;

            if (user.UserRoleId == UserRoleId.Admin)
                userRoleComboBox.SelectedIndex = 0;
            else if (user.UserRoleId == UserRoleId.Employee)
                userRoleComboBox.SelectedIndex = 1;
        }

        private void SetUserRoleComboBox()
        {
            var userRoles = _applicationDbContext.UserRoles.AsEnumerable();
            userRoleComboBox.DisplayMember = "Name";
            userRoleComboBox.ValueMember = "Id";
            foreach (var userRole in userRoles)
                userRoleComboBox.Items.Add(new { userRole.Id, userRole.Name });
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            var save = MessageBox.Show($"¿Estás seguro que deseas guardar estos datos?",
                "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;

            if (save)
            {
                var userRoleComboBoxSelectedItem = userRoleComboBox.SelectedItem;

                Enum.TryParse(userRoleComboBoxSelectedItem
                    .GetType().GetProperty("Id").GetValue(userRoleComboBoxSelectedItem, null).ToString(),
                    out UserRoleId userRoleId);

                var userId = int.Parse(idValueLabel.Text);
                var user = _applicationDbContext.Users.Where(c => c.Id == userId).FirstOrDefault();

                user.Id = userId;
                user.IdentificationNumber = identificationNumberTextBox.Text;
                user.UserName = usernameTextBox.Text;
                user.Email = emailTextBox.Text;
                user.Password = string.IsNullOrWhiteSpace(passwordTextBox.Text) ? user.Password : passwordTextBox.Text;
                user.UserRoleId = userRoleId;
                user.IsActive = isActiveCheckBox.Checked;

                var validationErrors = _validator.GetValidationErrors(user);

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

        private void creditLimitTextBox_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }
}
