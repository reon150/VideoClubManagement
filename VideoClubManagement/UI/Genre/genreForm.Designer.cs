
namespace VideoClubManagement.UI.Genre
{
    partial class GenreForm
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.genreDataGridViewPanel = new System.Windows.Forms.Panel();
            this.genreDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreManagementPanel = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.statusCheckbox = new System.Windows.Forms.CheckBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.lastUpdateDateLabel = new System.Windows.Forms.Label();
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.genreLastUpdateDate = new System.Windows.Forms.Label();
            this.genreCreatedDateLabel = new System.Windows.Forms.Label();
            this.genreIdLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.genreDescriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.genreNameLabel = new System.Windows.Forms.Label();
            this.genreManagementLabel = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            this.genreDataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).BeginInit();
            this.genreManagementPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Location = new System.Drawing.Point(341, 12);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(464, 82);
            this.searchPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(21, 27);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(326, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(384, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(52, 50);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // genreDataGridViewPanel
            // 
            this.genreDataGridViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.genreDataGridViewPanel.Controls.Add(this.genreDataGridView);
            this.genreDataGridViewPanel.Location = new System.Drawing.Point(12, 115);
            this.genreDataGridViewPanel.Name = "genreDataGridViewPanel";
            this.genreDataGridViewPanel.Size = new System.Drawing.Size(799, 233);
            this.genreDataGridViewPanel.TabIndex = 1;
            // 
            // genreDataGridView
            // 
            this.genreDataGridView.AllowUserToAddRows = false;
            this.genreDataGridView.AllowUserToDeleteRows = false;
            this.genreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.genreDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.genreDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.genreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.isActive,
            this.createdDate,
            this.lastUpdatedDate});
            this.genreDataGridView.Location = new System.Drawing.Point(3, 3);
            this.genreDataGridView.Name = "genreDataGridView";
            this.genreDataGridView.ReadOnly = true;
            this.genreDataGridView.Size = new System.Drawing.Size(788, 223);
            this.genreDataGridView.TabIndex = 0;
            this.genreDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.genreDataGridView_CellMouseClick_1);
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
            this.name.HeaderText = "Nombre";
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
            // genreManagementPanel
            // 
            this.genreManagementPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.genreManagementPanel.Controls.Add(this.idLabel);
            this.genreManagementPanel.Controls.Add(this.statusCheckbox);
            this.genreManagementPanel.Controls.Add(this.statusLabel);
            this.genreManagementPanel.Controls.Add(this.lastUpdateDateLabel);
            this.genreManagementPanel.Controls.Add(this.createdDateLabel);
            this.genreManagementPanel.Controls.Add(this.genreLastUpdateDate);
            this.genreManagementPanel.Controls.Add(this.genreCreatedDateLabel);
            this.genreManagementPanel.Controls.Add(this.genreIdLabel);
            this.genreManagementPanel.Controls.Add(this.descriptionTextBox);
            this.genreManagementPanel.Controls.Add(this.genreDescriptionLabel);
            this.genreManagementPanel.Controls.Add(this.nameTextBox);
            this.genreManagementPanel.Controls.Add(this.genreNameLabel);
            this.genreManagementPanel.Controls.Add(this.genreManagementLabel);
            this.genreManagementPanel.Location = new System.Drawing.Point(160, 366);
            this.genreManagementPanel.Name = "genreManagementPanel";
            this.genreManagementPanel.Size = new System.Drawing.Size(458, 326);
            this.genreManagementPanel.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(158, 56);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(10, 13);
            this.idLabel.TabIndex = 15;
            this.idLabel.Text = "-";
            // 
            // statusCheckbox
            // 
            this.statusCheckbox.AutoSize = true;
            this.statusCheckbox.Location = new System.Drawing.Point(158, 201);
            this.statusCheckbox.Name = "statusCheckbox";
            this.statusCheckbox.Size = new System.Drawing.Size(80, 17);
            this.statusCheckbox.TabIndex = 14;
            this.statusCheckbox.Text = "Esta Activo";
            this.statusCheckbox.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(17, 205);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Estado";
            // 
            // lastUpdateDateLabel
            // 
            this.lastUpdateDateLabel.AutoSize = true;
            this.lastUpdateDateLabel.Location = new System.Drawing.Point(158, 298);
            this.lastUpdateDateLabel.Name = "lastUpdateDateLabel";
            this.lastUpdateDateLabel.Size = new System.Drawing.Size(10, 13);
            this.lastUpdateDateLabel.TabIndex = 11;
            this.lastUpdateDateLabel.Text = "-";
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Location = new System.Drawing.Point(158, 250);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(10, 13);
            this.createdDateLabel.TabIndex = 10;
            this.createdDateLabel.Text = "-";
            // 
            // genreLastUpdateDate
            // 
            this.genreLastUpdateDate.AutoSize = true;
            this.genreLastUpdateDate.Location = new System.Drawing.Point(17, 298);
            this.genreLastUpdateDate.Name = "genreLastUpdateDate";
            this.genreLastUpdateDate.Size = new System.Drawing.Size(98, 13);
            this.genreLastUpdateDate.TabIndex = 9;
            this.genreLastUpdateDate.Text = "Ultima modificación";
            // 
            // genreCreatedDateLabel
            // 
            this.genreCreatedDateLabel.AutoSize = true;
            this.genreCreatedDateLabel.Location = new System.Drawing.Point(17, 250);
            this.genreCreatedDateLabel.Name = "genreCreatedDateLabel";
            this.genreCreatedDateLabel.Size = new System.Drawing.Size(96, 13);
            this.genreCreatedDateLabel.TabIndex = 7;
            this.genreCreatedDateLabel.Text = "Fecha de creación";
            // 
            // genreIdLabel
            // 
            this.genreIdLabel.AutoSize = true;
            this.genreIdLabel.Location = new System.Drawing.Point(17, 56);
            this.genreIdLabel.Name = "genreIdLabel";
            this.genreIdLabel.Size = new System.Drawing.Size(16, 13);
            this.genreIdLabel.TabIndex = 5;
            this.genreIdLabel.Text = "Id";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(158, 153);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(219, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // genreDescriptionLabel
            // 
            this.genreDescriptionLabel.AutoSize = true;
            this.genreDescriptionLabel.Location = new System.Drawing.Point(17, 156);
            this.genreDescriptionLabel.Name = "genreDescriptionLabel";
            this.genreDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.genreDescriptionLabel.TabIndex = 3;
            this.genreDescriptionLabel.Text = "Descripción";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(158, 101);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(133, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // genreNameLabel
            // 
            this.genreNameLabel.AutoSize = true;
            this.genreNameLabel.Location = new System.Drawing.Point(17, 104);
            this.genreNameLabel.Name = "genreNameLabel";
            this.genreNameLabel.Size = new System.Drawing.Size(44, 13);
            this.genreNameLabel.TabIndex = 1;
            this.genreNameLabel.Text = "Nombre";
            // 
            // genreManagementLabel
            // 
            this.genreManagementLabel.AutoSize = true;
            this.genreManagementLabel.Location = new System.Drawing.Point(158, 15);
            this.genreManagementLabel.Name = "genreManagementLabel";
            this.genreManagementLabel.Size = new System.Drawing.Size(99, 13);
            this.genreManagementLabel.TabIndex = 0;
            this.genreManagementLabel.Text = "Gestión de géneros";
            // 
            // actionPanel
            // 
            this.actionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.actionPanel.Controls.Add(this.backButton);
            this.actionPanel.Controls.Add(this.deleteButton);
            this.actionPanel.Controls.Add(this.updateButton);
            this.actionPanel.Controls.Add(this.addButton);
            this.actionPanel.Location = new System.Drawing.Point(159, 709);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(459, 82);
            this.actionPanel.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(373, 14);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(63, 50);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Regresar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(258, 14);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(66, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.Location = new System.Drawing.Point(137, 14);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(66, 50);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Actualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(21, 14);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(66, 50);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Géneros:";
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 820);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.genreManagementPanel);
            this.Controls.Add(this.genreDataGridViewPanel);
            this.Controls.Add(this.searchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista y mantenimiento de género";
            this.Load += new System.EventHandler(this.genreForm_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.genreDataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genreDataGridView)).EndInit();
            this.genreManagementPanel.ResumeLayout(false);
            this.genreManagementPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel genreDataGridViewPanel;
        private System.Windows.Forms.Panel genreManagementPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView genreDataGridView;
        private System.Windows.Forms.Label genreNameLabel;
        private System.Windows.Forms.Label genreManagementLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label genreDescriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label lastUpdateDateLabel;
        private System.Windows.Forms.Label createdDateLabel;
        private System.Windows.Forms.Label genreLastUpdateDate;
        private System.Windows.Forms.Label genreCreatedDateLabel;
        private System.Windows.Forms.Label genreIdLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.CheckBox statusCheckbox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDate;
    }
}