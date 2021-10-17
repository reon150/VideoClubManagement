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

namespace VideoClubManagement.UI.Article
{
    public partial class MantenimientoArticulo : Form
    {
        public Data.Entities.Article Article { get; set; }
        ApplicationDbContext applicatioDbContext = new ApplicationDbContext();
        public MantenimientoArticulo()
        {
            InitializeComponent();
        }

        private void MantenimientoArticulo_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
