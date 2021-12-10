using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Helpers;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Employee
{
    public partial class employeeForm : Form
    {
        public Data.Entities.Employee Employees { get; set; }
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        private readonly Form _parent;
        private IValidator<Data.Entities.Employee> _validator;
        private IQueryable<Data.Entities.Employee> employeeQuery;

        public employeeForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _validator = new EmployeeValidator(applicationDbContext.Employees);
        }
        private void refreshData()
        {
            employeeDataGridView.DataSource = applicationDbContext.Employees.ToList();
            employeeDataGridView.Columns[0].HeaderText = "Nombre";
            employeeDataGridView.Columns[1].HeaderText = "Apellido";
            employeeDataGridView.Columns[2].HeaderText = "Cedula";
            employeeDataGridView.Columns[3].HeaderText = "Comision";
            employeeDataGridView.Columns[4].HeaderText = "Fecha ingreso";
            employeeDataGridView.Columns[5].HeaderText = "Id Tanda de trabajo";
            employeeDataGridView.Columns[6].Visible=false;
            employeeDataGridView.Columns[7].HeaderText = "Identificador";
            employeeDataGridView.Columns[8].HeaderText = "Esta activo";
            employeeDataGridView.Columns[9].HeaderText = "Fecha creacion";
            employeeDataGridView.Columns[10].HeaderText = "Ultima fecha actualizacion";
         
        }

        private void generalSearch()
        {
            employeeQuery = from sh in applicationDbContext.Employees
                            where (sh.FirstName.ToString().StartsWith(searchTextBox.Text)
                                || sh.LastName.ToString().StartsWith(searchTextBox.Text)
                                || sh.IdentificationNumber.ToString().StartsWith(searchTextBox.Text)
                                || sh.CommissionPercentage.ToString().StartsWith(searchTextBox.Text)
                                || sh.EnteringDate.ToString().StartsWith(searchTextBox.Text)
                                || sh.ShiftWorkId.ToString().StartsWith(searchTextBox.Text)
                                )
                            select sh;
            employeeDataGridView.DataSource = employeeQuery.ToList();
            employeeDataGridView.Refresh();
        }

        private void clearData()
        {
            nameTextBox.Clear();
            lastnameTextBox.Clear();
            identificationTextBox.Clear();
            commissionNumericUpDown.Refresh();
            enteringDateTimePicker.Refresh();
            shiftworkComboBox.Refresh();
            idTextBox.Clear();
            statusCheck.Checked = (bool)false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var save = MessageBox.Show($"¿Estás seguro que deseas guardar estos datos?",
               "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;

                if (save)
                {
                    Data.Entities.Employee employee = new Data.Entities.Employee
                    {
                        FirstName = nameTextBox.Text,
                        LastName = lastnameTextBox.Text,
                        IdentificationNumber = identificationTextBox.Text,
                        CommissionPercentage = commissionNumericUpDown.Value,
                        EnteringDate = enteringDateTimePicker.Value,
                        ShiftWorkId = (int)shiftworkComboBox.SelectedValue,
                        IsActive=(bool)statusCheck.Checked
                    };
                    var validationErrors = _validator.GetValidationErrors(employee);

                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        string errors = "";
                        foreach (var validationError in validationErrors)
                            errors += $"{ validationError }{ Environment.NewLine }";

                        MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        applicationDbContext.Employees.Add(employee);
                        applicationDbContext.SaveChanges();
                        MessageBox.Show("El registro se guardo con exito");
                        refreshData();
                        clearData();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var update = MessageBox.Show($"¿Estás seguro que deseas actualizar estos datos?",
             "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                if (update)
                {
                    Data.Entities.Employee employee = applicationDbContext.Employees.Find(Int32.Parse(idTextBox.Text));
                    employee.FirstName = nameTextBox.Text;
                    employee.LastName = lastnameTextBox.Text;
                    employee.IdentificationNumber = identificationTextBox.Text;
                    employee.CommissionPercentage = commissionNumericUpDown.Value;
                    employee.EnteringDate = DateTime.Parse(enteringDateTimePicker.Text);
                    employee.ShiftWorkId = int.Parse(shiftworkComboBox.SelectedValue.ToString());
                    employee.IsActive = (bool)statusCheck.Checked;
                    if (employee != null)
                    {
                        var validationErrors = _validator.GetValidationErrors(employee);
                        if (validationErrors != null && validationErrors.Count > 0)
                        {
                            string errors = "";
                            foreach (var validationError in validationErrors)
                                errors += $"{ validationError }{ Environment.NewLine }";

                            MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            applicationDbContext.SaveChanges();
                            MessageBox.Show("Registro actualizado con exito.");
                            refreshData();
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error al actualizar " + ex);
            }
           
}

    private void deleteButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var delete = MessageBox.Show($"¿Estás seguro que deseas eliminar estos datos?",
              "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                if (delete)
                {
                    Data.Entities.Employee employee = applicationDbContext.Employees.Find(Int32.Parse(idTextBox.Text));
                    if (employee != null)
                    {
                        applicationDbContext.Employees.Remove(employee);
                        applicationDbContext.SaveChanges();
                        MessageBox.Show("Registro eliminado con exito.");
                        refreshData();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error al eliminar " + ex);
            }
        }

        private void employeeForm_Load(object sender, EventArgs e)
        {
            refreshData();
            shiftworkComboBox.DataSource = applicationDbContext.ShiftWorks.ToList();
            employeeQuery = applicationDbContext.Employees;
            shiftworkComboBox.DisplayMember = "Description";
            shiftworkComboBox.ValueMember = "Id";


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            generalSearch();
        }

        private void employeeDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                   nameTextBox.Text=employeeDataGridView.CurrentRow.Cells[0].Value.ToString();
                   lastnameTextBox.Text= employeeDataGridView.CurrentRow.Cells[1].Value.ToString();
                   identificationTextBox.Text= employeeDataGridView.CurrentRow.Cells[2].Value.ToString();
                   commissionNumericUpDown.Value = decimal.Parse(employeeDataGridView.CurrentRow.Cells[3].Value.ToString());
                   enteringDateTimePicker.Text= employeeDataGridView.CurrentRow.Cells[4].Value.ToString();
                   shiftworkComboBox.SelectedValue = Int32.Parse(employeeDataGridView.CurrentRow.Cells[5].Value.ToString());
                   idTextBox.Text = employeeDataGridView.CurrentRow.Cells[7].Value.ToString();
                   statusCheck.Checked = (bool) employeeDataGridView.CurrentRow.Cells[8].Value;
                  

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            _parent.Show();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var employee = employeeQuery.ToList();

            var lines = new List<string>
            {
                "Identificador, Nombre, Apellido, Cedula,Comision, Tanda Id, Fecha inicio, Esta activo, Última fecha de actualizacion"
            };

            foreach (var i in employee)
            {
                lines.Add($"{ i.Id }," +
                    $"{ i.FirstName }," +
                    $"{ i.LastName }," +
                    $"{ i.IdentificationNumber }," +
                    $"{ i.CommissionPercentage }," +
                    $"{ i.ShiftWorkId }," +
                    $"{ i.EnteringDate }," +
                    $"{ i.IsActive }," +
                    $"{ i.LastUpdatedDate }"
                    );
            }

            FileHelper.ExportToCSV("employee.csv", lines);
        }
    }
}
