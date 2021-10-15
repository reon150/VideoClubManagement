using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;

namespace VideoClubManagement.UI.Client
{
    public partial class ClientIndexForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private IQueryable<Data.Entities.Client> _clientsQuery; 
        private int _pageSize = 15;
        private int _currentPage = 1;

        public ClientIndexForm() => InitializeComponent();

        private void ClientIndexForm_Load(object sender, EventArgs e)
        {
            _clientsQuery = _applicationDbContext.Clients.AsQueryable();
            FillClientListDataGridView(1);
        }

        private void FillClientListDataGridView(int pageNumber)
        {
            int startIndex = _pageSize * (pageNumber - 1);
            var clients = _clientsQuery.OrderBy(c => c.Id).Skip((pageNumber - 1) * _pageSize).Take(_pageSize).ToList();

            clientListDataGridView.Rows.Clear();

            foreach (var client in clients)
            {
                clientListDataGridView.Rows.Add(client.Id,
                    client.FirstName,
                    client.LastName,
                    client.TaxpayerIdentificationNumber,
                    client.IsActive);
            }

            currentPageTextBox.Text = pageNumber.ToString();
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
                FillClientListDataGridView(_currentPage);
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
                FillClientListDataGridView(_currentPage);
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
                FillClientListDataGridView(_currentPage);
            }
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            int previousPage = _currentPage;
            _currentPage = TotalNumberOfPages();

            if (previousPage == _currentPage)
                MessageBox.Show("Ya se encuentra en la ultima página.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                FillClientListDataGridView(_currentPage);
        }

        private int TotalNumberOfPages()
        {
            int totalNumberOfClients = _clientsQuery.Count();
            int totalNumberOfPages = totalNumberOfClients / _pageSize;

            if (totalNumberOfClients % _pageSize != 0)
                totalNumberOfPages++;
            return totalNumberOfPages;
        }

        private void clientListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (clientListDataGridView.Columns[e.ColumnIndex].Name)
            {
                case "deleteButton":
                    DeleteClient((int) clientListDataGridView[0, e.RowIndex].Value);
                    break;
                default:
                    break;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _clientsQuery = _applicationDbContext.Clients.Where(c => c.Id.ToString().Contains(searchTextBox.Text)
                || c.FirstName.Contains(searchTextBox.Text)
                || c.LastName.Contains(searchTextBox.Text)
                || c.TaxpayerIdentificationNumber.Contains(searchTextBox.Text));

            if (onlyShowActivesCheckBox.Checked) _clientsQuery = _clientsQuery.Where(c => c.IsActive);
            FillClientListDataGridView(1);
        }

        private void DeleteClient(int id)
        {
            var client = _applicationDbContext.Clients.SingleOrDefault(x => x.Id == id);
            var delete = MessageBox.Show($"¿Estas seguro que deseas eliminar cliente { client.FirstName } { client.LastName }?", 
                "Adventencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;

            if (delete)
            {
                _applicationDbContext.Clients.Remove(client);
                _applicationDbContext.SaveChanges();
                onlyShowActivesCheckBox.Checked = false;
                searchTextBox.Text = "";
                _currentPage = 1;
                FillClientListDataGridView(_currentPage);
            }
        }

        private void currentPageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        string oldCurrentPage = string.Empty;

        private void currentPageTextBox_Enter(object sender, EventArgs e)
        {
            oldCurrentPage = currentPageTextBox.Text;
        }

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
                    FillClientListDataGridView(_currentPage = page);
                }  
            }
        }
    }
}
