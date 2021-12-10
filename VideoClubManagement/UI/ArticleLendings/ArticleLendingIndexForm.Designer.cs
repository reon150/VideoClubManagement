
namespace VideoClubManagement.UI.ArticleLendings
{
    partial class ArticleLendingIndexForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.lastPageTextBox = new System.Windows.Forms.TextBox();
            this.currentPageTextBox = new System.Windows.Forms.TextBox();
            this.onlyShowActivesCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.firstButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.articleLendingLabel = new System.Windows.Forms.Label();
            this.articleLendingListDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.detailsButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.exportToCSVButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.articleLendingListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "/";
            // 
            // lastPageTextBox
            // 
            this.lastPageTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lastPageTextBox.Location = new System.Drawing.Point(495, 439);
            this.lastPageTextBox.Multiline = true;
            this.lastPageTextBox.Name = "lastPageTextBox";
            this.lastPageTextBox.ReadOnly = true;
            this.lastPageTextBox.Size = new System.Drawing.Size(36, 25);
            this.lastPageTextBox.TabIndex = 33;
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.currentPageTextBox.Location = new System.Drawing.Point(425, 439);
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
            this.onlyShowActivesCheckBox.Location = new System.Drawing.Point(746, 39);
            this.onlyShowActivesCheckBox.Name = "onlyShowActivesCheckBox";
            this.onlyShowActivesCheckBox.Size = new System.Drawing.Size(171, 25);
            this.onlyShowActivesCheckBox.TabIndex = 31;
            this.onlyShowActivesCheckBox.Text = "Solo mostrar activos";
            this.onlyShowActivesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(740, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 30;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(115, 37);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(533, 29);
            this.searchTextBox.TabIndex = 28;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(44, 40);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(65, 21);
            this.searchLabel.TabIndex = 27;
            this.searchLabel.Text = "Buscar:";
            // 
            // firstButton
            // 
            this.firstButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButton.Location = new System.Drawing.Point(254, 439);
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
            this.lastButton.Location = new System.Drawing.Point(630, 439);
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
            this.nextButton.Location = new System.Drawing.Point(549, 439);
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
            this.previousButton.Location = new System.Drawing.Point(335, 439);
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
            this.addButton.Location = new System.Drawing.Point(740, 478);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(178, 52);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Agregar nueva Renta";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuButton.Location = new System.Drawing.Point(44, 478);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(178, 52);
            this.backToMenuButton.TabIndex = 20;
            this.backToMenuButton.Text = "Regresar al menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // articleLendingLabel
            // 
            this.articleLendingLabel.AutoSize = true;
            this.articleLendingLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleLendingLabel.Location = new System.Drawing.Point(39, 85);
            this.articleLendingLabel.Name = "articleLendingLabel";
            this.articleLendingLabel.Size = new System.Drawing.Size(238, 30);
            this.articleLendingLabel.TabIndex = 19;
            this.articleLendingLabel.Text = "Rentas y Devoluciones:";
            // 
            // articleLendingListDataGridView
            // 
            this.articleLendingListDataGridView.AllowUserToAddRows = false;
            this.articleLendingListDataGridView.AllowUserToDeleteRows = false;
            this.articleLendingListDataGridView.AllowUserToResizeColumns = false;
            this.articleLendingListDataGridView.AllowUserToResizeRows = false;
            this.articleLendingListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articleLendingListDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleLendingListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.articleLendingListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleLendingListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.client,
            this.article,
            this.employee,
            this.isActive,
            this.editButton,
            this.detailsButton,
            this.deleteButton});
            this.articleLendingListDataGridView.Location = new System.Drawing.Point(44, 118);
            this.articleLendingListDataGridView.Name = "articleLendingListDataGridView";
            this.articleLendingListDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleLendingListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.articleLendingListDataGridView.RowHeadersWidth = 50;
            this.articleLendingListDataGridView.RowTemplate.Height = 19;
            this.articleLendingListDataGridView.Size = new System.Drawing.Size(874, 315);
            this.articleLendingListDataGridView.TabIndex = 18;
            this.articleLendingListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articleLendingListDataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.FillWeight = 101.5228F;
            this.id.HeaderText = "No. Renta";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // client
            // 
            this.client.FillWeight = 175.0709F;
            this.client.HeaderText = "Cliente";
            this.client.Name = "client";
            this.client.ReadOnly = true;
            // 
            // article
            // 
            this.article.FillWeight = 175.0709F;
            this.article.HeaderText = "Artículo";
            this.article.Name = "article";
            this.article.ReadOnly = true;
            // 
            // employee
            // 
            this.employee.FillWeight = 175.0709F;
            this.employee.HeaderText = "Empleado";
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.FillWeight = 75.2454F;
            this.isActive.HeaderText = "Activo";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // editButton
            // 
            this.editButton.FillWeight = 31.90319F;
            this.editButton.HeaderText = "";
            this.editButton.Image = global::VideoClubManagement.Properties.Resources.edit_black_24dp;
            this.editButton.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.editButton.Name = "editButton";
            this.editButton.ReadOnly = true;
            this.editButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // detailsButton
            // 
            this.detailsButton.FillWeight = 35.27478F;
            this.detailsButton.HeaderText = "";
            this.detailsButton.Image = global::VideoClubManagement.Properties.Resources.view_black_24dp;
            this.detailsButton.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.ReadOnly = true;
            this.detailsButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // deleteButton
            // 
            this.deleteButton.FillWeight = 30.84108F;
            this.deleteButton.HeaderText = "";
            this.deleteButton.Image = global::VideoClubManagement.Properties.Resources.delete_black_24dp;
            this.deleteButton.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ReadOnly = true;
            this.deleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 34.43562F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::VideoClubManagement.Properties.Resources.edit_black_24dp;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.Width = 34;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.baseline_search_black_24dp;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(654, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 29);
            this.searchButton.TabIndex = 29;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exportToCSVButton
            // 
            this.exportToCSVButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.csv;
            this.exportToCSVButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportToCSVButton.Location = new System.Drawing.Point(700, 37);
            this.exportToCSVButton.Name = "exportToCSVButton";
            this.exportToCSVButton.Size = new System.Drawing.Size(40, 29);
            this.exportToCSVButton.TabIndex = 37;
            this.exportToCSVButton.UseVisualStyleBackColor = true;
            this.exportToCSVButton.Click += new System.EventHandler(this.exportToCSVButton_Click);
            // 
            // ArticleLendingIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 566);
            this.Controls.Add(this.exportToCSVButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastPageTextBox);
            this.Controls.Add(this.currentPageTextBox);
            this.Controls.Add(this.onlyShowActivesCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.articleLendingLabel);
            this.Controls.Add(this.articleLendingListDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "ArticleLendingIndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renta y Devolución";
            ((System.ComponentModel.ISupportInitialize)(this.articleLendingListDataGridView)).EndInit();
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
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Label articleLendingLabel;
        private System.Windows.Forms.DataGridView articleLendingListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewImageColumn editButton;
        private System.Windows.Forms.DataGridViewImageColumn detailsButton;
        private System.Windows.Forms.DataGridViewImageColumn deleteButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Button exportToCSVButton;
    }
}