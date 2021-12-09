using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;
using VideoClubManagement.Helpers;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Cast
{
    public partial class castForm : Form
    {
        public Data.Entities.Cast Casts { get; set; }
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        private readonly Form _parent;
        private IValidator<Data.Entities.Cast> _validator;
        private IQueryable<Data.Entities.Cast> castQuery;
        public castForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _validator = new CastValidator(applicationDbContext.Casts);

        }
        private void refreshData()
        {
           castDataGridView.DataSource = applicationDbContext.Casts.ToList();
            castDataGridView.Columns[0].HeaderText = "Nombre";
            castDataGridView.Columns[1].HeaderText = "Apellido";
            castDataGridView.Columns[2].HeaderText = "Identificador";
            castDataGridView.Columns[3].HeaderText = "Es Activo";
            castDataGridView.Columns[4].HeaderText = "Fecha creacion";
            castDataGridView.Columns[5].HeaderText = "Fecha ultima actualizacion";


        }

        private void clearData()
        {
            nameTextBox.Clear();
            lastnameTextBox.Clear();
            idTextBox.Clear();
            statusCheck.Checked = false;
        }
        private void generalSearch()
        {
            castQuery = from sh in applicationDbContext.Casts
                            where (sh.FirstName.ToString().StartsWith(searchTextBox.Text)
                                || sh.LastName.ToString().StartsWith(searchTextBox.Text))
                            select sh;
            castDataGridView.DataSource = castQuery.ToList();
            castDataGridView.Refresh();



        }


        private void castForm_Load(object sender, EventArgs e)
        {
            refreshData();
            castQuery = applicationDbContext.Casts;

        }
        private void castDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var save = MessageBox.Show($"¿Estás seguro que deseas guardar estos datos?",
               "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                if (save)
                {
                    Data.Entities.Cast cast = new Data.Entities.Cast
                    {
                        FirstName = nameTextBox.Text,
                        LastName = lastnameTextBox.Text,
                        IsActive = statusCheck.Checked,
                        LastUpdatedDate = DateTime.Now
                    };
                    var validationErrors = _validator.GetValidationErrors(cast);
                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        string errors = "";
                        foreach (var validationError in validationErrors)
                            errors += $"{ validationError }{ Environment.NewLine }";

                        MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        applicationDbContext.Casts.Add(cast);
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
                Data.Entities.Cast cast = applicationDbContext.Casts.Find(Int32.Parse(idTextBox.Text));
                cast.FirstName = nameTextBox.Text;
                cast.LastName = lastnameTextBox.Text;
                cast.IsActive = statusCheck.Checked;

                if (update)
                {
                    if (cast != null)
                    {
                        var validationErrors = _validator.GetValidationErrors(cast);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Entities.Cast cast = applicationDbContext.Casts.Find(Int32.Parse(idTextBox.Text));
                if (cast != null)
                {
                    applicationDbContext.Casts.Remove(cast);
                    applicationDbContext.SaveChanges();
                    
                }
                MessageBox.Show("Registro eliminado con exito.");
                refreshData();
                clearData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error al eliminar " + ex);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            generalSearch();
        }

        private void castDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nameTextBox.Text = castDataGridView.CurrentRow.Cells[0].Value.ToString();
            lastnameTextBox.Text = castDataGridView.CurrentRow.Cells[1].Value.ToString();
            idTextBox.Text = castDataGridView.CurrentRow.Cells[2].Value.ToString();
            statusCheck.Checked = (bool)castDataGridView.CurrentRow.Cells[3].Value;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            _parent.Show();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var cast = castQuery.ToList();

            var lines = new List<string>
            {
                "Identificador,Nombre,Última fecha de actualización,Esta Activo"
            };

            foreach (var i in cast)
            {
                lines.Add($"{ i.Id }," +
                    $"{ i.FirstName } { i.LastName }," +
                    $"{ i.LastUpdatedDate }," +
                    $"{ i.IsActive } ");
            }

            FileHelper.ExportToCSV("Elencos.csv", lines);
        }
    }
    
}
