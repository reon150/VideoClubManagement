using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Validations;

namespace VideoClubManagement.UI.Cast
{
    public partial class castForm : Form
    {
        public Data.Entities.Cast Casts { get; set; }
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        private readonly Form _parent;
        private IValidator<Data.Entities.Cast> _validator;
        public castForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            _validator = new CastValidator(applicationDbContext.Casts);
        }
        private void refreshData()
        {
            castDataGridView.DataSource = applicationDbContext.Casts.ToList();
        }
        private void clearData()
        {
            nameTextBox.Clear();
            lastnameTextBox.Clear();
            idTextBox.Clear();
        }
        private void generalSearch()
        {
            var Casts = from sh in applicationDbContext.Casts
                        where (sh.FirstName.ToString().StartsWith(searchTextBox.Text)
                            || sh.LastName.ToString().StartsWith(searchTextBox.Text))
                        select sh;
            castDataGridView.DataSource = Casts.ToList();
            castDataGridView.Refresh();
        }
        private void castForm_Load(object sender, EventArgs e)
        {
            refreshData();
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
                        LastName = lastnameTextBox.Text
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
                var delete = MessageBox.Show($"¿Estás seguro que deseas eliminar estos datos?",
                    "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
                if (delete)
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
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            _parent.Show();
        }
    }

}
