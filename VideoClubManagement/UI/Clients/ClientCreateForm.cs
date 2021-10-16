using System;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Data.Enums;

namespace VideoClubManagement.UI.Clients
{
    public partial class ClientCreateForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private System.Timers.Timer _timer = new System.Timers.Timer(1000);
        private readonly Form _parent;
        private bool _backToList = false;
        private bool _changesSaved = false;

        public ClientCreateForm(Form parent)
        {
            _parent = parent;
            InitializeComponent();
            _timer.Elapsed += UpdateCurrentDateTimeLabel;

            SetLegalPersonTypeComboBox();

            _timer.Start();
        }

        private void UpdateCurrentDateTimeLabel(object sender, ElapsedEventArgs e) =>
            currentDateTimeLabel.Invoke((Action)delegate
            {
                currentDateTimeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            });

        private void SetLegalPersonTypeComboBox()
        {
            var legalPersonTypes = _applicationDbContext.LegalPersonTypes.AsEnumerable();
            legalPersonTypeComboBox.DisplayMember = "Name";
            legalPersonTypeComboBox.ValueMember = "Id";
            foreach (var legalPersonType in legalPersonTypes)
                legalPersonTypeComboBox.Items.Add(new { Id = legalPersonType.Id, Name = legalPersonType.Name });
            legalPersonTypeComboBox.SelectedIndex = 0;
        }

        private void createClientButton_Click(object sender, EventArgs e)
        {

            var legalPersonTypeComboBoxSelectedItem = legalPersonTypeComboBox.SelectedItem;
            
            Enum.TryParse(legalPersonTypeComboBoxSelectedItem
                .GetType().GetProperty("Id").GetValue(legalPersonTypeComboBoxSelectedItem, null).ToString(), 
                out LegalPersonTypeId legalPersonTypeId);
            
            Client client = new Client
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                TaxpayerIdentificationNumber = taxpayerIdentificationNumberTextBox.Text,
                CreditCardNumber = creditCardNumberTextBox.Text,
                CreditLimit = decimal.Parse(creditLimitTextBox.Text),
                LegalPersonTypeId = legalPersonTypeId,
                IsActive = isActiveCheckBox.Checked
            };
            _applicationDbContext.Clients.Add(client);
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
                close = MessageBox.Show($"¿Estás seguro que deseas volver atrás? Los datos no guardados se perderán",
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
