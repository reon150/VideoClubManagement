using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Helpers;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Users
{
    public partial class UserIndexForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private IQueryable<User> _usersQuery;
        private const int _pageSize = 15;
        private readonly FormPaginationHelper<User, int> _paginationHelper;
        private readonly Form _parent;
        private bool _backToList = false;

        public UserIndexForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _usersQuery = _applicationDbContext.Users.AsQueryable().Include(u => u.UserRole);
            _paginationHelper = new FormPaginationHelper<User, int>(_usersQuery, _pageSize, currentPageTextBox, lastPageTextBox);
        }

        private void FillUsersListDataGridView(IEnumerable<User> users)
        {
            usersDataGridView.Rows.Clear();

            foreach (var user in users)
            {
                usersDataGridView.Rows.Add(user.Id,
                    user.UserName,
                    user.Email,
                    user.IsActive);
            }
        }

        private void userListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                int userId = (int)usersDataGridView[0, e.RowIndex].Value;
                switch (usersDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case nameof(deleteButton):
                        DeleteUser(userId);
                        break;
                    case nameof(detailsButton):
                        Hide();
                        var clientDetailsForm = new UserDetailsForm(this, userId);
                        clientDetailsForm.Show();
                        break;
                    case nameof(editButton):
                        Hide();
                        var clientEditForm = new UserEditForm(this, userId, new UserValidator(_applicationDbContext.Users));
                        clientEditForm.Show();
                        break;
                    default:
                        break;
                }
            }
        }

        private void DeleteUser(int id)
        {
            var user = _applicationDbContext.Users.SingleOrDefault(x => x.Id == id);
            var delete = MessageBox.Show($"¿Estas seguro que deseas eliminar el usuario { user.UserName }?",
                "Adventencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;

            if (delete)
            {
                _applicationDbContext.Users.Remove(user);
                _applicationDbContext.SaveChanges();
                onlyShowActivesCheckBox.Checked = false;
                searchTextBox.Text = "";
                _paginationHelper.FirstPage(FillUsersListDataGridView, false);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _usersQuery = _applicationDbContext.Users.Where(c => c.Id.ToString().Contains(searchTextBox.Text)
                || c.UserName.Contains(searchTextBox.Text)
                || c.Password.Contains(searchTextBox.Text)
                || c.Email.Contains(searchTextBox.Text)
                || c.UserRole.Name.Contains(searchTextBox.Text)
                || c.IdentificationNumber.Contains(searchTextBox.Text));

            if (onlyShowActivesCheckBox.Checked) _usersQuery = _usersQuery.Where(c => c.IsActive);
            _paginationHelper.Search(FillUsersListDataGridView, _usersQuery);
        }

        private void exportToCSVButton_Click(object sender, EventArgs e)
        {
            var users = _usersQuery.ToList();

            var lines = new List<string>
            {
                "Id,Usuario,Email,Rol,Fecha de Creación,Última fecha de actualización,Esta Activo"
            };

            foreach (var user in users)
            {
                lines.Add($"{ user.Id }," +
                    $"{ user.UserName }," +
                    $"{ user.Email }," +
                    $"{ user.UserRole.Name }," +
                    $"{ user.CreatedDate }," +
                    $"{ user.LastUpdatedDate }," +
                    $"{ BoolHelper.BoolToYesNoString(user.IsActive) }");
            }

            FileHelper.ExportToCSV("Uusarios.csv", lines);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Hide();
            var clientCreateForm = new UserCreateForm(this, new UserValidator(_applicationDbContext.Users));
            clientCreateForm.Show();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            _backToList = true;
            Close();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
                _paginationHelper.FirstPage(FillUsersListDataGridView, false);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (_backToList)
                _parent.Show();
            else
                _parent.Close();
        }

        private void firstButton_Click(object sender, EventArgs e) => _paginationHelper.FirstPage(FillUsersListDataGridView);

        private void nextButton_Click(object sender, EventArgs e) => _paginationHelper.NextPage(FillUsersListDataGridView);

        private void previousButton_Click(object sender, EventArgs e) => _paginationHelper.PreviousPage(FillUsersListDataGridView);

        private void lastButton_Click(object sender, EventArgs e) => _paginationHelper.LastPage(FillUsersListDataGridView);

        private void currentPageTextBox_KeyPress(object sender, KeyPressEventArgs e) => _paginationHelper.CurrentPageKeyPressEvent(e);

        private void currentPageTextBox_Enter(object sender, EventArgs e) => _paginationHelper.CurrentPageEnterEvent();

        private void currentPageTextBox_TextChanged(object sender, EventArgs e) => _paginationHelper.CurrentPageChangedEvent(FillUsersListDataGridView);
    }
}
