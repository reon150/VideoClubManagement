using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Enums;

namespace VideoClubManagement.UI.Clients
{
    public partial class ClientEditForm : Form
    {
        private readonly Form _parent;
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private System.Timers.Timer _timer = new System.Timers.Timer(1000);
        private bool _backToList = false;
        private bool _changesSaved = false;
        
        public ClientEditForm(Form paren, int clientId)
        {
            InitializeComponent();
            _parent = paren;
            _timer.Elapsed += UpdateCurrentDateTimeLabel;
            SetLegalPersonTypeComboBox();
            FillClientData(clientId);

            _timer.Start();
        }

        private void UpdateCurrentDateTimeLabel(object sender, ElapsedEventArgs e) =>
            currentDateTimeLabel.Invoke((Action)delegate
            {
                currentDateTimeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            });

        private void FillClientData(int clientId)
        {
            var client = _applicationDbContext.Clients.Where(c => c.Id == clientId)
                .Include(c => c.LegalPersonType)
                .FirstOrDefault();

            idValueLabel.Text = client.Id.ToString();
            isActiveCheckBox.CheckState = client.IsActive ? CheckState.Checked : CheckState.Unchecked;
            firstNameTextBox.Text = client.FirstName;
            lastNameTextBox.Text = client.LastName;
            taxpayerIdentificationNumberTextBox.Text = client.TaxpayerIdentificationNumber;
            creditCardNumberTextBox.Text = client.CreditCardNumber;
            creditLimitTextBox.Text = client.CreditLimit.ToString();
            createdDateValueLabel.Text = client.CreatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            lastUpdatedValueDateLabel.Text = client.LastUpdatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            isActiveCheckBox.Checked = client.IsActive;
            if (client.LegalPersonTypeId == LegalPersonTypeId.Physical)
                legalPersonTypeComboBox.SelectedIndex = 0;
            else if(client.LegalPersonTypeId == LegalPersonTypeId.Juridic)
                legalPersonTypeComboBox.SelectedIndex = 1;
        }

        private void SetLegalPersonTypeComboBox()
        {
            var legalPersonTypes = _applicationDbContext.LegalPersonTypes.AsEnumerable();
            legalPersonTypeComboBox.DisplayMember = "Name";
            legalPersonTypeComboBox.ValueMember = "Id";
            foreach (var legalPersonType in legalPersonTypes)
                legalPersonTypeComboBox.Items.Add(new { Id = legalPersonType.Id, Name = legalPersonType.Name });
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            var legalPersonTypeComboBoxSelectedItem = legalPersonTypeComboBox.SelectedItem;

            Enum.TryParse(legalPersonTypeComboBoxSelectedItem
                .GetType().GetProperty("Id").GetValue(legalPersonTypeComboBoxSelectedItem, null).ToString(),
                out LegalPersonTypeId legalPersonTypeId);

            var clientId = int.Parse(idValueLabel.Text);
            var client = _applicationDbContext.Clients.Where(c => c.Id == clientId).FirstOrDefault();


            client.Id = clientId;
            client.FirstName = firstNameTextBox.Text;
            client.LastName = lastNameTextBox.Text;
            client.TaxpayerIdentificationNumber = taxpayerIdentificationNumberTextBox.Text;
            client.CreditCardNumber = creditCardNumberTextBox.Text;
            client.CreditLimit = decimal.Parse(creditLimitTextBox.Text);
            client.LegalPersonTypeId = legalPersonTypeId;
            client.IsActive = isActiveCheckBox.Checked;
            
            _applicationDbContext.SaveChanges();

            _changesSaved = true;
            _backToList = true;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            bool close = true;

            if (!_changesSaved)
            {
                close = MessageBox.Show($"¿Estás seguro que deseas volver atrás? Las modificaciones no guardadas se perderán",
                "Adventencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
            }

            if (close)
            {
                if (_backToList)
                {
                    _timer.Close();
                    _parent.Show();
                }
                else
                {
                    _parent.Close();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void backToListButton_Click(object sender, EventArgs e)
        {
            _backToList = true;
            Close();
        }
    }
}
