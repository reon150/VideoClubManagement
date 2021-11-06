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

namespace VideoClubManagement.UI.ArticleLendings
{
    public partial class ArticleLendingIndexForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private IQueryable<ArticleLending> _articleLendingQuery;
        private readonly FormPaginationHelper<ArticleLending, int> _paginationHelper;
        private readonly Form _parent;
        private bool _backToList = false;

        public ArticleLendingIndexForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _articleLendingQuery = _applicationDbContext.ArticleLendings.AsQueryable().Include(al => al.Employee).Include(al => al.Article).Include(al => al.Client);
            _paginationHelper = new FormPaginationHelper<ArticleLending, int>(_articleLendingQuery, 15, currentPageTextBox, lastPageTextBox);
        }

        private void FillArticleLendingDataGridView(IEnumerable<ArticleLending> articleLendings)
        {
            articleLendingListDataGridView.Rows.Clear();

            foreach (var articleLending in articleLendings)
            {
                articleLendingListDataGridView.Rows.Add(articleLending.Id,
                    $"{ articleLending.Client.FirstName } { articleLending.Client.LastName }",
                    articleLending.Article.Title,
                    $"{ articleLending.Employee.FirstName } { articleLending.Employee.LastName }",
                    articleLending.IsActive);
            }
        }

        private void articleLendingListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                int articleLendingId = (int)articleLendingListDataGridView[0, e.RowIndex].Value;
                switch (articleLendingListDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case nameof(deleteButton):
                        DeleteArticleLending(articleLendingId);
                        break;
                    case nameof(detailsButton):
                        Hide();
                        var articleLendingDetailsForm = new ArticleLendingDetailsForm(this, articleLendingId);
                        articleLendingDetailsForm.Show();
                        break;
                    case nameof(editButton):
                        Hide();
                        var articleLendingEditForm = new ArticleLendingEditForm(this, articleLendingId, new ArticleLendingValidator());
                        articleLendingEditForm.Show();
                        break;
                    default:
                        break;
                }
            }
        }

        private void DeleteArticleLending(int id)
        {
            var articleLenging = _applicationDbContext.ArticleLendings.SingleOrDefault(x => x.Id == id);
            var delete = MessageBox.Show($"¿Estas seguro que deseas eliminar este registro? Esto no se puede deshacer",
                "Adventencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;

            if (delete)
            {
                _applicationDbContext.ArticleLendings.Remove(articleLenging);
                _applicationDbContext.SaveChanges();
                onlyShowActivesCheckBox.Checked = false;
                searchTextBox.Text = "";
                _paginationHelper.FirstPage(FillArticleLendingDataGridView, false);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _articleLendingQuery = _applicationDbContext.ArticleLendings.Where(c => c.Id.ToString().Contains(searchTextBox.Text)
                || c.Employee.FirstName.Contains(searchTextBox.Text)
                || c.Employee.LastName.Contains(searchTextBox.Text)
                || c.Client.FirstName.Contains(searchTextBox.Text)
                || c.Client.LastName.Contains(searchTextBox.Text)
                || c.Article.Title.Contains(searchTextBox.Text));

            if (onlyShowActivesCheckBox.Checked) _articleLendingQuery = _articleLendingQuery.Where(c => c.IsActive);
            _paginationHelper.Search(FillArticleLendingDataGridView, _articleLendingQuery);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Hide();
            var articleLendingCreateForm = new ArticleLendingCreateForm(this, new ArticleLendingValidator());
            articleLendingCreateForm.Show();
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
                _paginationHelper.FirstPage(FillArticleLendingDataGridView, false);
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

        private void firstButton_Click(object sender, EventArgs e) => _paginationHelper.FirstPage(FillArticleLendingDataGridView);

        private void nextButton_Click(object sender, EventArgs e) => _paginationHelper.NextPage(FillArticleLendingDataGridView);

        private void previousButton_Click(object sender, EventArgs e) => _paginationHelper.PreviousPage(FillArticleLendingDataGridView);

        private void lastButton_Click(object sender, EventArgs e) => _paginationHelper.LastPage(FillArticleLendingDataGridView);

        private void currentPageTextBox_KeyPress(object sender, KeyPressEventArgs e) => _paginationHelper.CurrentPageKeyPressEvent(e);

        private void currentPageTextBox_Enter(object sender, EventArgs e) => _paginationHelper.CurrentPageEnterEvent();

        private void currentPageTextBox_TextChanged(object sender, EventArgs e) => _paginationHelper.CurrentPageChangedEvent(FillArticleLendingDataGridView);
    }
}
