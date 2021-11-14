using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Genre
{
    public partial class GenreForm : Form
    {
        public Data.Entities.Genre Genre { get; set; }
        ApplicationDbContext applicatioDbContext = new ApplicationDbContext();
        private readonly Form _parent;
        private IValidator<Data.Entities.Genre> _validator;
        public GenreForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _validator = new GenreValidator(applicatioDbContext.Genres);
        }
        private void refreshData()
        {
            genreDataGridView.AutoGenerateColumns = false;
            genreDataGridView.DataSource = applicatioDbContext.Genres.ToList();
        }

        private void generalSearch()
        {
            var Genres = from sh in applicatioDbContext.Genres
                         where (sh.Name.ToString().StartsWith(searchTextBox.Text)
                         || sh.Description.ToString().StartsWith(searchTextBox.Text))
                         select sh;
            genreDataGridView.DataSource = Genres.ToList();
            genreDataGridView.Refresh();
        }

        private void genreForm_Load(object sender, EventArgs e)
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
                    Data.Entities.Genre genre = new Data.Entities.Genre
                    {
                        Name = nameTextBox.Text,
                        Description = descriptionTextBox.Text,
                        IsActive = statusCheckbox.Checked
                    };

                    var validationErrors = _validator.GetValidationErrors(genre);

                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        string errors = "";
                        foreach (var validationError in validationErrors)
                            errors += $"{ validationError }{ Environment.NewLine }";

                        MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        applicatioDbContext.Genres.Add(genre);
                        applicatioDbContext.SaveChanges();
                        MessageBox.Show("El registro se guardo con éxito");
                        refreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha occurido un error" + ex.Message);
            }
        }

        private void genreDataGridView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            nameTextBox.Text = genreDataGridView.CurrentRow.Cells[1].Value.ToString();
            descriptionTextBox.Text = genreDataGridView.CurrentRow.Cells[2].Value.ToString();
            idLabel.Text = genreDataGridView.CurrentRow.Cells[0].Value.ToString();
            createdDateLabel.Text = genreDataGridView.CurrentRow.Cells[4].Value.ToString();
            lastUpdateDateLabel.Text = genreDataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var update = MessageBox.Show($"Estás seguro que deseas guardar estos datos?",
                "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;


                if (update)
                {
                    Data.Entities.Genre genre = applicatioDbContext.Genres.Find(Int32.Parse(idLabel.Text));

                    genre.Name = nameTextBox.Text;
                    genre.Description = descriptionTextBox.Text;
                    genre.IsActive = statusCheckbox.Checked;

                    if (genre != null)
                    {
                        var validationErrors = _validator.GetValidationErrors(genre);
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
                    Data.Entities.Genre genre = applicatioDbContext.Genres.Find(Int32.Parse(idLabel.Text));

                    if (genre != null)
                    {
                        applicatioDbContext.Genres.Remove(genre);
                        applicatioDbContext.SaveChanges();
                        MessageBox.Show("Registro eliminado con exito.");
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
    }
}
