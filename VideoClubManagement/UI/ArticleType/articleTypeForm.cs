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
    public partial class articleTypeForm : Form
    {
        public Data.Entities.ArticleType articleType { get; set; }
        ApplicationDbContext applicatioDbContext = new ApplicationDbContext();

        public articleTypeForm()
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
                               where (sh.Name.ToString().StartsWith(searchTxt.Text)
                               || sh.Description.ToString().StartsWith(searchTxt.Text))
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
                applicatioDbContext.ArticleTypes.Add(new Data.Entities.ArticleType { Name = nameTxt.Text, Description = descriptionTxt.Text });
                applicatioDbContext.SaveChanges();
                MessageBox.Show("El registro se guardo con éxito");
                refreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha occurido un error" + ex.Message);
            }
        }

        private void articleTypeDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nameTxt.Text = articleTypeDataGridView.CurrentRow.Cells[1].Value.ToString();
            descriptionTxt.Text = articleTypeDataGridView.CurrentRow.Cells[0].Value.ToString();
            idLabel.Text = articleTypeDataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Entities.ArticleType articleType= applicatioDbContext.ArticleTypes.Find(Int32.Parse(idLabel.Text));
                if (articleType != null)
                {
                    articleType.Name = nameTxt.Text;
                    articleType.Description = descriptionTxt.Text;
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
                Data.Entities.ArticleType articleType = applicatioDbContext.ArticleTypes.Find(Int32.Parse(idLabel.Text));
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
