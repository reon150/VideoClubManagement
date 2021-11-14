using System;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Data.Enums;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Clients
{
    public partial class ClientCreateForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private System.Timers.Timer _timer = new System.Timers.Timer(1000);
        private readonly Form _parent;
        private bool _backToList = false;
        private bool _changesSaved = false;
        private readonly IValidator<Client> _validator;

        public ClientCreateForm(Form parent, IValidator<Client> validator)
        {
            _parent = parent;
            _validator = validator;
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
                legalPersonTypeComboBox.Items.Add(new { legalPersonType.Id, legalPersonType.Name });
            legalPersonTypeComboBox.SelectedIndex = 0;
        }

        private void createClientButton_Click(object sender, EventArgs e)
        {
            var save = MessageBox.Show($"¿Estás seguro que deseas guardar estos datos?",
                "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;

            if (save)
            {
                var legalPersonTypeComboBoxSelectedItem = legalPersonTypeComboBox.SelectedItem;

                Enum.TryParse(legalPersonTypeComboBoxSelectedItem
                    .GetType().GetProperty("Id").GetValue(legalPersonTypeComboBoxSelectedItem, null).ToString(),
                    out LegalPersonTypeId legalPersonTypeId);

                decimal.TryParse(creditLimitTextBox.Text, out decimal creditLimit);

                Client client = new Client
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    TaxpayerIdentificationNumber = taxpayerIdentificationNumberTextBox.Text,
                    CreditCardNumber = creditCardNumberTextBox.Text,
                    CreditLimit = creditLimit,
                    LegalPersonTypeId = legalPersonTypeId,
                    IsActive = isActiveCheckBox.Checked
                };

                var validationErrors = _validator.GetValidationErrors(client);

                if (validationErrors != null && validationErrors.Count > 0)
                {
                    string errors = "";
                    foreach (var validationError in validationErrors)
                        errors += $"{ validationError }{ Environment.NewLine }";
                    
                    MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _applicationDbContext.Clients.Add(client);
                    _applicationDbContext.SaveChanges();

                    _changesSaved = true;
                    _backToList = true;
                    Close();
                }
            }
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

        private void creditLimitTextBox_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);   
    }
}
