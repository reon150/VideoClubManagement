using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Language
{
    public partial class languageForm : Form
    {
        public Data.Entities.Language Languages { get; set; }
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        private IValidator<Data.Entities.Language> _validator;
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
        }
        private void clear()
        {
            nameTextBox.Clear();
            langCodeTextBox.Clear();
            idTextBox.Clear();
        }
        private void generalSearch() {
            var Languages = from sh in applicationDbContext.Languages
                             where (sh.Description.ToString().StartsWith(searchTextBox.Text)
                                 || sh.ISOCode.ToString().StartsWith(searchTextBox.Text))
                             select sh;
           languageDataGridView.DataSource = Languages.ToList();
           languageDataGridView.Refresh();
        }
        private void languageForm_Load(object sender, EventArgs e)
        {
            clear();
            refreshData();
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
                        ISOCode = langCodeTextBox.Text.ToUpper()
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
            langCodeTextBox.Text = languageDataGridView.CurrentRow.Cells[0].Value.ToString();
            idTextBox.Text = languageDataGridView.CurrentRow.Cells[2].Value.ToString();
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
                var delete = MessageBox.Show($"¿Estás seguro que deseas eliminar estos datos?",
                    "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                if (delete)
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
    }
}
