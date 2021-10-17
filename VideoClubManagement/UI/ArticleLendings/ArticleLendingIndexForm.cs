using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.UI.ArticleLendings
{
    public partial class ArticleLendingIndexForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private IQueryable<ArticleLending> _articleLendingQuery;
        private const int _pageSize = 15;
        private int _currentPage = 1;
        private readonly Form _parent;
        private bool _backToList = false;

        public ArticleLendingIndexForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void ArticleLendingIndexForm_Load(object sender, EventArgs e) =>
            _articleLendingQuery = _applicationDbContext.ArticleLendings.AsQueryable();

        private void FillArticleLendingDataGridView(int pageNumber)
        {
            int startIndex = _pageSize * (pageNumber - 1);
            var articleLendings = _articleLendingQuery.OrderByDescending(c => c.CreatedDate).Skip((pageNumber - 1) * _pageSize).Take(_pageSize)
                .Include(al => al.Employee).Include(al => al.Article).Include(al => al.Client)
                .AsNoTracking().AsEnumerable();

            articleLendingListDataGridView.Rows.Clear();

            foreach (var articleLending in articleLendings)
            {
                articleLendingListDataGridView.Rows.Add(articleLending.Id,
                    $"{ articleLending.Client.FirstName } { articleLending.Client.LastName }",
                    articleLending.Article.Title,
                    $"{ articleLending.Employee.FirstName } { articleLending.Employee.LastName }",
                    articleLending.IsActive);
            }

            if (articleLendings.Count() > 0)
                currentPageTextBox.Text = pageNumber.ToString();
            else
                currentPageTextBox.Text = "";

            lastPageTextBox.Text = TotalNumberOfPages().ToString();
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
            FillArticleLendingDataGridView(1);
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
                FillArticleLendingDataGridView(_currentPage);
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
                FillArticleLendingDataGridView(_currentPage);
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
                FillArticleLendingDataGridView(_currentPage);
            }
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            int previousPage = _currentPage;
            _currentPage = TotalNumberOfPages();

            if (previousPage == _currentPage)
                MessageBox.Show("Ya se encuentra en la ultima página.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                FillArticleLendingDataGridView(_currentPage);
        }

        private int TotalNumberOfPages()
        {
            int totnalNumberOfArticleLendings = _articleLendingQuery.Count();
            int totalNumberOfPages = totnalNumberOfArticleLendings / _pageSize;

            if (totnalNumberOfArticleLendings % _pageSize != 0)
                totalNumberOfPages++;
            return totalNumberOfPages;
        }

        private void articleLendingListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                int articleLendingId = (int)articleLendingListDataGridView[0, e.RowIndex].Value;
                switch (articleLendingListDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "deleteButton":
                        DeleteArticleLending(articleLendingId);
                        break;
                    case "detailsButton":
                        Hide();
                        var articleLendingDetailsForm = new ArticleLendingDetailsForm(this, articleLendingId);
                        articleLendingDetailsForm.Show();
                        break;
                    case "editButton":
                        Hide();
                        var articleLendingEditForm = new ArticleLendingEditForm(this, articleLendingId);
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
                _currentPage = 1;
                FillArticleLendingDataGridView(_currentPage);
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
                    FillArticleLendingDataGridView(_currentPage = page);
                }
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
                FillArticleLendingDataGridView(1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Hide();
            var articleLendingCreateForm = new ArticleLendingCreateForm(this);
            articleLendingCreateForm.Show();
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

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            _backToList = true;
            Close();
        }
    }
}
