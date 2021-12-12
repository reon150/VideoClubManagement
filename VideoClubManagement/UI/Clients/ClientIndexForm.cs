using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Data.Enums;
using VideoClubManagement.Helpers;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Clients
{
    public partial class ClientIndexForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private IQueryable<Client> _clientsQuery;
        private const int _pageSize = 15;
        private readonly FormPaginationHelper<Client, int> _paginationHelper;
        private readonly Form _parent;
        private bool _backToList = false;

        public ClientIndexForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _clientsQuery = _applicationDbContext.Clients.AsQueryable();
            _paginationHelper = new FormPaginationHelper<Client, int>(_clientsQuery, _pageSize, currentPageTextBox, lastPageTextBox);
        }

        private void FillClientListDataGridView(IEnumerable<Client> clients)
        {
            clientListDataGridView.Rows.Clear();

            foreach (var client in clients)
            {
                clientListDataGridView.Rows.Add(client.Id,
                    client.FirstName,
                    client.LastName,
                    client.TaxpayerIdentificationNumber,
                    client.IsActive);
            }
        }

        private void clientListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                int clientId = (int)clientListDataGridView[0, e.RowIndex].Value;
                switch (clientListDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case nameof(deleteButton):
                        DeleteClient(clientId);
                        break;
                    case nameof(detailsButton):
                        Hide();
                        var clientDetailsForm = new ClientDetailsForm(this, clientId);
                        clientDetailsForm.Show();
                        break;
                    case nameof(editButton):
                        Hide();
                        var clientEditForm = new ClientEditForm(this, clientId, new ClientValidator(_applicationDbContext.Clients));
                        clientEditForm.Show();
                        break;
                    default:
                        break;
                }
            }
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
                _paginationHelper.FirstPage(FillClientListDataGridView, false);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _clientsQuery = _applicationDbContext.Clients.Where(c => c.Id.ToString().Contains(searchTextBox.Text)
                || c.FirstName.Contains(searchTextBox.Text)
                || c.LastName.Contains(searchTextBox.Text)
                || c.TaxpayerIdentificationNumber.Contains(searchTextBox.Text));

            if (onlyShowActivesCheckBox.Checked) _clientsQuery = _clientsQuery.Where(c => c.IsActive);
            _paginationHelper.Search(FillClientListDataGridView, _clientsQuery);
        }

        private void exportToCSVButton_Click(object sender, EventArgs e)
        {
            var clients = _clientsQuery.ToList();

            var lines = new List<string>
            {
                "Identificador,Nombre,Número de Identificación del Contribuyente,No. Tarjeta CR,Límite de Credito,Tipo Persona,Fecha de Creación,Última fecha de actualización,Esta Activo"
            };

            foreach (var client in clients)
            {
                lines.Add($"{ client.Id }," +
                    $"{ client.FirstName } { client.LastName }," +
                    $"{ client.TaxpayerIdentificationNumber }," +
                    $"{ client.CreditCardNumber }," +
                    $"{ client.CreditLimit }," +
                    $"{ (client.LegalPersonTypeId == LegalPersonTypeId.Physical ? "Física" : "Jurídica") }," +
                    $"{ client.CreatedDate }," +
                    $"{ client.LastUpdatedDate }," +
                    $"{ BoolHelper.BoolToYesNoString(client.IsActive) }");
            }

            FileHelper.ExportToCSV("Clientes.csv", lines);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Hide();
            var clientCreateForm = new ClientCreateForm(this, new ClientValidator(_applicationDbContext.Clients));
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
                _paginationHelper.FirstPage(FillClientListDataGridView, false);
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

        private void firstButton_Click(object sender, EventArgs e) => _paginationHelper.FirstPage(FillClientListDataGridView);

        private void nextButton_Click(object sender, EventArgs e) => _paginationHelper.NextPage(FillClientListDataGridView);

        private void previousButton_Click(object sender, EventArgs e) => _paginationHelper.PreviousPage(FillClientListDataGridView);

        private void lastButton_Click(object sender, EventArgs e) => _paginationHelper.LastPage(FillClientListDataGridView);

        private void currentPageTextBox_KeyPress(object sender, KeyPressEventArgs e) => _paginationHelper.CurrentPageKeyPressEvent(e);

        private void currentPageTextBox_Enter(object sender, EventArgs e) => _paginationHelper.CurrentPageEnterEvent();

        private void currentPageTextBox_TextChanged(object sender, EventArgs e) => _paginationHelper.CurrentPageChangedEvent(FillClientListDataGridView);
    }
}
