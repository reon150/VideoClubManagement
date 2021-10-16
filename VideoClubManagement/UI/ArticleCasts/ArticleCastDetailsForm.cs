using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VideoClubManagement.Data;

namespace VideoClubManagement.UI.ArticleCasts
{
    public partial class ArticleCastDetailsForm : Form
    {
        private readonly Form _parent;
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private bool _backToList = false;

        public ArticleCastDetailsForm(Form parent, int articleId)
        {
            InitializeComponent();
            _parent = parent;
            FillArticleData(articleId);
        }

        private void FillArticleData(int articleId)
        {
            var articleCast = _applicationDbContext.ArticleCasts.Where(c => c.Id == articleId)
                .Include(ac => ac.Article).Include(ac => ac.Article.ArticleType).Include(ac => ac.Cast).Include(ac => ac.Role)
                .FirstOrDefault();

            idValueLabel.Text = articleCast.Id.ToString();
            articleTypeValueLabel.Text = articleCast.Article.ArticleType.Name;
            articleValueLabel.Text = articleCast.Article.Title;
            isActiveCheckBox.CheckState = articleCast.IsActive ? CheckState.Checked : CheckState.Unchecked;
            personValueLabel.Text = $"{ articleCast.Cast.FirstName } { articleCast.Cast.LastName }";
            createdDateValueLabel.Text = articleCast.CreatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            lastUpdatedValueDateLabel.Text = articleCast.LastUpdatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
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
