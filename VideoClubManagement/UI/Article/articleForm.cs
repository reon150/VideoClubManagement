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

namespace VideoClubManagement.UI.Article
{
    public partial class articleForm : Form
    {
        public Data.Entities.Article Article { get; set; }
        ApplicationDbContext applicatioDbContext = new ApplicationDbContext();
        public articleForm()
        {
            InitializeComponent();
        }

        private void refreshData()
        {
            articleDataGridView.DataSource = applicatioDbContext.Articles.ToList();
        }

        private void generalSearch()
        {
            var Articles = from sh in applicatioDbContext.Articles
                           where (sh.Title.ToString().StartsWith(searchTxt.Text))
                           select sh;
            articleDataGridView.DataSource = Articles.ToList();
            articleDataGridView.Refresh();
        }

        private void articleForm_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            generalSearch();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new MantenimientoArticulo().Show();
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            new MenuForm().Show();
        }
    }
}
