
namespace VideoClubManagement.UI.Client
{
    partial class ClientIndexForm
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
            this.clientListDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxpayerIdentificationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.detailsButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.pagingLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.onlyShowActivesCheckBox = new System.Windows.Forms.CheckBox();
            this.currentPageTextBox = new System.Windows.Forms.TextBox();
            this.lastPageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientListDataGridView
            // 
            this.clientListDataGridView.AllowUserToAddRows = false;
            this.clientListDataGridView.AllowUserToDeleteRows = false;
            this.clientListDataGridView.AllowUserToResizeColumns = false;
            this.clientListDataGridView.AllowUserToResizeRows = false;
            this.clientListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientListDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.lastName,
            this.taxpayerIdentificationNumber,
            this.isActive,
            this.editButton,
            this.detailsButton,
            this.deleteButton});
            this.clientListDataGridView.Location = new System.Drawing.Point(41, 122);
            this.clientListDataGridView.Name = "clientListDataGridView";
            this.clientListDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientListDataGridView.RowHeadersWidth = 50;
            this.clientListDataGridView.RowTemplate.Height = 19;
            this.clientListDataGridView.Size = new System.Drawing.Size(874, 315);
            this.clientListDataGridView.TabIndex = 0;
            this.clientListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientListDataGridView_CellClick);
            // 
            // id
            // 
            this.id.FillWeight = 46.07866F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.FillWeight = 188.9678F;
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.FillWeight = 188.9678F;
            this.lastName.HeaderText = "Apellido";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // taxpayerIdentificationNumber
            // 
            this.taxpayerIdentificationNumber.FillWeight = 188.9678F;
            this.taxpayerIdentificationNumber.HeaderText = "Cedula/RNC";
            this.taxpayerIdentificationNumber.Name = "taxpayerIdentificationNumber";
            this.taxpayerIdentificationNumber.ReadOnly = true;
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
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsLabel.Location = new System.Drawing.Point(36, 89);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(96, 30);
            this.clientsLabel.TabIndex = 1;
            this.clientsLabel.Text = "Clientes:";
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuButton.Location = new System.Drawing.Point(41, 482);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(178, 52);
            this.backToMenuButton.TabIndex = 2;
            this.backToMenuButton.Text = "Regresar al menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(737, 482);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(178, 52);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Agregar nuevo cliente";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.previousButton.Location = new System.Drawing.Point(332, 443);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 26);
            this.previousButton.TabIndex = 4;
            this.previousButton.Text = "Anterior";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.nextButton.Location = new System.Drawing.Point(546, 443);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 26);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Proximo";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lastButton.Location = new System.Drawing.Point(627, 443);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(75, 26);
            this.lastButton.TabIndex = 6;
            this.lastButton.Text = "Ultimo";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButton.Location = new System.Drawing.Point(251, 443);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(75, 26);
            this.firstButton.TabIndex = 7;
            this.firstButton.Text = "Primero";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // pagingLabel
            // 
            this.pagingLabel.AutoSize = true;
            this.pagingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.pagingLabel.Location = new System.Drawing.Point(338, 517);
            this.pagingLabel.Name = "pagingLabel";
            this.pagingLabel.Size = new System.Drawing.Size(0, 17);
            this.pagingLabel.TabIndex = 8;
            this.pagingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(41, 44);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(65, 21);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Buscar:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(112, 41);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(554, 29);
            this.searchTextBox.TabIndex = 10;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 34.43562F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::VideoClubManagement.Properties.Resources.edit_black_24dp;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 36;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 38.07484F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::VideoClubManagement.Properties.Resources.view_black_24dp;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
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
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 34;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.baseline_search_black_24dp;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(672, 42);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 29);
            this.searchButton.TabIndex = 11;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // onlyShowActivesCheckBox
            // 
            this.onlyShowActivesCheckBox.AutoSize = true;
            this.onlyShowActivesCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyShowActivesCheckBox.Location = new System.Drawing.Point(743, 43);
            this.onlyShowActivesCheckBox.Name = "onlyShowActivesCheckBox";
            this.onlyShowActivesCheckBox.Size = new System.Drawing.Size(171, 25);
            this.onlyShowActivesCheckBox.TabIndex = 14;
            this.onlyShowActivesCheckBox.Text = "Solo mostrar activos";
            this.onlyShowActivesCheckBox.UseVisualStyleBackColor = true;
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.currentPageTextBox.Location = new System.Drawing.Point(422, 443);
            this.currentPageTextBox.Multiline = true;
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(36, 25);
            this.currentPageTextBox.TabIndex = 15;
            this.currentPageTextBox.TextChanged += new System.EventHandler(this.currentPageTextBox_TextChanged);
            this.currentPageTextBox.Enter += new System.EventHandler(this.currentPageTextBox_Enter);
            this.currentPageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentPageTextBox_KeyPress);
            // 
            // lastPageTextBox
            // 
            this.lastPageTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lastPageTextBox.Location = new System.Drawing.Point(492, 443);
            this.lastPageTextBox.Multiline = true;
            this.lastPageTextBox.Name = "lastPageTextBox";
            this.lastPageTextBox.ReadOnly = true;
            this.lastPageTextBox.Size = new System.Drawing.Size(36, 25);
            this.lastPageTextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "/";
            // 
            // ClientIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 566);
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
            this.Controls.Add(this.clientListDataGridView);
            this.MaximizeBox = false;
            this.Name = "ClientIndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientIndexForm";
            this.Load += new System.EventHandler(this.ClientIndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientListDataGridView;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Label pagingLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox onlyShowActivesCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxpayerIdentificationNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewImageColumn editButton;
        private System.Windows.Forms.DataGridViewImageColumn detailsButton;
        private System.Windows.Forms.DataGridViewImageColumn deleteButton;
        private System.Windows.Forms.TextBox currentPageTextBox;
        private System.Windows.Forms.TextBox lastPageTextBox;
        private System.Windows.Forms.Label label2;
    }
}