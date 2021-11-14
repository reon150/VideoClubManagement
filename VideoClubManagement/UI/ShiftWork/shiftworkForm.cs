using System;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.UI.General;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Shiftwork
{
    public partial class shiftworkForm : Form
    {
        public Data.Entities.ShiftWork Shiftworks { get; set; }
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        private IValidator<Data.Entities.ShiftWork> _validator;

        private readonly Form _parent;

        public shiftworkForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _validator = new ShiftworkValidator(applicationDbContext.ShiftWorks);

        }

        private void employeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastnameLabel_Click(object sender, EventArgs e)
        {

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
                        FinishHour = finishHourTime };
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
        }
        private void shiftworkForm_Load(object sender, EventArgs e)
        {

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
        }
        private void generalSearch()
        {
            var Shiftworks = from sh in applicationDbContext.ShiftWorks
                              where (sh.Description.ToString().StartsWith(searchTextBox.Text)
                                                                        ||sh.StartHour.ToString().StartsWith(searchTextBox.Text)
                                                                        ||sh.FinishHour.ToString().StartsWith(searchTextBox.Text))
                                                                        select sh;
            shiftworkDataGridView.DataSource = Shiftworks.ToList();
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
    }
}
