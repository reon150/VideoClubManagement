
namespace VideoClubManagement.UI.ArticleType
{
    partial class ArticleTypeForm
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
            this.searchPanel = new System.Windows.Forms.Panel();
            this.exportToCVSButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.articleTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleTypeManagementPanel = new System.Windows.Forms.Panel();
            this.lastUpdateDateLabel = new System.Windows.Forms.Label();
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.articleTypeLastUpateDate = new System.Windows.Forms.Label();
            this.articleTypeCreateDateLabel = new System.Windows.Forms.Label();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.articleTypeIdLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.articleTypeManagementLabel = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleTypeDataGridView)).BeginInit();
            this.articleTypeManagementPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchPanel.Controls.Add(this.exportToCVSButton);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Location = new System.Drawing.Point(299, 12);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(459, 82);
            this.searchPanel.TabIndex = 1;
            // 
            // exportToCVSButton
            // 
            this.exportToCVSButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.csv;
            this.exportToCVSButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportToCVSButton.Location = new System.Drawing.Point(400, 11);
            this.exportToCVSButton.Name = "exportToCVSButton";
            this.exportToCVSButton.Size = new System.Drawing.Size(52, 50);
            this.exportToCVSButton.TabIndex = 2;
            this.exportToCVSButton.UseVisualStyleBackColor = true;
            this.exportToCVSButton.Click += new System.EventHandler(this.exportToCVSButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(21, 27);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(287, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.baseline_search_black_24dp;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(332, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(52, 50);
            this.searchButton.TabIndex = 0;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(332, 14);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(63, 50);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Regresar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // articleTypeDataGridView
            // 
            this.articleTypeDataGridView.AllowUserToAddRows = false;
            this.articleTypeDataGridView.AllowUserToDeleteRows = false;
            this.articleTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articleTypeDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleTypeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articleTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.isActive,
            this.createdDate,
            this.lastUpdatedDate});
            this.articleTypeDataGridView.Location = new System.Drawing.Point(12, 100);
            this.articleTypeDataGridView.Name = "articleTypeDataGridView";
            this.articleTypeDataGridView.ReadOnly = true;
            this.articleTypeDataGridView.Size = new System.Drawing.Size(764, 200);
            this.articleTypeDataGridView.TabIndex = 2;
            this.articleTypeDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.articleTypeDataGridView_CellMouseClick_1);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "Descripción";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "IsActive";
            this.isActive.HeaderText = "Está Activo";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            // 
            // createdDate
            // 
            this.createdDate.DataPropertyName = "CreatedDate";
            this.createdDate.HeaderText = "Fecha de creación";
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            // 
            // lastUpdatedDate
            // 
            this.lastUpdatedDate.DataPropertyName = "LastUpdatedDate";
            this.lastUpdatedDate.HeaderText = "Fecha de actualización";
            this.lastUpdatedDate.Name = "lastUpdatedDate";
            this.lastUpdatedDate.ReadOnly = true;
            // 
            // articleTypeManagementPanel
            // 
            this.articleTypeManagementPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.articleTypeManagementPanel.Controls.Add(this.lastUpdateDateLabel);
            this.articleTypeManagementPanel.Controls.Add(this.createdDateLabel);
            this.articleTypeManagementPanel.Controls.Add(this.articleTypeLastUpateDate);
            this.articleTypeManagementPanel.Controls.Add(this.articleTypeCreateDateLabel);
            this.articleTypeManagementPanel.Controls.Add(this.statusCheckBox);
            this.articleTypeManagementPanel.Controls.Add(this.statusLabel);
            this.articleTypeManagementPanel.Controls.Add(this.idLabel);
            this.articleTypeManagementPanel.Controls.Add(this.articleTypeIdLabel);
            this.articleTypeManagementPanel.Controls.Add(this.descriptionTextBox);
            this.articleTypeManagementPanel.Controls.Add(this.descriptionLabel);
            this.articleTypeManagementPanel.Controls.Add(this.nameTextBox);
            this.articleTypeManagementPanel.Controls.Add(this.nameLabel);
            this.articleTypeManagementPanel.Controls.Add(this.articleTypeManagementLabel);
            this.articleTypeManagementPanel.Location = new System.Drawing.Point(208, 306);
            this.articleTypeManagementPanel.Name = "articleTypeManagementPanel";
            this.articleTypeManagementPanel.Size = new System.Drawing.Size(414, 346);
            this.articleTypeManagementPanel.TabIndex = 3;
            // 
            // lastUpdateDateLabel
            // 
            this.lastUpdateDateLabel.AutoSize = true;
            this.lastUpdateDateLabel.Location = new System.Drawing.Point(148, 296);
            this.lastUpdateDateLabel.Name = "lastUpdateDateLabel";
            this.lastUpdateDateLabel.Size = new System.Drawing.Size(10, 13);
            this.lastUpdateDateLabel.TabIndex = 12;
            this.lastUpdateDateLabel.Text = "-";
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Location = new System.Drawing.Point(148, 253);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(10, 13);
            this.createdDateLabel.TabIndex = 11;
            this.createdDateLabel.Text = "-";
            // 
            // articleTypeLastUpateDate
            // 
            this.articleTypeLastUpateDate.AutoSize = true;
            this.articleTypeLastUpateDate.Location = new System.Drawing.Point(14, 296);
            this.articleTypeLastUpateDate.Name = "articleTypeLastUpateDate";
            this.articleTypeLastUpateDate.Size = new System.Drawing.Size(99, 13);
            this.articleTypeLastUpateDate.TabIndex = 10;
            this.articleTypeLastUpateDate.Text = "Ultima Modificación";
            // 
            // articleTypeCreateDateLabel
            // 
            this.articleTypeCreateDateLabel.AutoSize = true;
            this.articleTypeCreateDateLabel.Location = new System.Drawing.Point(17, 253);
            this.articleTypeCreateDateLabel.Name = "articleTypeCreateDateLabel";
            this.articleTypeCreateDateLabel.Size = new System.Drawing.Size(96, 13);
            this.articleTypeCreateDateLabel.TabIndex = 9;
            this.articleTypeCreateDateLabel.Text = "Fecha de creación";
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Checked = true;
            this.statusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusCheckBox.Location = new System.Drawing.Point(89, 198);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(80, 17);
            this.statusCheckBox.TabIndex = 8;
            this.statusCheckBox.Text = "Esta Activo";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(18, 202);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Estado";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(83, 61);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(10, 13);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "-";
            // 
            // articleTypeIdLabel
            // 
            this.articleTypeIdLabel.AutoSize = true;
            this.articleTypeIdLabel.Location = new System.Drawing.Point(18, 61);
            this.articleTypeIdLabel.Name = "articleTypeIdLabel";
            this.articleTypeIdLabel.Size = new System.Drawing.Size(16, 13);
            this.articleTypeIdLabel.TabIndex = 5;
            this.articleTypeIdLabel.Text = "Id";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(89, 153);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(219, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(17, 156);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Descripción";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(89, 108);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(133, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 111);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nombre";
            // 
            // articleTypeManagementLabel
            // 
            this.articleTypeManagementLabel.AutoSize = true;
            this.articleTypeManagementLabel.Location = new System.Drawing.Point(134, 16);
            this.articleTypeManagementLabel.Name = "articleTypeManagementLabel";
            this.articleTypeManagementLabel.Size = new System.Drawing.Size(142, 13);
            this.articleTypeManagementLabel.TabIndex = 0;
            this.articleTypeManagementLabel.Text = "Gestión de tipos de artículos";
            // 
            // actionPanel
            // 
            this.actionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.actionPanel.Controls.Add(this.backButton);
            this.actionPanel.Controls.Add(this.deleteButton);
            this.actionPanel.Controls.Add(this.updateButton);
            this.actionPanel.Controls.Add(this.addButton);
            this.actionPanel.Location = new System.Drawing.Point(208, 658);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(414, 82);
            this.actionPanel.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.delete_black_24dp;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(230, 14);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(66, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.edit_black_24dp;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.Location = new System.Drawing.Point(122, 14);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(66, 50);
            this.updateButton.TabIndex = 1;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.baseline_add_black_24dp;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(14, 14);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(66, 50);
            this.addButton.TabIndex = 0;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipos de artículos:";
            // 
            // ArticleTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 745);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.articleTypeManagementPanel);
            this.Controls.Add(this.articleTypeDataGridView);
            this.Controls.Add(this.searchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ArticleTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista y mantenimiento del tipo de artículo";
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleTypeDataGridView)).EndInit();
            this.articleTypeManagementPanel.ResumeLayout(false);
            this.articleTypeManagementPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView articleTypeDataGridView;
        private System.Windows.Forms.Panel articleTypeManagementPanel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label articleTypeManagementLabel;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label articleTypeIdLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.Label articleTypeLastUpateDate;
        private System.Windows.Forms.Label articleTypeCreateDateLabel;
        private System.Windows.Forms.Label lastUpdateDateLabel;
        private System.Windows.Forms.Label createdDateLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDate;
        private System.Windows.Forms.Button exportToCVSButton;
    }
}