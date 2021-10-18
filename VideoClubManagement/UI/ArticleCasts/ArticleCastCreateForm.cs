using System;
using System.Data;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using VideoClubManagement.Data;
using VideoClubManagement.Data.Entities;

namespace VideoClubManagement.UI.ArticleCasts
{
    public partial class ArticleCastCreateForm : Form
    {
        private readonly ApplicationDbContext _applicationDbContext = new ApplicationDbContext();
        private System.Timers.Timer _timer = new System.Timers.Timer(1000);
        private readonly Form _parent;
        private bool _backToList = false;
        private bool _changesSaved = false;

        public ArticleCastCreateForm(Form parent)
        {
            _parent = parent;
            InitializeComponent();
            _timer.Elapsed += UpdateCurrentDateTimeLabel;

            SetComboBoxes();

            _timer.Start();
        }

        private void UpdateCurrentDateTimeLabel(object sender, ElapsedEventArgs e) =>
            currentDateTimeLabel.Invoke((Action)delegate
            {
                currentDateTimeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            });

        private void SetComboBoxes()
        {
            SetCastComboBox();
            SetRoleComboBox();
            SetArticleComboBox();
        }

        private void SetCastComboBox()
        {
            var casts = _applicationDbContext.Casts.AsEnumerable();
            castComboBox.DisplayMember = "Name";
            castComboBox.ValueMember = "Id";
            foreach (var cast in casts)
                castComboBox.Items.Add(new { Id = cast.Id, Name = $"{ cast.FirstName } { cast.LastName }" });
            castComboBox.SelectedIndex = 0;
        }

        private void SetRoleComboBox()
        {
            var roles = _applicationDbContext.Roles.AsEnumerable();
            roleComboBox.DisplayMember = "Name";
            roleComboBox.ValueMember = "Id";
            foreach (var role in roles)
                roleComboBox.Items.Add(new { Id = role.Id, Name = $"{ role.Name }" });
            roleComboBox.SelectedIndex = 0;
        }

        private void SetArticleComboBox()
        {
            var articles = _applicationDbContext.Articles.AsEnumerable();
            articleComboBox.DisplayMember = "Name";
            articleComboBox.ValueMember = "Id";
            foreach (var article in articles)
                articleComboBox.Items.Add(new { Id = article.Id, Name = $"{ article.Title }" });
            articleComboBox.SelectedIndex = 0;
        }

        private void createArticleCastButton_Click(object sender, EventArgs e)
        {
            var castComboBoxSelectedItem = castComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(castComboBox.SelectedItem, null);
            var roleComboBoxSelectedItem = roleComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(roleComboBox.SelectedItem, null);
            var articleComboBoxSelectedItem = articleComboBox.SelectedItem.GetType().GetProperty("Id").GetValue(articleComboBox.SelectedItem, null);

            var articleCast = new ArticleCast
            {
                CastId = int.Parse(castComboBoxSelectedItem.ToString()),
                RoleId = int.Parse(roleComboBoxSelectedItem.ToString()),
                ArticleId = int.Parse(articleComboBoxSelectedItem.ToString()),
                IsActive = isActiveCheckBox.Checked
            };
            _applicationDbContext.ArticleCasts.Add(articleCast);
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
                close = MessageBox.Show($"¿Estás seguro que deseas volver atrás? Los datos no guardados se perderán",
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
