using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Enums;
using VideoClubManagement.Helpers;
using VideoClubManagement.UI.General;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Shiftwork
{
    public partial class shiftworkForm : Form
    {
        public Data.Entities.ShiftWork Shiftworks { get; set; }
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        private IValidator<Data.Entities.ShiftWork> _validator;
        private IQueryable<Data.Entities.ShiftWork> shiftworkQuery;

        private readonly Form _parent;

        public shiftworkForm(Form parent)
        {
            InitializeComponent();
            ManageOptionsAccordingToRole();
            _parent = parent;
            _validator = new ShiftworkValidator(applicationDbContext.ShiftWorks);

        }

        private void employeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastnameLabel_Click(object sender, EventArgs e)
        {

        }
        private void clearData()
        {
            descriptionTextBox.Clear();
            startHourDateTimePicker.ResetText();
            finishHourDateTimePicker.ResetText();
            statusCheck.Checked = false;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startHour = startHourDateTimePicker.Value, finishHour = finishHourDateTimePicker.Value;
                TimeSpan startHourTime = new TimeSpan(startHour.Hour, startHour.Minute, startHour.Second);
                TimeSpan finishHourTime = new TimeSpan(finishHour.Hour, finishHour.Minute, finishHour.Second);
                var save = MessageBox.Show($"¿Estás seguro que deseas guardar estos datos?",
              "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                if (save)
                {
                    Data.Entities.ShiftWork shiftwork = new Data.Entities.ShiftWork {
                        Description = descriptionTextBox.Text,
                        StartHour = startHourTime,
                        FinishHour = finishHourTime,
                        IsActive = statusCheck.Checked
                        };
                    var validationErrors = _validator.GetValidationErrors(shiftwork);
                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        string errors = "";
                        foreach (var validationError in validationErrors)
                            errors += $"{ validationError }{ Environment.NewLine }";

                        MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        applicationDbContext.ShiftWorks.Add(shiftwork);
                        applicationDbContext.SaveChanges();
                        MessageBox.Show("El registro se guardo con exito");
                        refreshData();
                        clearData();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error"+ex.Message);
            }
            
            
            
        }
        private void refreshData()
        {
            shiftworkDataGridView.DataSource = applicationDbContext.ShiftWorks.ToList();
            shiftworkDataGridView.Columns[0].HeaderText = "Descripcion";
            shiftworkDataGridView.Columns[1].HeaderText = "Hora inicio";
            shiftworkDataGridView.Columns[2].HeaderText = "Hora fin";
            shiftworkDataGridView.Columns[3].HeaderText = "Identificador";
            shiftworkDataGridView.Columns[4].HeaderText = "Esta activo";
            shiftworkDataGridView.Columns[5].HeaderText = "Fecha creacion";
            shiftworkDataGridView.Columns[6].HeaderText = "Ultima fecha actualizacion";


        }
        private void shiftworkForm_Load(object sender, EventArgs e)
        {
            shiftworkQuery = applicationDbContext.ShiftWorks;
            refreshData();
        }

        private void shiftworkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void shiftworkDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            descriptionTextBox.Text = shiftworkDataGridView.CurrentRow.Cells[0].Value.ToString();
            startHourDateTimePicker.Text = shiftworkDataGridView.CurrentRow.Cells[1].Value.ToString();
            finishHourDateTimePicker.Text = shiftworkDataGridView.CurrentRow.Cells[2].Value.ToString();
            idTextBox.Text = shiftworkDataGridView.CurrentRow.Cells[3].Value.ToString();
            statusCheck.Checked = (bool)shiftworkDataGridView.CurrentRow.Cells[4].Value;
        }
        private void generalSearch()
        {
            shiftworkQuery = from sh in applicationDbContext.ShiftWorks
                              where (sh.Description.ToString().StartsWith(searchTextBox.Text)
                                                                        ||sh.StartHour.ToString().StartsWith(searchTextBox.Text)
                                                                        ||sh.FinishHour.ToString().StartsWith(searchTextBox.Text))
                                                                        select sh;
            shiftworkDataGridView.DataSource = shiftworkQuery.ToList();
            shiftworkDataGridView.Refresh();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Entities.ShiftWork shiftwork = applicationDbContext.ShiftWorks.Find(Int32.Parse(idTextBox.Text));
                var update = MessageBox.Show($"¿Estás seguro que deseas actualizar estos datos?",
             "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                Data.Entities.Cast cast = applicationDbContext.Casts.Find(Int32.Parse(idTextBox.Text));
                
                if (update)
                {
                    if (shiftwork != null)
                    {
                        DateTime startHour = startHourDateTimePicker.Value, finishHour = finishHourDateTimePicker.Value;
                        TimeSpan startHourTime = new TimeSpan(startHour.Hour, startHour.Minute, startHour.Second);
                        TimeSpan finishHourTime = new TimeSpan(finishHour.Hour, finishHour.Minute, finishHour.Second);
                        shiftwork.Description = descriptionTextBox.Text;
                        shiftwork.StartHour = startHourTime;
                        shiftwork.FinishHour = finishHourTime;
                        shiftwork.IsActive = statusCheck.Checked;
                        var validationErrors = _validator.GetValidationErrors(shiftwork);
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
                            clearData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error al actualizar " + ex);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            generalSearch();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Entities.ShiftWork shiftwork = applicationDbContext.ShiftWorks.Find(Int32.Parse(idTextBox.Text));
                if (shiftwork != null)
                {
                    applicationDbContext.ShiftWorks.Remove(shiftwork);
                    applicationDbContext.SaveChanges();

                }
                MessageBox.Show("Registro eliminado con exito.");
                refreshData();
                clearData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error al eliminar "+ex);
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            _parent.Show();
        }

        private void ManageOptionsAccordingToRole()
        {
            if (LoggedInUserHelper.GetLoggedUser().UserRoleId != UserRoleId.Admin)
            {
                addButton.Visible = false;
                updateButton.Visible = false;
                deleteButton.Visible = false;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var shiftwork = shiftworkQuery.ToList();

            var lines = new List<string>
            {
                "Identificador,Descripcion, Hora ingreso, Hora salida, Esta activo,  Última fecha de actualizacion"
            };

            foreach (var i in shiftwork)
            {
                lines.Add($"{ i.Id }," +
                    $"{ i.Description }," +
                    $"{ i.StartHour }," +
                    $"{ i.FinishHour }," +
                    $"{ i.IsActive }," +
                    $"{ i.LastUpdatedDate }" 
                    );
            }

            FileHelper.ExportToCSV("shiftwork.csv", lines);
        
    }
    }
}
