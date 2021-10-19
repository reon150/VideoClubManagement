using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Helpers;

namespace VideoClubManagement.UI.ArticleCasts
{
    public partial class ArticleCastIndexForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private IQueryable<ArticleCast> _articleCastQuery;
        private readonly FormPaginationHelper<ArticleCast, int> _paginationHelper;
        private const int _pageSize = 15;
        private readonly Form _parent;
        private bool _backToList = false;

        public ArticleCastIndexForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _articleCastQuery = _applicationDbContext.ArticleCasts.AsQueryable().Include(ac => ac.Article).Include(ac => ac.Cast).Include(ac => ac.Role);
            _paginationHelper = new FormPaginationHelper<ArticleCast, int>(_articleCastQuery, _pageSize, currentPageTextBox, lastPageTextBox);
        }

        private void FillArticleCastDataGridView(IEnumerable<ArticleCast> articleCasts)
        {
            articleCastsDataGridView.Rows.Clear();

            foreach (var articleCast in articleCasts)
            {
                articleCastsDataGridView.Rows.Add(articleCast.Id,
                    articleCast.Article.Title,
                    $"{articleCast.Cast.FirstName} {articleCast.Cast.LastName}",
                    articleCast.Role.Name,
                    articleCast.IsActive);
            }
        }

        private void articleCastsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                int articleCastId = (int)articleCastsDataGridView[0, e.RowIndex].Value;
                switch (articleCastsDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case nameof(deleteButton):
                        DeleteArticleCast(articleCastId);
                        break;
                    case nameof(detailsButton):
                        Hide();
                        var articleCastDetailsForm = new ArticleCastDetailsForm(this, articleCastId);
                        articleCastDetailsForm.Show();
                        break;
                    case nameof(editButton):
                        Hide();
                        var articleCastEditForm = new ArticleCastEditForm(this, articleCastId);
                        articleCastEditForm.Show();
                        break;
                    default:
                        break;
                }
            }
        }

        private void DeleteArticleCast(int id)
        {
            
            var delete = MessageBox.Show($"¿Estas seguro que deseas eliminar este registro?",
                "Adventencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;

            if (delete)
            {
                var articleCast = _applicationDbContext.ArticleCasts.SingleOrDefault(x => x.Id == id);
                _applicationDbContext.ArticleCasts.Remove(articleCast);
                _applicationDbContext.SaveChanges();
                onlyShowActivesCheckBox.Checked = false;
                searchTextBox.Text = "";
                _paginationHelper.FirstPage(FillArticleCastDataGridView, false);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _articleCastQuery = _applicationDbContext.ArticleCasts.Where(c => c.Id.ToString().Contains(searchTextBox.Text)
                || c.Article.Title.Contains(searchTextBox.Text)
                || c.Cast.FirstName.Contains(searchTextBox.Text)
                || c.Cast.LastName.Contains(searchTextBox.Text)
                || c.Role.Name.Contains(searchTextBox.Text));

            if (onlyShowActivesCheckBox.Checked) _articleCastQuery = _articleCastQuery.Where(c => c.IsActive);
            _paginationHelper.Search(FillArticleCastDataGridView, _articleCastQuery);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Hide();
            var articleCastCreateForm = new ArticleCastCreateForm(this);
            articleCastCreateForm.Show();
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
                _paginationHelper.FirstPage(FillArticleCastDataGridView, false);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;


            if (_backToList)
            {
                _parent.Show();
            }
            else
            {
                _parent.Close();
            }
        }

        private void firstButton_Click(object sender, EventArgs e) => _paginationHelper.FirstPage(FillArticleCastDataGridView);

        private void nextButton_Click(object sender, EventArgs e) => _paginationHelper.NextPage(FillArticleCastDataGridView);

        private void previousButton_Click(object sender, EventArgs e) => _paginationHelper.PreviousPage(FillArticleCastDataGridView);

        private void lastButton_Click(object sender, EventArgs e) => _paginationHelper.LastPage(FillArticleCastDataGridView);

        private void currentPageTextBox_KeyPress(object sender, KeyPressEventArgs e) => _paginationHelper.CurrentPageKeyPressEvent(e);

        private void currentPageTextBox_Enter(object sender, EventArgs e) => _paginationHelper.CurrentPageEnterEvent();

        private void currentPageTextBox_TextChanged(object sender, EventArgs e) => _paginationHelper.CurrentPageChangedEvent(FillArticleCastDataGridView);
    }
}
