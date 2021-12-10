using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Helpers;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.ArticleType
{
    public partial class ArticleTypeForm : Form
    {
        public Data.Entities.ArticleType articleType { get; set; }
        ApplicationDbContext applicatioDbContext = new ApplicationDbContext();
        private readonly Form _parent;
        private IValidator<Data.Entities.ArticleType> _validator;
        private IQueryable<Data.Entities.ArticleType> _articleTypesQuery;

        public ArticleTypeForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _validator = new ArticleTypeValidator(applicatioDbContext.ArticleTypes);
            _articleTypesQuery = applicatioDbContext.ArticleTypes.AsQueryable();
            refreshData();
        }

        private void refreshData()
        {
            articleTypeDataGridView.AutoGenerateColumns = false;
            articleTypeDataGridView.DataSource = applicatioDbContext.ArticleTypes.ToList();
        }

        private void clearData()
        {
            idLabel.Text = "";
            lastUpdateDateLabel.Text = "";
            createdDateLabel.Text = "";
            nameTextBox.Clear();
            descriptionTextBox.Clear();
        }
        private void generalSearch()
        {
            var ArticleTypes = from sh in applicatioDbContext.ArticleTypes
                               where (sh.Name.ToString().StartsWith(searchTextBox.Text)
                               || sh.Description.ToString().StartsWith(searchTextBox.Text))
                               select sh;
            articleTypeDataGridView.DataSource = ArticleTypes.ToList();
            articleTypeDataGridView.Refresh();
        }

        private void articleTypeForm_Load(object sender, EventArgs e)
        {
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
                var save = MessageBox.Show($"Estás seguro que deseas guardar estos datos?",
                "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                if (save)
                {
                    Data.Entities.ArticleType articleType = new Data.Entities.ArticleType
                    {
                        Name = nameTextBox.Text,
                        Description = descriptionTextBox.Text,
                        IsActive = statusCheckBox.Checked
                    };

                    var validationErrors = _validator.GetValidationErrors(articleType);

                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        string errors = "";
                        foreach (var validationError in validationErrors)
                            errors += $"{ validationError }{ Environment.NewLine }";

                        MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        applicatioDbContext.ArticleTypes.Add(articleType);
                        applicatioDbContext.SaveChanges();
                        MessageBox.Show("El registro se guardo con éxito");
                        clearData();
                        refreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha occurido un error" + ex.Message);
            }
        }

        private void articleTypeDataGridView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            nameTextBox.Text = articleTypeDataGridView.CurrentRow.Cells[1].Value.ToString();
            descriptionTextBox.Text = articleTypeDataGridView.CurrentRow.Cells[2].Value.ToString();
            idLabel.Text = articleTypeDataGridView.CurrentRow.Cells[0].Value.ToString();
            createdDateLabel.Text = articleTypeDataGridView.CurrentRow.Cells[4].Value.ToString();
            lastUpdateDateLabel.Text = articleTypeDataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var update = MessageBox.Show($"Estás seguro que deseas guardar estos datos?",
                "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;


                if (update)
                {
                    Data.Entities.ArticleType articleType = applicatioDbContext.ArticleTypes.Find(Int32.Parse(idLabel.Text));
                    articleType.Name = nameTextBox.Text;
                    articleType.Description = descriptionTextBox.Text;
                    articleType.IsActive = statusCheckBox.Checked;

                    if (articleType != null)
                    {
                        var validationErrors = _validator.GetValidationErrors(articleType);

                        if (validationErrors != null && validationErrors.Count > 0)
                        {
                            string errors = "";
                            foreach (var validationError in validationErrors)
                                errors += $"{ validationError }{ Environment.NewLine }";

                            MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Registro actualizado con exito.");
                            applicatioDbContext.SaveChanges();
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
                    Data.Entities.ArticleType articleType = applicatioDbContext.ArticleTypes.Find(Int32.Parse(idLabel.Text));

                    if (articleType != null)
                    {
                        applicatioDbContext.ArticleTypes.Remove(articleType);
                        applicatioDbContext.SaveChanges();
                        MessageBox.Show("Registro eliminado con exito.");
                        clearData();
                        refreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar " + ex);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            _parent.Show();
        }

        private void exportToCVSButton_Click(object sender, EventArgs e)
        {
            var articletypes = _articleTypesQuery.ToList();

            var lines = new List<string>
            {
                "Identificador, Nombre, Descripción, Fecha de creación, Ultima fecha de modificación, Esta Activo"
            };

            foreach (var articletype in articletypes)
            {
                lines.Add($"{articletype.Id}," +
                    $"{articletype.Name},"+
                    $"{articletype.Description}," +
                    $"{articletype.CreatedDate}," +
                    $"{articletype.LastUpdatedDate}," +
                    $"{ BoolHelper.BoolToYesNoString(articletype.IsActive) }");
            }

            FileHelper.ExportToCSV("Tipos de articulos.csv", lines);
        }
    }
}
