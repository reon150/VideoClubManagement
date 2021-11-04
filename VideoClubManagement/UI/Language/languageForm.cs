using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;

namespace VideoClubManagement.UI.Language
{
    public partial class languageForm : Form
    {
        public Data.Entities.Language Languages { get; set; }
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        private readonly Form _parent;

        public languageForm(Form parent)
        {
            InitializeComponent();
            _parent = parent;
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
                applicationDbContext.Languages.Add (new Data.Entities.Language { ISOCode = langCodeTextBox.Text,Description = nameTextBox.Text });
                applicationDbContext.SaveChanges();
                MessageBox.Show("El registro se guardo con exito");
                refreshData();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }

        }

        private void languageDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nameTextBox.Text = languageDataGridView.CurrentRow.Cells[1].Value.ToString();
            langCodeTextBox.Text = languageDataGridView.CurrentRow.Cells[0].Value.ToString();
            idTextBox.Text = languageDataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Entities.Language language = applicationDbContext.Languages.Find(Int32.Parse(idTextBox.Text));
                if (language != null)
                {
                    language.Description = nameTextBox.Text;
                    language.ISOCode = langCodeTextBox.Text;
                }
                MessageBox.Show("Registro actualizado con exito.");
                refreshData();
                clear();
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
    }
}
