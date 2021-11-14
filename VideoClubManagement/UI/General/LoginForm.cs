using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Helpers;

namespace VideoClubManagement.UI.General
{
    public partial class LoginForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private List<string> _errorMessages = new List<string>();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (ValidateLogIn())
            {
                MenuForm menuForm = new MenuForm(this);
                Hide();
                menuForm.Show();
            }
            else
            {
                string errors = "";
                foreach (var errorMessage in _errorMessages)
                {
                    errors += $"{ errorMessage }{ Environment.NewLine }";
                }
                MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateLogIn()
        {
            _errorMessages.Clear();
            bool result = true;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                _errorMessages.Add("El usuario no puede estar en blanco.");
                result = false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                _errorMessages.Add("La contraseña no puede estar en blanco.");
                result = false;
            }

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                var user = _applicationDbContext.Users.Where(x => x.UserName == username && x.Password == password)
                    .Include(x => x.UserRole)
                    .FirstOrDefault();

                if (user == null)
                {
                    _errorMessages.Add("Usuario o contraseña invalido.");
                    result = false;
                }
                else
                {
                    LoggedInUserHelper.SetLoggedUser(user);
                }
            }                

            return result;
        }
    }
}
