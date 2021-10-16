using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;

namespace VideoClubManagement.UI.Clients
{
    public partial class ClientDetailsForm : Form
    {
        private readonly Form _parent;
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private bool _backToList = false;

        public ClientDetailsForm(Form parent, int clientId)
        {
            InitializeComponent();
            _parent = parent;
            FillClientData(clientId);
        }

        private void FillClientData(int clientId)
        {
            var client = _applicationDbContext.Clients.Where(c => c.Id == clientId)
                .Include(c => c.LegalPersonType)
                .FirstOrDefault();

            idValueLabel.Text = client.Id.ToString();
            legalPersonTypeValueLabel.Text = client.LegalPersonType.Name;
            isActiveCheckBox.CheckState = client.IsActive ? CheckState.Checked : CheckState.Unchecked;
            fullNameValueLabel.Text = $"{ client.FirstName } { client.LastName }";
            taxpayerIdentificationNumberValueLabel.Text = client.TaxpayerIdentificationNumber;
            creditCardNumberValueLabel.Text = client.CreditCardNumber;
            creditLimitValueLabel.Text = client.CreditLimit.ToString();
            createdDateValueLabel.Text = client.CreatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            lastUpdatedValueDateLabel.Text = client.LastUpdatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (_backToList)
                _parent.Show();
            else
                _parent.Close();
        }

        private void backToListButton_Click(object sender, EventArgs e)
        {
            _backToList = true;
            Close();
        }
    }
}
