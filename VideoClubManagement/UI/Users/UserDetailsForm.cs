using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;

namespace VideoClubManagement.UI.Users
{
    public partial class UserDetailsForm : Form
    {
        private readonly Form _parent;
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private bool _backToList = false;

        public UserDetailsForm(Form parent, int userId)
        {
            InitializeComponent();
            _parent = parent;
            FillUserData(userId);
        }

        private void FillUserData(int userId)
        {
            var user = _applicationDbContext.Users.Where(c => c.Id == userId)
                .Include(u => u.UserRole)
                .FirstOrDefault();

            idValueLabel.Text = user.Id.ToString();
            userRoleValueLabel.Text = user.UserRole.Name;
            usernameValueLabel.Text = user.UserName;
            isActiveCheckBox.CheckState = user.IsActive ? CheckState.Checked : CheckState.Unchecked;
            identificationNumberValueLabel.Text = user.IdentificationNumber;
            emailValueLabel.Text = user.Email;
            createdDateValueLabel.Text = user.CreatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            lastUpdatedValueDateLabel.Text = user.LastUpdatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (_backToList)
                _parent.Show();
            else
                _parent.Close();
        }

        private void backToListButton_Click(object sender, EventArgs e)
        {
            _backToList = true;
            Close();
        }
    }
}
