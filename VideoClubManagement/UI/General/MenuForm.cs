using System;
using System.Windows.Forms;
using VideoClubManagement.UI.ArticleCasts;
using VideoClubManagement.UI.ArticleLendings;
using VideoClubManagement.UI.Clients;
using VideoClubManagement.UI.Cast;
using VideoClubManagement.UI.Language;
using VideoClubManagement.UI.Employee;
using VideoClubManagement.UI.Shiftwork;
using VideoClubManagement.UI.Article;
using VideoClubManagement.UI.Genre;
using VideoClubManagement.UI.ArticleType;
using VideoClubManagement.UI.Users;
using VideoClubManagement.Helpers;
using VideoClubManagement.Data.Enums;

namespace VideoClubManagement.UI.General
{
    public partial class MenuForm : Form
    {
        private readonly Form _parent;

        public MenuForm(Form parent)
        {
            InitializeComponent();
            ManageOptionsAccordingToRole();
            _parent = parent;
        }

        private void articleCastButton_Click(object sender, EventArgs e)
        {
            Hide();
            new ArticleCastIndexForm(this).Show();
        }

        private void articleLendingButton_Click(object sender, EventArgs e)
        {
            Hide();
            new ArticleLendingIndexForm(this).Show();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            Hide();
            new ClientIndexForm(this).Show();
        }

        private void languageButton_Click(object sender, EventArgs e)
        {
            Hide();
            new languageForm(this).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new castForm(this).Show();
        }

        private void shiftworkButton_Click(object sender, EventArgs e)
        {
            Hide();
            new shiftworkForm(this).Show();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            Hide();
            new employeeForm(this).Show();
        }

        private void articleButton_Click(object sender, EventArgs e)
        {
            Hide();
            new ArticleForm(this).Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            new GenreForm(this).Show();
        }

        private void articleTypeButton_Click(object sender, EventArgs e)
        {
            Hide();
            new ArticleTypeForm(this).Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Hide();
            new UserIndexForm(this).Show();
        }

        private void ManageOptionsAccordingToRole()
        {
            if (LoggedInUserHelper.GetLoggedUser().UserRoleId != UserRoleId.Admin)
            {
                userButton.Visible = false;
                employeeButton.Visible = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            _parent.Close();
        }
    }
}
