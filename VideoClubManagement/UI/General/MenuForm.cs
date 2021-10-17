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
using VideoClubManagement.UI.Cast;
using VideoClubManagement.UI.Language;
using VideoClubManagement.UI.Employee;
using VideoClubManagement.UI.Shiftwork;

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

        private void languageButton_Click(object sender, EventArgs e)
        {
            Hide();
            new languageForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new castForm().Show();
        }

        private void shiftworkButton_Click(object sender, EventArgs e)
        {
            Hide();
            new shiftworkForm().Show();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            Hide();
            new employeeForm().Show();
        }
    }
}
