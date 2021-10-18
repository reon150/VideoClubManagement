using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.UI.Clients
{
    public partial class ClientIndexForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private IQueryable<Client> _clientsQuery; 
        private const int _pageSize = 15;
        private int _currentPage = 1;
        private readonly Form _parent;
        private bool _backToList = false;

        public ClientIndexForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void ClientIndexForm_Load(object sender, EventArgs e) =>
            _clientsQuery = _applicationDbContext.Clients.AsQueryable();
        
        private void FillClientListDataGridView(int pageNumber)
        {
            int startIndex = _pageSize * (pageNumber - 1);
            var clients = _clientsQuery.OrderByDescending(c => c.CreatedDate).Skip((pageNumber - 1) * _pageSize)
                .Take(_pageSize).AsNoTracking().AsEnumerable();

            clientListDataGridView.Rows.Clear();

            foreach (var client in clients)
            {
                clientListDataGridView.Rows.Add(client.Id,
                    client.FirstName,
                    client.LastName,
                    client.TaxpayerIdentificationNumber,
                    client.IsActive);
            }

            if (clients.Count() > 0)
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
            if (e.ColumnIndex >= 0)
            {
                int clientId = (int)clientListDataGridView[0, e.RowIndex].Value;
                switch (clientListDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "deleteButton":
                        DeleteClient(clientId);
                        break;
                    case "detailsButton":
                        Hide();
                        var clientDetailsForm = new ClientDetailsForm(this, clientId);
                        clientDetailsForm.Show();
                        break;
                    case "editButton":
                        Hide();
                        var clientEditForm = new ClientEditForm(this, clientId);
                        clientEditForm.Show();
                        break;
                    default:
                        break;
                }
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
                    FillClientListDataGridView(_currentPage = page);
                }  
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Hide();
            var clientCreateForm = new ClientCreateForm(this);
            clientCreateForm.Show();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
                FillClientListDataGridView(1);
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
