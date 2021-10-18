using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.UI.General;

namespace VideoClubManagement.UI.Genre
{
    public partial class GenreForm : Form
    {
        public Data.Entities.Genre Genre { get; set; }
        ApplicationDbContext applicatioDbContext = new ApplicationDbContext();
        public GenreForm()
        {
            InitializeComponent();
        }
        private void refreshData()
        {
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
                applicatioDbContext.Genres.Add(new Data.Entities.Genre { Name = nameTextBox.Text, Description = descriptionTextBox.Text });
                applicatioDbContext.SaveChanges();
                MessageBox.Show("El registro se guardo con éxito");
                refreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha occurido un error" + ex.Message);
            }
        }

        private void genreDataGridView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            nameTextBox.Text = genreDataGridView.CurrentRow.Cells[0].Value.ToString();
            descriptionTextBox.Text = genreDataGridView.CurrentRow.Cells[1].Value.ToString();
            idLabel.Text = genreDataGridView.CurrentRow.Cells[4].Value.ToString();
            createdDateLabel.Text = genreDataGridView.CurrentRow.Cells[6].Value.ToString();
            lastUpdateDateLabel.Text = genreDataGridView.CurrentRow.Cells[7].Value.ToString();
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Entities.Genre genre = applicatioDbContext.Genres.Find(Int32.Parse(idLabel.Text));
                if (genre != null)
                {
                    genre.Name = nameTextBox.Text;
                    genre.Description = descriptionTextBox.Text;
                    applicatioDbContext.SaveChanges();
                }
                MessageBox.Show("Registro actualizado con exito.");
                refreshData();
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
                Data.Entities.Genre genre = applicatioDbContext.Genres.Find(Int32.Parse(idLabel.Text));
                if (genre != null)
                {
                    applicatioDbContext.Genres.Remove(genre);
                    applicatioDbContext.SaveChanges();
                }
                MessageBox.Show("Registro eliminado con exito.");
                refreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar " + ex);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            new MenuForm().Show();
        }
    }
}
