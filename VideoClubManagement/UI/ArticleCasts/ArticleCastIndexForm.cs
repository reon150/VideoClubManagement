using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.UI.ArticleCasts
{
    public partial class ArticleCastIndexForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private IQueryable<ArticleCast> _articleCastQuery;
        private const int _pageSize = 15;
        private int _currentPage = 1;

        public ArticleCastIndexForm() => InitializeComponent();

        private void ArticleCastIndexForm_Load(object sender, EventArgs e) => 
            _articleCastQuery = _applicationDbContext.ArticleCasts.AsQueryable();

        private void FillArticleCastDataGridView(int pageNumber)
        {
            int startIndex = _pageSize * (pageNumber - 1);
            var articleCasts = _articleCastQuery.OrderByDescending(c => c.CreatedDate).Skip((pageNumber - 1) * _pageSize).Take(_pageSize)
                .Include(ac => ac.Article).Include(ac => ac.Cast).Include(ac => ac.Role)
                .AsNoTracking().AsEnumerable();

            articleCastsDataGridView.Rows.Clear();

            foreach (var articleCast in articleCasts)
            {
                articleCastsDataGridView.Rows.Add(articleCast.Id,
                    articleCast.Article.Title,
                    $"{articleCast.Cast.FirstName} {articleCast.Cast.LastName}",
                    articleCast.Role.Name,
                    articleCast.IsActive);
            }

            if (articleCasts.Count() > 0)
                currentPageTextBox.Text = pageNumber.ToString();
            else
                currentPageTextBox.Text = "";

            lastPageTextBox.Text = TotalNumberOfPages().ToString();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            if (_currentPage == 1)
            {
                MessageBox.Show("Ya se encuentra en la primera página.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _currentPage = 1;
                FillArticleCastDataGridView(_currentPage);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int lastPage = TotalNumberOfPages();
            if (_currentPage == lastPage)
            {
                MessageBox.Show("Ya esta en la ultima pagina.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _currentPage += 1;
                FillArticleCastDataGridView(_currentPage);
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (_currentPage == 1)
            {
                MessageBox.Show("Ya esta en la primera página.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _currentPage -= 1;
                FillArticleCastDataGridView(_currentPage);
            }
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            int previousPage = _currentPage;
            _currentPage = TotalNumberOfPages();

            if (previousPage == _currentPage)
                MessageBox.Show("Ya se encuentra en la ultima página.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                FillArticleCastDataGridView(_currentPage);
        }

        private int TotalNumberOfPages()
        {
            int totalNumberOfArticleCasts = _articleCastQuery.Count();
            int totalNumberOfPages = totalNumberOfArticleCasts / _pageSize;

            if (totalNumberOfArticleCasts % _pageSize != 0)
                totalNumberOfPages++;
            return totalNumberOfPages;
        }

        private void articleCastsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                int articleCastId = (int)articleCastsDataGridView[0, e.RowIndex].Value;
                switch (articleCastsDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "deleteButton":
                        DeleteArticleCast(articleCastId);
                        break;
                    case "detailsButton":
                        Hide();
                        var articleCastDetailsForm = new ArticleCastDetailsForm(this, articleCastId);
                        articleCastDetailsForm.Show();
                        break;
                    case "editButton":
                        Hide();
                        var articleCastEditForm = new ArticleCastEditForm(this, articleCastId);
                        articleCastEditForm.Show();
                        break;
                    default:
                        break;
                }
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
            FillArticleCastDataGridView(1);
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
                _currentPage = 1;
                FillArticleCastDataGridView(_currentPage);
            }
        }

        private void currentPageTextBox_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        string oldCurrentPage = string.Empty;

        private void currentPageTextBox_Enter(object sender, EventArgs e) =>
            oldCurrentPage = currentPageTextBox.Text;

        private void currentPageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (currentPageTextBox.Text != "")
            {
                var page = int.Parse(currentPageTextBox.Text);

                if (page <= 0)
                {
                    MessageBox.Show("El número de página solo puede mayor a 0", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentPageTextBox.Text = oldCurrentPage;
                }
                else if (page > TotalNumberOfPages())
                {
                    MessageBox.Show("El número de página no puede ser mayor al número total de páginas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentPageTextBox.Text = oldCurrentPage;
                }
                else
                {
                    FillArticleCastDataGridView(_currentPage = page);
                }
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
                FillArticleCastDataGridView(1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Hide();
            var articleCastCreateForm = new ArticleCastCreateForm(this);
            articleCastCreateForm.Show();
        }
    }
}
