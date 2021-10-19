using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.Helpers
{
    public class FormPaginationHelper<TEntity, TIdType>
        where TEntity : BaseEntity<TIdType>
    {
        private int _currentPage = 1;
        private readonly int _pageSize;
        private IQueryable<TEntity> _query;
        private readonly TextBox _currentPageTextBox;
        private readonly TextBox _lastPageTextBox;
        private string _oldCurrentPage = string.Empty;

        public FormPaginationHelper(IQueryable<TEntity> query, int pageSize, TextBox currentPageTextBox, TextBox lastPageTextBox)
        {
            _query = query;
            _pageSize = pageSize;
            _currentPageTextBox = currentPageTextBox;
            _lastPageTextBox = lastPageTextBox;
        }

        public void Search(Action<IEnumerable<TEntity>> DataGridViewFiller, IQueryable<TEntity> query)
        {
            _query = query;
            _currentPage = 1;
            SetEntitiesInDataDridViewFiller(DataGridViewFiller);
            SetPageNumbers();
        }

        public void FirstPage(Action<IEnumerable<TEntity>> DataGridViewFiller, bool checkIfItIsAlreadyOnTheFirstPage = true)
        {
            if (_currentPage == 1 && checkIfItIsAlreadyOnTheFirstPage)
            {
                MessageBox.Show("Ya se encuentra en la primera página.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _currentPage = 1;
                SetEntitiesInDataDridViewFiller(DataGridViewFiller);
                SetPageNumbers();
            }
        }

        public void PreviousPage(Action<IEnumerable<TEntity>> DataGridViewFiller)
        {
            if (_currentPage == 1)
            {
                MessageBox.Show("Ya esta en la primera página.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _currentPage -= 1;
                SetEntitiesInDataDridViewFiller(DataGridViewFiller);
                SetPageNumbers();
            }
        }

        public void NextPage(Action<IEnumerable<TEntity>> DataGridViewFiller)
        {
            if (_currentPage == TotalNumberOfPages())
            {
                MessageBox.Show("Ya esta en la ultima pagina.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _currentPage += 1;
                SetEntitiesInDataDridViewFiller(DataGridViewFiller);
                SetPageNumbers();
            }
        }

        public void LastPage(Action<IEnumerable<TEntity>> DataGridViewFiller)
        {
            int previousPage = _currentPage;
            _currentPage = TotalNumberOfPages();

            if (previousPage == _currentPage)
            {
                MessageBox.Show("Ya se encuentra en la ultima página.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SetEntitiesInDataDridViewFiller(DataGridViewFiller);
                SetPageNumbers();
            }
        }

        public void CurrentPageKeyPressEvent(KeyPressEventArgs e) =>
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);     

        public void CurrentPageEnterEvent() =>
            _oldCurrentPage = _currentPageTextBox.Text;

        public void CurrentPageChangedEvent(Action<IEnumerable<TEntity>> DataGridViewFiller)
        {
            if (_currentPageTextBox.Text != "")
            {
                var page = int.Parse(_currentPageTextBox.Text);

                if (page <= 0)
                {
                    MessageBox.Show("El número de página solo puede mayor a 0", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _currentPageTextBox.Text = _oldCurrentPage;
                }
                else if (page > TotalNumberOfPages())
                {
                    MessageBox.Show("El número de página no puede ser mayor al número total de páginas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _currentPageTextBox.Text = _oldCurrentPage;
                }
                else
                {
                    _currentPage = page;
                    SetEntitiesInDataDridViewFiller(DataGridViewFiller);
                    SetPageNumbers();
                }
            }
        }

        private void SetPageNumbers()
        {
            _currentPageTextBox.Text = _currentPage > 0 ? _currentPage.ToString() : "";
            _lastPageTextBox.Text = TotalNumberOfPages().ToString();
        }

        private void SetEntitiesInDataDridViewFiller(Action<IEnumerable<TEntity>> DataGridViewFiller)
        {
            var entities = _query.OrderByDescending(c => c.CreatedDate).Skip((_currentPage - 1) * _pageSize)
                .Take(_pageSize).AsNoTracking().AsEnumerable();

            DataGridViewFiller(entities);
        }

        private int TotalNumberOfPages()
        {
            int totalNumberOfEntities = _query.Count();
            int totalNumberOfPages = totalNumberOfEntities / _pageSize;

            if (totalNumberOfEntities % _pageSize != 0)
                totalNumberOfPages++;
            return totalNumberOfPages;
        }
    }
}
