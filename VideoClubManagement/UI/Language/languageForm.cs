using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Helpers;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Language
{
    public partial class languageForm : Form
    {
        public Data.Entities.Language Languages { get; set; }
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        private IValidator<Data.Entities.Language> _validator;
        private IQueryable<Data.Entities.Language> languageQuery;
        private readonly Form _parent;

        public languageForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _validator = new LanguageValidator(applicationDbContext.Languages);

        }
        private void refreshData()
        {
            languageDataGridView.DataSource = applicationDbContext.Languages.ToList();
            languageDataGridView.Columns[0].HeaderText = "Codigo idioma";
            languageDataGridView.Columns[1].HeaderText = "Descripcion";
            languageDataGridView.Columns[2].HeaderText = "Identificador";
            languageDataGridView.Columns[3].HeaderText = "Esta activo";
            languageDataGridView.Columns[4].HeaderText = "Fecha creacion";
            languageDataGridView.Columns[5].HeaderText = "Ultima fecha actualizacion";
        }
        private void clear()
        {
            nameTextBox.Clear();
            langCodeTextBox.Clear();
            idTextBox.Clear();
            statusCheck.Checked = false;
        }

        private void generalSearch() {
            languageQuery = from sh in applicationDbContext.Languages
                             where (sh.Description.ToString().StartsWith(searchTextBox.Text)
                                 || sh.ISOCode.ToString().StartsWith(searchTextBox.Text))
                             select sh;
           languageDataGridView.DataSource = languageQuery.ToList();
           languageDataGridView.Refresh();
        }

        private void languageForm_Load(object sender, EventArgs e)
        {
            clear();
            refreshData();
            languageQuery = applicationDbContext.Languages;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            generalSearch();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var save = MessageBox.Show($"¿Estás seguro que deseas guardar estos datos?",
               "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                if (save)
                {
                    Data.Entities.Language language = new Data.Entities.Language
                    {
                        Description = nameTextBox.Text,
                        ISOCode = langCodeTextBox.Text.ToUpper(),
                        IsActive = statusCheck.Checked
                    };
                    
                    var validationErrors = _validator.GetValidationErrors(language);
                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        string errors = "";
                        foreach (var validationError in validationErrors)
                            errors += $"{ validationError }{ Environment.NewLine }";

                        MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        applicationDbContext.Languages.Add(language);
                        applicationDbContext.SaveChanges();
                        MessageBox.Show("El registro se guardo con exito");
                        refreshData();
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }

        }

        private void languageDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clear();
            nameTextBox.Text = languageDataGridView.CurrentRow.Cells[1].Value.ToString();
            langCodeTextBox.Text = languageDataGridView.CurrentRow.Cells[0].Value.ToString().Replace(" ", String.Empty);
            idTextBox.Text = languageDataGridView.CurrentRow.Cells[2].Value.ToString();
            statusCheck.Checked = (bool)languageDataGridView.CurrentRow.Cells[3].Value;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var update = MessageBox.Show($"¿Estás seguro que deseas actualizar estos datos?",
              "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                if (update)
                {    
                    Data.Entities.Language language = applicationDbContext.Languages.Find(Int32.Parse(idTextBox.Text));
                    String newLang = langCodeTextBox.Text.ToUpper();
                    language.Description = nameTextBox.Text;
                    language.ISOCode = newLang;
                    language.IsActive = statusCheck.Checked;
                    if (language != null)
                    {
                        var validationErrors = _validator.GetValidationErrors(language);
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
                            clear();
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
                Data.Entities.Language language = applicationDbContext.Languages.Find(Int32.Parse(idTextBox.Text));
                if (language != null)
                {
                    applicationDbContext.Languages.Remove(language);
                    applicationDbContext.SaveChanges();
                }
                MessageBox.Show("Registro eliminado con exito.");
                refreshData();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar " + ex);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            _parent.Show();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var language = languageQuery.ToList();

            var lines = new List<string>
            {
                "Identificador, Codigo idioma,Descripcion, Esta activo,  Última fecha de actualizacion"
            };

            foreach (var i in language)
            {
                lines.Add($"{ i.Id }," +
                    $"{ i.ISOCode }," +
                    $"{ i.Description }," +
                    $"{ i.IsActive }," +
                    $"{ i.LastUpdatedDate }"
                    );
            }

            FileHelper.ExportToCSV("language.csv", lines);
        }
    }
}
