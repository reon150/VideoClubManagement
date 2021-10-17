
namespace VideoClubManagement.UI.ArticleCasts
{
    partial class ArticleCastIndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.lastPageTextBox = new System.Windows.Forms.TextBox();
            this.currentPageTextBox = new System.Windows.Forms.TextBox();
            this.onlyShowActivesCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.pagingLabel = new System.Windows.Forms.Label();
            this.firstButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.articleCastsDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.detailsButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.articleCastsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "/";
            // 
            // lastPageTextBox
            // 
            this.lastPageTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lastPageTextBox.Location = new System.Drawing.Point(514, 449);
            this.lastPageTextBox.Multiline = true;
            this.lastPageTextBox.Name = "lastPageTextBox";
            this.lastPageTextBox.ReadOnly = true;
            this.lastPageTextBox.Size = new System.Drawing.Size(36, 25);
            this.lastPageTextBox.TabIndex = 33;
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.currentPageTextBox.Location = new System.Drawing.Point(444, 449);
            this.currentPageTextBox.Multiline = true;
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(36, 25);
            this.currentPageTextBox.TabIndex = 32;
            this.currentPageTextBox.TextChanged += new System.EventHandler(this.currentPageTextBox_TextChanged);
            this.currentPageTextBox.Enter += new System.EventHandler(this.currentPageTextBox_Enter);
            this.currentPageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentPageTextBox_KeyPress);
            // 
            // onlyShowActivesCheckBox
            // 
            this.onlyShowActivesCheckBox.AutoSize = true;
            this.onlyShowActivesCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyShowActivesCheckBox.Location = new System.Drawing.Point(765, 49);
            this.onlyShowActivesCheckBox.Name = "onlyShowActivesCheckBox";
            this.onlyShowActivesCheckBox.Size = new System.Drawing.Size(171, 25);
            this.onlyShowActivesCheckBox.TabIndex = 31;
            this.onlyShowActivesCheckBox.Text = "Solo mostrar activos";
            this.onlyShowActivesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 30;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(134, 47);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(554, 29);
            this.searchTextBox.TabIndex = 28;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(63, 50);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(65, 21);
            this.searchLabel.TabIndex = 27;
            this.searchLabel.Text = "Buscar:";
            // 
            // pagingLabel
            // 
            this.pagingLabel.AutoSize = true;
            this.pagingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.pagingLabel.Location = new System.Drawing.Point(360, 523);
            this.pagingLabel.Name = "pagingLabel";
            this.pagingLabel.Size = new System.Drawing.Size(0, 17);
            this.pagingLabel.TabIndex = 26;
            this.pagingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstButton
            // 
            this.firstButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButton.Location = new System.Drawing.Point(273, 449);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(75, 26);
            this.firstButton.TabIndex = 25;
            this.firstButton.Text = "Primero";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lastButton.Location = new System.Drawing.Point(649, 449);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(75, 26);
            this.lastButton.TabIndex = 24;
            this.lastButton.Text = "Ultimo";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.nextButton.Location = new System.Drawing.Point(568, 449);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 26);
            this.nextButton.TabIndex = 23;
            this.nextButton.Text = "Proximo";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.previousButton.Location = new System.Drawing.Point(354, 449);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 26);
            this.previousButton.TabIndex = 22;
            this.previousButton.Text = "Anterior";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(694, 488);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(243, 52);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Agregar nuevo artículo - elenco";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuButton.Location = new System.Drawing.Point(63, 488);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(243, 52);
            this.backToMenuButton.TabIndex = 20;
            this.backToMenuButton.Text = "Regresar al menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsLabel.Location = new System.Drawing.Point(58, 95);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(204, 30);
            this.clientsLabel.TabIndex = 19;
            this.clientsLabel.Text = "Artículos y elencos:";
            // 
            // articleCastsDataGridView
            // 
            this.articleCastsDataGridView.AllowUserToAddRows = false;
            this.articleCastsDataGridView.AllowUserToDeleteRows = false;
            this.articleCastsDataGridView.AllowUserToResizeColumns = false;
            this.articleCastsDataGridView.AllowUserToResizeRows = false;
            this.articleCastsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articleCastsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleCastsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articleCastsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleCastsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.article,
            this.cast,
            this.role,
            this.isActive,
            this.editButton,
            this.detailsButton,
            this.deleteButton});
            this.articleCastsDataGridView.Location = new System.Drawing.Point(63, 128);
            this.articleCastsDataGridView.Name = "articleCastsDataGridView";
            this.articleCastsDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleCastsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.articleCastsDataGridView.RowHeadersWidth = 50;
            this.articleCastsDataGridView.RowTemplate.Height = 19;
            this.articleCastsDataGridView.Size = new System.Drawing.Size(874, 315);
            this.articleCastsDataGridView.TabIndex = 18;
            this.articleCastsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articleCastsDataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.FillWeight = 46.07866F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // article
            // 
            this.article.FillWeight = 188.9678F;
            this.article.HeaderText = "Artículo";
            this.article.Name = "article";
            this.article.ReadOnly = true;
            // 
            // cast
            // 
            this.cast.FillWeight = 188.9678F;
            this.cast.HeaderText = "Elenco";
            this.cast.Name = "cast";
            this.cast.ReadOnly = true;
            // 
            // role
            // 
            this.role.FillWeight = 188.9678F;
            this.role.HeaderText = "Rol";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.FillWeight = 81.21828F;
            this.isActive.HeaderText = "Activo";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // editButton
            // 
            this.editButton.FillWeight = 34.43562F;
            this.editButton.HeaderText = "";
            this.editButton.Image = global::VideoClubManagement.Properties.Resources.edit_black_24dp;
            this.editButton.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.editButton.Name = "editButton";
            this.editButton.ReadOnly = true;
            // 
            // detailsButton
            // 
            this.detailsButton.FillWeight = 38.07484F;
            this.detailsButton.HeaderText = "";
            this.detailsButton.Image = global::VideoClubManagement.Properties.Resources.view_black_24dp;
            this.detailsButton.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.ReadOnly = true;
            this.detailsButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // deleteButton
            // 
            this.deleteButton.FillWeight = 33.2892F;
            this.deleteButton.HeaderText = "";
            this.deleteButton.Image = global::VideoClubManagement.Properties.Resources.delete_black_24dp;
            this.deleteButton.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ReadOnly = true;
            this.deleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 34.43562F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::VideoClubManagement.Properties.Resources.edit_black_24dp;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 36;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 38.07484F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::VideoClubManagement.Properties.Resources.view_black_24dp;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 39;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 33.2892F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::VideoClubManagement.Properties.Resources.delete_black_24dp;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 34;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.baseline_search_black_24dp;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(694, 48);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 29);
            this.searchButton.TabIndex = 29;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ArticleCastIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastPageTextBox);
            this.Controls.Add(this.currentPageTextBox);
            this.Controls.Add(this.onlyShowActivesCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.pagingLabel);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.clientsLabel);
            this.Controls.Add(this.articleCastsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ArticleCastIndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos y elenco:";
            this.Load += new System.EventHandler(this.ArticleCastIndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articleCastsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastPageTextBox;
        private System.Windows.Forms.TextBox currentPageTextBox;
        private System.Windows.Forms.CheckBox onlyShowActivesCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label pagingLabel;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.DataGridView articleCastsDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cast;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewImageColumn editButton;
        private System.Windows.Forms.DataGridViewImageColumn detailsButton;
        private System.Windows.Forms.DataGridViewImageColumn deleteButton;
    }
}