using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClubManagement.UI.ArticleCasts;
using VideoClubManagement.UI.ArticleLendings;
using VideoClubManagement.UI.Clients;

namespace VideoClubManagement.UI.General
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void articleCastButton_Click(object sender, EventArgs e)
        {
            Hide();
            new ArticleCastIndexForm(this).Show();
        }

        private void articleLendingButton_Click(object sender, EventArgs e)
        {
            Hide();
            new ArticleLendingIndexForm(this).Show();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            Hide();
            new ClientIndexForm(this).Show();
        }
    }
}
