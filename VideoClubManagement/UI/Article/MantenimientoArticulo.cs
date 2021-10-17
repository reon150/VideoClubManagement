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
    public partial class MantenimientoArticulo : Form
    {
        public Data.Entities.Article Article { get; set; }
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        public MantenimientoArticulo()
        {
            InitializeComponent();
        }

        private void MantenimientoArticulo_Load(object sender, EventArgs e)
        {
            genreTxt.DataSource = applicationDbContext.Genres.ToList();
            genreTxt.DisplayMember = "Description";
            genreTxt.ValueMember = "Id";

            languageTxt.DataSource = applicationDbContext.Languages.ToList();
            languageTxt.DisplayMember = "Description";
            languageTxt.ValueMember = "Id";

            typeTxt.DataSource = applicationDbContext.ArticleTypes.ToList();
            typeTxt.DisplayMember = "Name";
            typeTxt.ValueMember = "Id";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //applicationDbContext.Articles.Add(new Data.Entities.Article
                //{
                //    Title = titleTxt.Text,
                //    RentPerDay = decimal.Parse(rentPerDayTxt.Text),
                //    LateReturnFee = decimal.Parse(lateReturnFeeTxt.Text),
                //    RentalDays = 10,
                //    ArticleTypeId = int.Parse(typeTxt.SelectedValue.ToString()),
                //    LanguageId = int.Parse(languageTxt.SelectedValue.ToString())
                //});
                applicationDbContext.SaveChanges();
                MessageBox.Show("El registro se guardo con exito");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            new MenuForm().Show();
        }
    }
}
