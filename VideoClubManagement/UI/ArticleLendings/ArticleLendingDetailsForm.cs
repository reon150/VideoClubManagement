using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClubManagement.Data;

namespace VideoClubManagement.UI.ArticleLendings
{
    public partial class ArticleLendingDetailsForm : Form
    {
        private readonly Form _parent;
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private bool _backToList = false;

        public ArticleLendingDetailsForm(Form parent, int id)
        {
            InitializeComponent();
            _parent = parent;
            FillData(id);
        }

        public void FillData(int id)
        {
            var articleLending = _applicationDbContext.ArticleLendings.Where(c => c.Id == id)
                .Include(ac => ac.Article).Include(ac => ac.Employee).Include(ac => ac.Client)
                .FirstOrDefault();

            idValueLabel.Text = articleLending.Id.ToString();
            isActiveCheckBox.CheckState = articleLending.IsActive ? CheckState.Checked : CheckState.Unchecked;
            employeeValueLabel.Text = $"{ articleLending.Employee.FirstName } { articleLending.Employee.LastName }";
            clientValueLabel.Text = $"{ articleLending.Client.FirstName } { articleLending.Client.LastName }";
            articleValueLabel.Text = articleLending.Article.Title;
            commentValueLabel.Text = articleLending.Comment;
            amountPerDayValueLabel.Text = articleLending.AmountPerDay.ToString("0.##");
            createdDateValueLabel.Text = articleLending.CreatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            dueDateValueLabel.Text = articleLending.DueDate.ToString("dd/MM/yyyy");
            returnDateValueLabel.Text = articleLending.ReturnDate?.ToString("dd/MM/yyyy");
            lastUpdatedValueDateLabel.Text = articleLending.LastUpdatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            if(articleLending.ReturnDate == null && DateTime.Now.Date > articleLending.DueDate.Date)
                statusValueLabel.Text = "Atrasado";
            else if (articleLending.ReturnDate == null)
                statusValueLabel.Text = "Pendiente";
            else
                statusValueLabel.Text = "Devuelto";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (_backToList)
                _parent.Show();
            else
                _parent.Close();
        }

        private void backToListButton_Click(object sender, EventArgs e)
        {
            _backToList = true;
            Close();
        }
    }
}
