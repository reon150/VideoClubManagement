using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using VideoClubManagement.Data;

namespace VideoClubManagement.UI.ArticleCasts
{
    public partial class ArticleCastEditForm : Form
    {
        private readonly Form _parent;
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private System.Timers.Timer _timer = new System.Timers.Timer(1000);
        private bool _backToList = false;
        private bool _changesSaved = false;

        public ArticleCastEditForm(Form paren, int articleCastId)
        {
            InitializeComponent();
            _parent = paren;
            _timer.Elapsed += UpdateCurrentDateTimeLabel;
            FillData(articleCastId);

            _timer.Start();
        }

        private void UpdateCurrentDateTimeLabel(object sender, ElapsedEventArgs e) =>
            currentDateTimeLabel.Invoke((Action)delegate
            {
                currentDateTimeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            });

        private void SetComboBoxes(int currentCastId, int currentRoleId, int currentArticleId)
        {
            SetCastComboBox(currentCastId);
            SetRoleComboBox(currentRoleId);
            SetArticleComboBox(currentArticleId);
        }

        private void SetCastComboBox(int currentId)
        {
            var casts = _applicationDbContext.Casts.AsEnumerable();
            castComboBox.DisplayMember = "Name";
            castComboBox.ValueMember = "Id";
            foreach (var cast in casts)
            {
                var item = new { Id = cast.Id, Name = $"{ cast.FirstName } { cast.LastName }" };
                castComboBox.Items.Add(item);
                if (cast.Id == currentId)
                    castComboBox.SelectedItem = item;
            }
        }

        private void SetRoleComboBox(int currentId)
        {
            var roles = _applicationDbContext.Roles.AsEnumerable();
            roleComboBox.DisplayMember = "Name";
            roleComboBox.ValueMember = "Id";

            foreach (var role in roles)
            {
                var item = new { Id = role.Id, Name = $"{ role.Name }" };
                roleComboBox.Items.Add(item);
                if (role.Id == currentId)
                    roleComboBox.SelectedItem = item;
            }
        }

        private void SetArticleComboBox(int currentId)
        {
            var articles = _applicationDbContext.Articles.AsEnumerable();
            articleComboBox.DisplayMember = "Name";
            articleComboBox.ValueMember = "Id";
            foreach (var article in articles)
            {
                var item = new { Id = article.Id, Name = $"{ article.Title }" };
                articleComboBox.Items.Add(item);
                if (article.Id == currentId)
                    articleComboBox.SelectedItem = item;
            }      
        }

        public void FillData(int id)
        {
            var articleCast = _applicationDbContext.ArticleCasts.Where(c => c.Id == id)
                .Include(ac => ac.Article).Include(ac => ac.Article.ArticleType).Include(ac => ac.Cast).Include(ac => ac.Role)
                .FirstOrDefault();

            SetComboBoxes(articleCast.CastId, articleCast.RoleId, articleCast.ArticleId);

            idValueLabel.Text = articleCast.Id.ToString();
            createdDateValueLabel.Text = articleCast.CreatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            lastUpdatedValueDateLabel.Text = articleCast.LastUpdatedDate.ToString("dd/MM/yyyy hh:mm:ss tt");
            isActiveCheckBox.Checked = articleCast.IsActive;
        }

        private void editArticleCastButton_Click(object sender, EventArgs e)
        {
            var castComboBoxSelectedItem = castComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(castComboBox.SelectedItem, null);
            var roleComboBoxSelectedItem = roleComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(roleComboBox.SelectedItem, null);
            var articleComboBoxSelectedItem = articleComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(articleComboBox.SelectedItem, null);

            var id = int.Parse(idValueLabel.Text);
            var articleCast = _applicationDbContext.ArticleCasts.Where(c => c.Id == id).FirstOrDefault();
            articleCast.CastId = int.Parse(castComboBoxSelectedItem.ToString());
            articleCast.RoleId = int.Parse(roleComboBoxSelectedItem.ToString());
            articleCast.ArticleId = int.Parse(articleComboBoxSelectedItem.ToString());
            articleCast.IsActive = isActiveCheckBox.Checked;

            _applicationDbContext.SaveChanges();

            _changesSaved = true;
            _backToList = true;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            bool close = true;

            if (!_changesSaved)
            {
                close = MessageBox.Show($"¿Estás seguro que deseas volver atrás? Las modificaciones no guardadas se perderán",
                "Adventencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
            }

            if (close)
            {
                if (_backToList)
                {
                    _timer.Close();
                    _parent.Show();
                }
                else
                {
                    _parent.Close();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void backToListButton_Click(object sender, EventArgs e)
        {
            _backToList = true;
            Close();
        }
    }
}
