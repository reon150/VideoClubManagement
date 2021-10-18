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

namespace VideoClubManagement.UI.ArticleType
{
    public partial class ArticleTypeForm : Form
    {
        public Data.Entities.ArticleType articleType { get; set; }
        ApplicationDbContext applicatioDbContext = new ApplicationDbContext();

        public ArticleTypeForm()
        {
            InitializeComponent();
            refreshData();
        }

        private void refreshData()
        {
            articleTypeDataGridView.DataSource = applicatioDbContext.ArticleTypes.ToList();
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
                applicatioDbContext.ArticleTypes.Add(new Data.Entities.ArticleType { Name = nameTextBox.Text, Description = descriptionTextBox.Text });
                applicatioDbContext.SaveChanges();
                MessageBox.Show("El registro se guardo con éxito");
                refreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha occurido un error" + ex.Message);
            }
        }

        private void articleTypeDataGridView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            nameTextBox.Text = articleTypeDataGridView.CurrentRow.Cells[0].Value.ToString();
            descriptionTextBox.Text = articleTypeDataGridView.CurrentRow.Cells[1].Value.ToString();
            idLabel.Text = articleTypeDataGridView.CurrentRow.Cells[2].Value.ToString();
            createdDateLabel.Text = articleTypeDataGridView.CurrentRow.Cells[4].Value.ToString();
            lastUpdateDateLabel.Text = articleTypeDataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Entities.ArticleType articleType= applicatioDbContext.ArticleTypes.Find(Int32.Parse(idLabel.Text));
                if (articleType != null)
                {
                    articleType.Name = nameTextBox.Text;
                    articleType.Description = descriptionTextBox.Text;
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
                Data.Entities.ArticleType articleType = applicatioDbContext.ArticleTypes.Find(Int32.Parse(idLabel.Text));
                if (articleType != null)
                {
                    applicatioDbContext.ArticleTypes.Remove(articleType);
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
