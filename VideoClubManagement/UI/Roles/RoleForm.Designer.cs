namespace VideoClubManagement.UI.Roles
{
    partial class RoleForm
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
            this.searchPanel = new System.Windows.Forms.Panel();
            this.exportToCSVButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.roleDataGridView = new System.Windows.Forms.DataGridView();
            this.insertPanel = new System.Windows.Forms.Panel();
            this.lastUpadtedValueLabel = new System.Windows.Forms.Label();
            this.lastUpadtedLabel = new System.Windows.Forms.Label();
            this.createdDateValueLabel = new System.Windows.Forms.Label();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idValueLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.roleManagementabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dsecriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleDataGridView)).BeginInit();
            this.insertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.exportToCSVButton);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Location = new System.Drawing.Point(698, 15);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(6);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(682, 127);
            this.searchPanel.TabIndex = 23;
            // 
            // exportToCSVButton
            // 
            this.exportToCSVButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.csv;
            this.exportToCSVButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportToCSVButton.Location = new System.Drawing.Point(597, 50);
            this.exportToCSVButton.Name = "exportToCSVButton";
            this.exportToCSVButton.Size = new System.Drawing.Size(72, 44);
            this.exportToCSVButton.TabIndex = 36;
            this.exportToCSVButton.UseVisualStyleBackColor = true;
            this.exportToCSVButton.Click += new System.EventHandler(this.exportToCSVButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(9, 56);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(429, 33);
            this.searchTextBox.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(450, 50);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 44);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.backButton);
            this.actionPanel.Controls.Add(this.deleteButton);
            this.actionPanel.Controls.Add(this.updateButton);
            this.actionPanel.Controls.Add(this.addButton);
            this.actionPanel.Location = new System.Drawing.Point(15, 292);
            this.actionPanel.Margin = new System.Windows.Forms.Padding(6);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(671, 127);
            this.actionPanel.TabIndex = 22;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(263, 72);
            this.backButton.Margin = new System.Windows.Forms.Padding(6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 44);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Regresar";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.Location = new System.Drawing.Point(411, 16);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(138, 44);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateButton.Location = new System.Drawing.Point(263, 16);
            this.updateButton.Margin = new System.Windows.Forms.Padding(6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(138, 44);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Actualizar";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(114, 16);
            this.addButton.Margin = new System.Windows.Forms.Padding(6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(138, 44);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.roleDataGridView);
            this.dataPanel.Location = new System.Drawing.Point(698, 121);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(6);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(682, 298);
            this.dataPanel.TabIndex = 21;
            // 
            // roleDataGridView
            // 
            this.roleDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roleDataGridView.Location = new System.Drawing.Point(9, 31);
            this.roleDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.roleDataGridView.Name = "roleDataGridView";
            this.roleDataGridView.Size = new System.Drawing.Size(660, 256);
            this.roleDataGridView.TabIndex = 0;
            this.roleDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.roleDataGridView_CellMouseClick);
            // 
            // insertPanel
            // 
            this.insertPanel.Controls.Add(this.lastUpadtedValueLabel);
            this.insertPanel.Controls.Add(this.lastUpadtedLabel);
            this.insertPanel.Controls.Add(this.createdDateValueLabel);
            this.insertPanel.Controls.Add(this.creationDateLabel);
            this.insertPanel.Controls.Add(this.idLabel);
            this.insertPanel.Controls.Add(this.idValueLabel);
            this.insertPanel.Controls.Add(this.isActiveCheckBox);
            this.insertPanel.Controls.Add(this.roleManagementabel);
            this.insertPanel.Controls.Add(this.descriptionTextBox);
            this.insertPanel.Controls.Add(this.dsecriptionLabel);
            this.insertPanel.Controls.Add(this.nameTextBox);
            this.insertPanel.Controls.Add(this.nameLabel);
            this.insertPanel.Location = new System.Drawing.Point(15, 15);
            this.insertPanel.Margin = new System.Windows.Forms.Padding(6);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(671, 265);
            this.insertPanel.TabIndex = 20;
            // 
            // lastUpadtedValueLabel
            // 
            this.lastUpadtedValueLabel.AutoSize = true;
            this.lastUpadtedValueLabel.Location = new System.Drawing.Point(538, 220);
            this.lastUpadtedValueLabel.Name = "lastUpadtedValueLabel";
            this.lastUpadtedValueLabel.Size = new System.Drawing.Size(0, 25);
            this.lastUpadtedValueLabel.TabIndex = 25;
            // 
            // lastUpadtedLabel
            // 
            this.lastUpadtedLabel.AutoSize = true;
            this.lastUpadtedLabel.Location = new System.Drawing.Point(327, 220);
            this.lastUpadtedLabel.Name = "lastUpadtedLabel";
            this.lastUpadtedLabel.Size = new System.Drawing.Size(205, 25);
            this.lastUpadtedLabel.TabIndex = 24;
            this.lastUpadtedLabel.Text = "Fecha de Actualización";
            // 
            // createdDateValueLabel
            // 
            this.createdDateValueLabel.AutoSize = true;
            this.createdDateValueLabel.Location = new System.Drawing.Point(191, 220);
            this.createdDateValueLabel.Name = "createdDateValueLabel";
            this.createdDateValueLabel.Size = new System.Drawing.Size(0, 25);
            this.createdDateValueLabel.TabIndex = 23;
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Location = new System.Drawing.Point(18, 220);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(167, 25);
            this.creationDateLabel.TabIndex = 22;
            this.creationDateLabel.Text = "Fecha de Creación";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(606, 177);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(32, 25);
            this.idLabel.TabIndex = 21;
            this.idLabel.Text = "Id:";
            // 
            // idValueLabel
            // 
            this.idValueLabel.AutoSize = true;
            this.idValueLabel.Location = new System.Drawing.Point(633, 177);
            this.idValueLabel.Name = "idValueLabel";
            this.idValueLabel.Size = new System.Drawing.Size(0, 25);
            this.idValueLabel.TabIndex = 20;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(23, 176);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(122, 29);
            this.isActiveCheckBox.TabIndex = 19;
            this.isActiveCheckBox.Text = "Esta Activo";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // roleManagementabel
            // 
            this.roleManagementabel.AutoSize = true;
            this.roleManagementabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleManagementabel.Location = new System.Drawing.Point(216, 27);
            this.roleManagementabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roleManagementabel.Name = "roleManagementabel";
            this.roleManagementabel.Size = new System.Drawing.Size(159, 25);
            this.roleManagementabel.TabIndex = 18;
            this.roleManagementabel.Text = "Gestión de Roles";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(145, 119);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(520, 33);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // dsecriptionLabel
            // 
            this.dsecriptionLabel.AutoSize = true;
            this.dsecriptionLabel.Location = new System.Drawing.Point(18, 122);
            this.dsecriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dsecriptionLabel.Name = "dsecriptionLabel";
            this.dsecriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dsecriptionLabel.Size = new System.Drawing.Size(115, 25);
            this.dsecriptionLabel.TabIndex = 6;
            this.dsecriptionLabel.Text = "Descripción:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(114, 73);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(551, 33);
            this.nameTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(18, 76);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(90, 25);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nombre: ";
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 434);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.insertPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "RoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Roles";
            this.Load += new System.EventHandler(this.RoleForm_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roleDataGridView)).EndInit();
            this.insertPanel.ResumeLayout(false);
            this.insertPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView roleDataGridView;
        private System.Windows.Forms.Panel insertPanel;
        private System.Windows.Forms.Label roleManagementabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label dsecriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label lastUpadtedValueLabel;
        private System.Windows.Forms.Label lastUpadtedLabel;
        private System.Windows.Forms.Label createdDateValueLabel;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label idValueLabel;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Button exportToCSVButton;
    }
}