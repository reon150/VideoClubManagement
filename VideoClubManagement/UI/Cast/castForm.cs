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

namespace VideoClubManagement.UI.Cast
{
    public partial class castForm : Form
    {
        public Data.Entities.Cast Casts { get; set; }
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        public castForm()
        {
            InitializeComponent();
        }
        private void refreshData()
        {
           castDataGridView.DataSource = applicationDbContext.Casts.ToList();
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

                applicationDbContext.Casts.Add(new Data.Entities.Cast { FirstName = nameTextBox.Text, LastName = lastnameTextBox.Text });
                applicationDbContext.SaveChanges();
                MessageBox.Show("El registro se guardo con exito");
                refreshData();

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
                Data.Entities.Cast cast = applicationDbContext.Casts.Find(Int32.Parse(idTextBox.Text));
                if (cast != null)
                {

                    cast.FirstName = nameTextBox.Text;
                    cast.LastName = lastnameTextBox.Text;


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
                Data.Entities.Cast cast = applicationDbContext.Casts.Find(Int32.Parse(idTextBox.Text));
                if (cast != null)
                {
                    applicationDbContext.Casts.Remove(cast);
                    applicationDbContext.SaveChanges();

                }
                MessageBox.Show("Registro eliminado con exito.");
                refreshData();
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
    }
    
}
