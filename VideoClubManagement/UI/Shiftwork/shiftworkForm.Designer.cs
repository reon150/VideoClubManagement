
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.shiftworkDataGridView = new System.Windows.Forms.DataGridView();
            this.insertPanel = new System.Windows.Forms.Panel();
            this.startHourDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shiftworkiniLabel = new System.Windows.Forms.Label();
            this.finishHourDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idnumberLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.searchPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftworkDataGridView)).BeginInit();
            this.insertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Location = new System.Drawing.Point(389, 12);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(442, 66);
            this.searchPanel.TabIndex = 7;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(70, 27);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(236, 20);
            this.searchTextBox.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(312, 25);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.deleteButton);
            this.actionPanel.Controls.Add(this.updateButton);
            this.actionPanel.Controls.Add(this.addButton);
            this.actionPanel.Location = new System.Drawing.Point(6, 204);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(366, 66);
            this.actionPanel.TabIndex = 6;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(226, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(145, 0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Actualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(64, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.shiftworkDataGridView);
            this.dataPanel.Location = new System.Drawing.Point(389, 84);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(442, 186);
            this.dataPanel.TabIndex = 5;
            // 
            // shiftworkDataGridView
            // 
            this.shiftworkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftworkDataGridView.Location = new System.Drawing.Point(5, 0);
            this.shiftworkDataGridView.Name = "shiftworkDataGridView";
            this.shiftworkDataGridView.Size = new System.Drawing.Size(428, 176);
            this.shiftworkDataGridView.TabIndex = 0;
            this.shiftworkDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shiftworkDataGridView_CellContentClick);
            this.shiftworkDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.shiftworkDataGridView_CellMouseClick);
            // 
            // insertPanel
            // 
            this.insertPanel.Controls.Add(this.idTextBox);
            this.insertPanel.Controls.Add(this.startHourDateTimePicker);
            this.insertPanel.Controls.Add(this.shiftworkiniLabel);
            this.insertPanel.Controls.Add(this.finishHourDateTimePicker);
            this.insertPanel.Controls.Add(this.idnumberLabel);
            this.insertPanel.Controls.Add(this.lastnameLabel);
            this.insertPanel.Controls.Add(this.descriptionTextBox);
            this.insertPanel.Controls.Add(this.nameLabel);
            this.insertPanel.Location = new System.Drawing.Point(6, 12);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(366, 186);
            this.insertPanel.TabIndex = 4;
            // 
            // startHourDateTimePicker
            // 
            this.startHourDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startHourDateTimePicker.Location = new System.Drawing.Point(99, 90);
            this.startHourDateTimePicker.Name = "startHourDateTimePicker";
            this.startHourDateTimePicker.Size = new System.Drawing.Size(235, 20);
            this.startHourDateTimePicker.TabIndex = 19;
            // 
            // shiftworkiniLabel
            // 
            this.shiftworkiniLabel.AutoSize = true;
            this.shiftworkiniLabel.Location = new System.Drawing.Point(118, 14);
            this.shiftworkiniLabel.Name = "shiftworkiniLabel";
            this.shiftworkiniLabel.Size = new System.Drawing.Size(138, 13);
            this.shiftworkiniLabel.TabIndex = 18;
            this.shiftworkiniLabel.Text = "Gestión de tandas laborales";
            this.shiftworkiniLabel.Click += new System.EventHandler(this.employeeLabel_Click);
            // 
            // finishHourDateTimePicker
            // 
            this.finishHourDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.finishHourDateTimePicker.Location = new System.Drawing.Point(99, 127);
            this.finishHourDateTimePicker.Name = "finishHourDateTimePicker";
            this.finishHourDateTimePicker.Size = new System.Drawing.Size(235, 20);
            this.finishHourDateTimePicker.TabIndex = 16;
            // 
            // idnumberLabel
            // 
            this.idnumberLabel.AutoSize = true;
            this.idnumberLabel.Location = new System.Drawing.Point(43, 130);
            this.idnumberLabel.Name = "idnumberLabel";
            this.idnumberLabel.Size = new System.Drawing.Size(50, 13);
            this.idnumberLabel.TabIndex = 8;
            this.idnumberLabel.Text = "Hora fin: ";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(30, 93);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastnameLabel.Size = new System.Drawing.Size(63, 13);
            this.lastnameLabel.TabIndex = 6;
            this.lastnameLabel.Text = "Hora inicio: ";
            this.lastnameLabel.Click += new System.EventHandler(this.lastnameLabel_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(99, 55);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(236, 20);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(43, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nombre: ";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(0, 0);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 20;
            this.idTextBox.Visible = false;
            // 
            // shiftworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 274);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.insertPanel);
            this.Name = "shiftworkForm";
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
    }
}