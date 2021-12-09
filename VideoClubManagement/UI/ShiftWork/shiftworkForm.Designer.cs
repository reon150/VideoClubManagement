
namespace VideoClubManagement.UI.Shiftwork
{
    partial class shiftworkForm
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
            this.shiftworkDataGridView = new System.Windows.Forms.DataGridView();
            this.insertPanel = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.startHourDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shiftworkiniLabel = new System.Windows.Forms.Label();
            this.finishHourDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idnumberLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.statusCheck = new System.Windows.Forms.CheckBox();
            this.searchPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftworkDataGridView)).BeginInit();
            this.insertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.exportButton);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Location = new System.Drawing.Point(584, 18);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(663, 102);
            this.searchPanel.TabIndex = 7;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(105, 42);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(352, 26);
            this.searchTextBox.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(468, 38);
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
            this.actionPanel.Location = new System.Drawing.Point(9, 314);
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
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Regresar";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(339, 0);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 35);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(218, 0);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 35);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Actualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(96, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.shiftworkDataGridView);
            this.dataPanel.Location = new System.Drawing.Point(584, 129);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(663, 286);
            this.dataPanel.TabIndex = 5;
            // 
            // shiftworkDataGridView
            // 
            this.shiftworkDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shiftworkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftworkDataGridView.Location = new System.Drawing.Point(8, 0);
            this.shiftworkDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shiftworkDataGridView.Name = "shiftworkDataGridView";
            this.shiftworkDataGridView.RowHeadersWidth = 62;
            this.shiftworkDataGridView.Size = new System.Drawing.Size(642, 271);
            this.shiftworkDataGridView.TabIndex = 0;
            this.shiftworkDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shiftworkDataGridView_CellContentClick);
            this.shiftworkDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.shiftworkDataGridView_CellMouseClick);
            // 
            // insertPanel
            // 
            this.insertPanel.Controls.Add(this.statusCheck);
            this.insertPanel.Controls.Add(this.idTextBox);
            this.insertPanel.Controls.Add(this.startHourDateTimePicker);
            this.insertPanel.Controls.Add(this.shiftworkiniLabel);
            this.insertPanel.Controls.Add(this.finishHourDateTimePicker);
            this.insertPanel.Controls.Add(this.idnumberLabel);
            this.insertPanel.Controls.Add(this.lastnameLabel);
            this.insertPanel.Controls.Add(this.descriptionTextBox);
            this.insertPanel.Controls.Add(this.nameLabel);
            this.insertPanel.Location = new System.Drawing.Point(9, 18);
            this.insertPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(549, 286);
            this.insertPanel.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(0, 0);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(148, 26);
            this.idTextBox.TabIndex = 20;
            this.idTextBox.Visible = false;
            // 
            // startHourDateTimePicker
            // 
            this.startHourDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startHourDateTimePicker.Location = new System.Drawing.Point(148, 138);
            this.startHourDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startHourDateTimePicker.Name = "startHourDateTimePicker";
            this.startHourDateTimePicker.Size = new System.Drawing.Size(350, 26);
            this.startHourDateTimePicker.TabIndex = 19;
            // 
            // shiftworkiniLabel
            // 
            this.shiftworkiniLabel.AutoSize = true;
            this.shiftworkiniLabel.Location = new System.Drawing.Point(177, 22);
            this.shiftworkiniLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shiftworkiniLabel.Name = "shiftworkiniLabel";
            this.shiftworkiniLabel.Size = new System.Drawing.Size(208, 20);
            this.shiftworkiniLabel.TabIndex = 18;
            this.shiftworkiniLabel.Text = "Gestión de tandas laborales";
            this.shiftworkiniLabel.Click += new System.EventHandler(this.employeeLabel_Click);
            // 
            // finishHourDateTimePicker
            // 
            this.finishHourDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.finishHourDateTimePicker.Location = new System.Drawing.Point(148, 195);
            this.finishHourDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finishHourDateTimePicker.Name = "finishHourDateTimePicker";
            this.finishHourDateTimePicker.Size = new System.Drawing.Size(350, 26);
            this.finishHourDateTimePicker.TabIndex = 16;
            // 
            // idnumberLabel
            // 
            this.idnumberLabel.AutoSize = true;
            this.idnumberLabel.Location = new System.Drawing.Point(64, 200);
            this.idnumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idnumberLabel.Name = "idnumberLabel";
            this.idnumberLabel.Size = new System.Drawing.Size(73, 20);
            this.idnumberLabel.TabIndex = 8;
            this.idnumberLabel.Text = "Hora fin: ";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(45, 143);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastnameLabel.Size = new System.Drawing.Size(91, 20);
            this.lastnameLabel.TabIndex = 6;
            this.lastnameLabel.Text = "Hora inicio: ";
            this.lastnameLabel.Click += new System.EventHandler(this.lastnameLabel_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(148, 85);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(352, 26);
            this.descriptionTextBox.TabIndex = 5;
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
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.csv;
            this.exportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportButton.Location = new System.Drawing.Point(588, 38);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(36, 35);
            this.exportButton.TabIndex = 21;
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // statusCheck
            // 
            this.statusCheck.AutoSize = true;
            this.statusCheck.Location = new System.Drawing.Point(148, 245);
            this.statusCheck.Name = "statusCheck";
            this.statusCheck.Size = new System.Drawing.Size(113, 24);
            this.statusCheck.TabIndex = 21;
            this.statusCheck.Text = "Esta activo";
            this.statusCheck.UseVisualStyleBackColor = true;
            // 
            // shiftworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 422);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.insertPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "shiftworkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de tandas laborales";
            this.Load += new System.EventHandler(this.shiftworkForm_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shiftworkDataGridView)).EndInit();
            this.insertPanel.ResumeLayout(false);
            this.insertPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView shiftworkDataGridView;
        private System.Windows.Forms.Panel insertPanel;
        private System.Windows.Forms.Label shiftworkiniLabel;
        private System.Windows.Forms.DateTimePicker finishHourDateTimePicker;
        private System.Windows.Forms.Label idnumberLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DateTimePicker startHourDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.CheckBox statusCheck;
    }
}