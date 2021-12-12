
namespace VideoClubManagement.UI.Language
{
    partial class languageForm
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.languageDataGridView = new System.Windows.Forms.DataGridView();
            this.insertPanel = new System.Windows.Forms.Panel();
            this.languageLabel = new System.Windows.Forms.Label();
            this.langCodeTextBox = new System.Windows.Forms.TextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.statusCheck = new System.Windows.Forms.CheckBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.searchPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageDataGridView)).BeginInit();
            this.insertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.exportButton);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Location = new System.Drawing.Point(586, 18);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(575, 102);
            this.searchPanel.TabIndex = 7;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(40, 45);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(352, 26);
            this.searchTextBox.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(404, 42);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 35);
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
            this.actionPanel.Location = new System.Drawing.Point(18, 260);
            this.actionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(549, 102);
            this.actionPanel.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(218, 45);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 35);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Regresar";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.Location = new System.Drawing.Point(339, 0);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 35);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateButton.Location = new System.Drawing.Point(218, 0);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 35);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Actualizar";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(96, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.languageDataGridView);
            this.dataPanel.Location = new System.Drawing.Point(586, 103);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(575, 265);
            this.dataPanel.TabIndex = 5;
            // 
            // languageDataGridView
            // 
            this.languageDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.languageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.languageDataGridView.Location = new System.Drawing.Point(8, 25);
            this.languageDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.languageDataGridView.Name = "languageDataGridView";
            this.languageDataGridView.RowHeadersWidth = 62;
            this.languageDataGridView.Size = new System.Drawing.Size(550, 240);
            this.languageDataGridView.TabIndex = 0;
            this.languageDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.languageDataGridView_CellMouseClick);
            // 
            // insertPanel
            // 
            this.insertPanel.Controls.Add(this.statusCheck);
            this.insertPanel.Controls.Add(this.languageLabel);
            this.insertPanel.Controls.Add(this.langCodeTextBox);
            this.insertPanel.Controls.Add(this.lastnameLabel);
            this.insertPanel.Controls.Add(this.nameTextBox);
            this.insertPanel.Controls.Add(this.nameLabel);
            this.insertPanel.Location = new System.Drawing.Point(18, 38);
            this.insertPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(549, 212);
            this.insertPanel.TabIndex = 4;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(177, 22);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(145, 20);
            this.languageLabel.TabIndex = 18;
            this.languageLabel.Text = "Gestión de idiomas";
            // 
            // langCodeTextBox
            // 
            this.langCodeTextBox.Location = new System.Drawing.Point(148, 138);
            this.langCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.langCodeTextBox.Name = "langCodeTextBox";
            this.langCodeTextBox.Size = new System.Drawing.Size(352, 26);
            this.langCodeTextBox.TabIndex = 7;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(30, 143);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastnameLabel.Size = new System.Drawing.Size(109, 20);
            this.lastnameLabel.TabIndex = 6;
            this.lastnameLabel.Text = "Código idioma";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(148, 85);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(352, 26);
            this.nameTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(64, 89);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(73, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nombre: ";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(18, -2);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(13, 26);
            this.idTextBox.TabIndex = 19;
            this.idTextBox.Visible = false;
            // 
            // statusCheck
            // 
            this.statusCheck.AutoSize = true;
            this.statusCheck.Location = new System.Drawing.Point(148, 185);
            this.statusCheck.Name = "statusCheck";
            this.statusCheck.Size = new System.Drawing.Size(113, 24);
            this.statusCheck.TabIndex = 19;
            this.statusCheck.Text = "Esta activo";
            this.statusCheck.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.csv;
            this.exportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportButton.Location = new System.Drawing.Point(522, 41);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(36, 35);
            this.exportButton.TabIndex = 22;
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // languageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 398);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.insertPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "languageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de idiomas";
            this.Load += new System.EventHandler(this.languageForm_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.languageDataGridView)).EndInit();
            this.insertPanel.ResumeLayout(false);
            this.insertPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView languageDataGridView;
        private System.Windows.Forms.Panel insertPanel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.TextBox langCodeTextBox;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.CheckBox statusCheck;
        private System.Windows.Forms.Button exportButton;
    }
}