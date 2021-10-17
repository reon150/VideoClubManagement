using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.UI.General;

namespace VideoClubManagement.UI.Employee
{
    public partial class employeeForm : Form
    {
        public Data.Entities.Employee Employees { get; set; }
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        public employeeForm()
        {
            InitializeComponent();
        }
        private void refreshData()
        {
            employeeDataGridView.DataSource = applicationDbContext.Employees.ToList();
        }

        private void generalSearch()
        {
            var employees = from sh in applicationDbContext.Employees
                            where (sh.FirstName.ToString().StartsWith(searchTextBox.Text)
                                || sh.LastName.ToString().StartsWith(searchTextBox.Text)
                                || sh.IdentificationNumber.ToString().StartsWith(searchTextBox.Text)
                                || sh.CommissionPercentage.ToString().StartsWith(searchTextBox.Text)
                                || sh.EnteringDate.ToString().StartsWith(searchTextBox.Text)
                                || sh.ShiftWorkId.ToString().StartsWith(searchTextBox.Text)
                                )
                            select sh;
            employeeDataGridView.DataSource = employees.ToList();
            employeeDataGridView.Refresh();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                applicationDbContext.Employees.Add(new Data.Entities.Employee
                {
                    FirstName = nameTextBox.Text,
                    LastName = lastnameTextBox.Text,
                    IdentificationNumber = identificationTextBox.Text,
                    CommissionPercentage = commissionNumericUpDown.Value,
                    EnteringDate = enteringDateTimePicker.Value,
                    ShiftWorkId = (int)shiftworkComboBox.SelectedValue

                }) ;
                applicationDbContext.SaveChanges();
                MessageBox.Show("El registro se guardo con exito");
                refreshData();

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
                Data.Entities.Employee employee = applicationDbContext.Employees.Find(Int32.Parse(idTextBox.Text));
                if (employee != null)
                {

                    employee.FirstName = nameTextBox.Text;
                    employee.LastName = lastnameTextBox.Text;
                    employee.IdentificationNumber = identificationTextBox.Text;
                    employee.CommissionPercentage =commissionNumericUpDown.Value;
                    employee.EnteringDate = DateTime.Parse(enteringDateTimePicker.Text);
                    employee.ShiftWorkId = int.Parse(shiftworkComboBox.SelectedValue.ToString());


                }
                MessageBox.Show("Registro actualizado con exito.");
                refreshData();
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
                Data.Entities.Employee employee = applicationDbContext.Employees.Find(Int32.Parse(idTextBox.Text));
                if (employee != null)
                {
                    applicationDbContext.Employees.Remove(employee);
                    applicationDbContext.SaveChanges();

                }
                MessageBox.Show("Registro eliminado con exito.");
                refreshData();
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
                   idTextBox.Text = employeeDataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            new MenuForm().Show();
        }
    }
}
