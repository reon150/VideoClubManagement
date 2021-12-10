using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Helpers;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Article
{
    public partial class ArticleForm : Form
    {
        public Data.Entities.Article Article { get; set; }
        ApplicationDbContext applicatioDbContext = new ApplicationDbContext();
        private readonly Form _parent;
        private IValidator<Data.Entities.Article> _validator;
        private IQueryable<Data.Entities.Article> _articleQuery;

        public ArticleForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _validator = new ArticleValidator(applicatioDbContext.Articles);
            _articleQuery = applicatioDbContext.Articles.AsQueryable();
            refreshData();

        }

        private void refreshData()
        {
            articleDataGridView.AutoGenerateColumns = false;
            articleDataGridView.DataSource = applicatioDbContext.Articles.ToList();
        }

        private void clearData()
        {
            titleTextBox.Clear();
            rentPerDayTextBox.Clear();
            rentalDaystextBox.Clear();
            lateReturnFeeTextBox.Clear();
            idLabel.Text = "";
            createdDateLabel.Text = "";
            lastUpdateDateLabel.Text = "";
        }

        private void generalSearch()
        {
            var Articles = from sh in applicatioDbContext.Articles
                           where (sh.Title.ToString().StartsWith(searchTextBox.Text))
                           select sh;
            articleDataGridView.DataSource = Articles.ToList();
            articleDataGridView.Refresh();
        }

        private void articleForm_Load(object sender, EventArgs e)
        {
            genreComboBox.DataSource = applicatioDbContext.Genres.ToList();
            genreComboBox.DisplayMember = "Name";
            genreComboBox.ValueMember = "Id";

            langaugeComboBox.DataSource = applicatioDbContext.Languages.ToList();
            langaugeComboBox.DisplayMember = "Description";
            langaugeComboBox.ValueMember = "Id";

            typeComboBox.DataSource = applicatioDbContext.ArticleTypes.ToList();
            typeComboBox.DisplayMember = "Name";
            typeComboBox.ValueMember = "Id";

            refreshData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            generalSearch();
        }

        private void articleDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            titleTextBox.Text = articleDataGridView.CurrentRow.Cells[1].Value.ToString();
            rentPerDayTextBox.Text = articleDataGridView.CurrentRow.Cells[2].Value.ToString();
            rentalDaystextBox.Text = articleDataGridView.CurrentRow.Cells[3].Value.ToString();
            lateReturnFeeTextBox.Text = articleDataGridView.CurrentRow.Cells[4].Value.ToString();
            idLabel.Text = articleDataGridView.CurrentRow.Cells[0].Value.ToString();
            createdDateLabel.Text = articleDataGridView.CurrentRow.Cells[8].Value.ToString();
            lastUpdateDateLabel.Text = articleDataGridView.CurrentRow.Cells[9].Value.ToString();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var save = MessageBox.Show($"Estás seguro que deseas guardar estos datos?",
               "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                if (save)
                {
                    int.TryParse(rentalDaystextBox.Text, out int rentalDays);
                    decimal.TryParse(rentPerDayTextBox.Text, out decimal rentPerDay);
                    decimal.TryParse(lateReturnFeeTextBox.Text, out decimal lateReturnFee);

                    Data.Entities.Article article = new Data.Entities.Article
                    {
                        Title = titleTextBox.Text,
                        RentPerDay = rentPerDay,
                        LateReturnFee = lateReturnFee,
                        IsActive = statusCheckBox.Checked,
                        RentalDays = rentalDays,
                        ArticleTypeId = int.Parse(typeComboBox.SelectedValue.ToString()),
                        LanguageId = int.Parse(langaugeComboBox.SelectedValue.ToString()),
                    };

                    var validationErrors = _validator.GetValidationErrors(article);

                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        string errors = "";
                        foreach (var validationError in validationErrors)
                            errors += $"{ validationError }{ Environment.NewLine }";

                        MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        applicatioDbContext.Articles.Add(article);
                        applicatioDbContext.SaveChanges();
                        MessageBox.Show("El registro se guardo con exito");
                        clearData();
                        refreshData();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            _parent.Show();
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                var update = MessageBox.Show($"Estás seguro que deseas actualizar estos datos?",
               "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;

                if (update)
                {
                    int.TryParse(rentalDaystextBox.Text, out int rentalDays);
                    decimal.TryParse(rentPerDayTextBox.Text, out decimal rentPerDay);
                    decimal.TryParse(lateReturnFeeTextBox.Text, out decimal lateReturnFee);

                    Data.Entities.Article article = applicatioDbContext.Articles.Find(Int32.Parse(idLabel.Text));
                    article.Title = titleTextBox.Text;
                    article.RentPerDay = rentPerDay;
                    article.RentalDays = rentalDays;
                    article.LateReturnFee = lateReturnFee;
                    article.IsActive = statusCheckBox.Checked;

                    if (article != null)
                    {
                        var validationErrors = _validator.GetValidationErrors(article);

                        if (validationErrors != null && validationErrors.Count > 0)
                        {
                            string errors = "";
                            foreach (var validationError in validationErrors)
                                errors += $"{ validationError }{ Environment.NewLine }";

                            MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            applicatioDbContext.SaveChanges();
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
                    Data.Entities.Article article = applicatioDbContext.Articles.Find(Int32.Parse(idLabel.Text));
                    if (article != null)
                    {
                        applicatioDbContext.Articles.Remove(article);
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

        private void exportToCSVButton_Click(object sender, EventArgs e)
        {
            var articles = _articleQuery.ToList();

            var lines = new List<string>
            {
                "Identificador,Título,Renta por día,Días de renta,Penalidad,Tipo de artículo,Idioma,Fecha de creación,Última fecha de actualización,Esta Activo"
            };

            foreach (var article in articles)
            {
                lines.Add($"{ article.Id }," +
                    $"{ article.Title }," +
                    $"{ article.RentPerDay }," +
                    $"{ article.RentalDays}," +
                    $"{ article.LateReturnFee}," +
                    $"{ article.ArticleType.Name}," +
                    $"{ article.Language.Description}," +
                    $"{ article.CreatedDate }," +
                    $"{ article.LastUpdatedDate }," +
                    $"{ BoolHelper.BoolToYesNoString(article.IsActive) }");
            }

            FileHelper.ExportToCSV("Articulos.csv", lines);
        }
    }
    
}
