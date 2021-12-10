
namespace VideoClubManagement.UI.Article
{
    partial class ArticleForm
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
            this.actionPanel = new System.Windows.Forms.Panel();
            this.exportToCSVButton = new System.Windows.Forms.Button();
            this.articleToSearchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.articleDataGridViewPanel = new System.Windows.Forms.Panel();
            this.articleDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateReturnFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.rentPerDayLabel = new System.Windows.Forms.Label();
            this.lateReturnFeeLabel = new System.Windows.Forms.Label();
            this.articleIdLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.articleCreateDateLabel = new System.Windows.Forms.Label();
            this.articleLastUpdateDateLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.langaugeComboBox = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.rentPerDayTextBox = new System.Windows.Forms.TextBox();
            this.lateReturnFeeTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.lastUpdateDateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.articleManagementLabel = new System.Windows.Forms.Label();
            this.rentalDaysLabel = new System.Windows.Forms.Label();
            this.rentalDaystextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateReturnFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionPanel.SuspendLayout();
            this.articleDataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.actionPanel.Controls.Add(this.exportToCSVButton);
            this.actionPanel.Controls.Add(this.articleToSearchLabel);
            this.actionPanel.Controls.Add(this.searchButton);
            this.actionPanel.Controls.Add(this.searchTextBox);
            this.actionPanel.Location = new System.Drawing.Point(201, 12);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(642, 103);
            this.actionPanel.TabIndex = 0;
            // 
            // exportToCSVButton
            // 
            this.exportToCSVButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.csv;
            this.exportToCSVButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportToCSVButton.Location = new System.Drawing.Point(531, 20);
            this.exportToCSVButton.Name = "exportToCSVButton";
            this.exportToCSVButton.Size = new System.Drawing.Size(63, 55);
            this.exportToCSVButton.TabIndex = 27;
            this.exportToCSVButton.UseVisualStyleBackColor = false;
            this.exportToCSVButton.UseWaitCursor = true;
            this.exportToCSVButton.Click += new System.EventHandler(this.exportToCSVButton_Click);
            // 
            // articleToSearchLabel
            // 
            this.articleToSearchLabel.AutoSize = true;
            this.articleToSearchLabel.Location = new System.Drawing.Point(16, 42);
            this.articleToSearchLabel.Name = "articleToSearchLabel";
            this.articleToSearchLabel.Size = new System.Drawing.Size(88, 13);
            this.articleToSearchLabel.TabIndex = 1;
            this.articleToSearchLabel.Text = "Artículo a buscar";
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.baseline_search_black_24dp;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(421, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(63, 56);
            this.searchButton.TabIndex = 2;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(135, 39);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(264, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(313, 20);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(63, 56);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Retornar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // articleDataGridViewPanel
            // 
            this.articleDataGridViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.articleDataGridViewPanel.Controls.Add(this.articleDataGridView);
            this.articleDataGridViewPanel.Location = new System.Drawing.Point(12, 136);
            this.articleDataGridViewPanel.Name = "articleDataGridViewPanel";
            this.articleDataGridViewPanel.Size = new System.Drawing.Size(1046, 479);
            this.articleDataGridViewPanel.TabIndex = 1;
            // 
            // articleDataGridView
            // 
            this.articleDataGridView.AllowUserToAddRows = false;
            this.articleDataGridView.AllowUserToDeleteRows = false;
            this.articleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articleDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.articleTypeId,
            this.languageId,
            this.rentPerDay,
            this.rentalDays,
            this.lateReturnFee,
            this.isActive,
            this.createdDate,
            this.lastUpdatedDate});
            this.articleDataGridView.Location = new System.Drawing.Point(4, 4);
            this.articleDataGridView.Name = "articleDataGridView";
            this.articleDataGridView.ReadOnly = true;
            this.articleDataGridView.Size = new System.Drawing.Size(1035, 468);
            this.articleDataGridView.TabIndex = 0;
            this.articleDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.articleDataGridView_CellMouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Título";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // rentPerDay
            // 
            this.rentPerDay.DataPropertyName = "RentPerDay";
            this.rentPerDay.HeaderText = "Renta por día";
            this.rentPerDay.Name = "rentPerDay";
            this.rentPerDay.ReadOnly = true;
            // 
            // rentalDays
            // 
            this.rentalDays.DataPropertyName = "RentalDays";
            this.rentalDays.HeaderText = "Días de renta";
            this.rentalDays.Name = "rentalDays";
            this.rentalDays.ReadOnly = true;
            // 
            // lateReturnFee
            // 
            this.lateReturnFee.DataPropertyName = "LateReturnFee";
            this.lateReturnFee.HeaderText = "Penalidad";
            this.lateReturnFee.Name = "lateReturnFee";
            this.lateReturnFee.ReadOnly = true;
            // 
            // articleTypeId
            // 
            this.articleTypeId.DataPropertyName = "ArticleTypeId";
            this.articleTypeId.HeaderText = "Tipo de artículo";
            this.articleTypeId.Name = "articleTypeId";
            this.articleTypeId.ReadOnly = true;
            // 
            // languageId
            // 
            this.languageId.DataPropertyName = "LanguageId";
            this.languageId.HeaderText = "Idioma";
            this.languageId.Name = "languageId";
            this.languageId.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "IsActive";
            this.isActive.HeaderText = "Está Activo";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.lastUpdatedDate.HeaderText = "Fecha de modificación";
            this.lastUpdatedDate.Name = "lastUpdatedDate";
            this.lastUpdatedDate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1130, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1135, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(1135, 296);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(42, 13);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Género";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(1135, 347);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(38, 13);
            this.languageLabel.TabIndex = 5;
            this.languageLabel.Text = "Idioma";
            // 
            // rentPerDayLabel
            // 
            this.rentPerDayLabel.AutoSize = true;
            this.rentPerDayLabel.Location = new System.Drawing.Point(1134, 483);
            this.rentPerDayLabel.Name = "rentPerDayLabel";
            this.rentPerDayLabel.Size = new System.Drawing.Size(113, 13);
            this.rentPerDayLabel.TabIndex = 6;
            this.rentPerDayLabel.Text = "Costo de renta por día";
            // 
            // lateReturnFeeLabel
            // 
            this.lateReturnFeeLabel.AutoSize = true;
            this.lateReturnFeeLabel.Location = new System.Drawing.Point(1134, 525);
            this.lateReturnFeeLabel.Name = "lateReturnFeeLabel";
            this.lateReturnFeeLabel.Size = new System.Drawing.Size(142, 13);
            this.lateReturnFeeLabel.TabIndex = 7;
            this.lateReturnFeeLabel.Text = "Penalidad por entrega tardía";
            // 
            // articleIdLabel
            // 
            this.articleIdLabel.AutoSize = true;
            this.articleIdLabel.Location = new System.Drawing.Point(1130, 175);
            this.articleIdLabel.Name = "articleIdLabel";
            this.articleIdLabel.Size = new System.Drawing.Size(16, 13);
            this.articleIdLabel.TabIndex = 8;
            this.articleIdLabel.Text = "Id";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(1137, 396);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Estado";
            // 
            // articleCreateDateLabel
            // 
            this.articleCreateDateLabel.AutoSize = true;
            this.articleCreateDateLabel.Location = new System.Drawing.Point(1134, 560);
            this.articleCreateDateLabel.Name = "articleCreateDateLabel";
            this.articleCreateDateLabel.Size = new System.Drawing.Size(96, 13);
            this.articleCreateDateLabel.TabIndex = 10;
            this.articleCreateDateLabel.Text = "Fecha de creación";
            // 
            // articleLastUpdateDateLabel
            // 
            this.articleLastUpdateDateLabel.AutoSize = true;
            this.articleLastUpdateDateLabel.Location = new System.Drawing.Point(1134, 600);
            this.articleLastUpdateDateLabel.Name = "articleLastUpdateDateLabel";
            this.articleLastUpdateDateLabel.Size = new System.Drawing.Size(98, 13);
            this.articleLastUpdateDateLabel.TabIndex = 11;
            this.articleLastUpdateDateLabel.Text = "Ultima modificación";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(1287, 250);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 12;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Checked = true;
            this.statusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusCheckBox.Location = new System.Drawing.Point(1287, 392);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(80, 17);
            this.statusCheckBox.TabIndex = 13;
            this.statusCheckBox.Text = "Esta Activo";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // genreComboBox
            // 
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(1287, 296);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(121, 21);
            this.genreComboBox.TabIndex = 14;
            // 
            // langaugeComboBox
            // 
            this.langaugeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langaugeComboBox.FormattingEnabled = true;
            this.langaugeComboBox.Location = new System.Drawing.Point(1287, 344);
            this.langaugeComboBox.Name = "langaugeComboBox";
            this.langaugeComboBox.Size = new System.Drawing.Size(121, 21);
            this.langaugeComboBox.TabIndex = 15;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(1287, 207);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(174, 20);
            this.titleTextBox.TabIndex = 16;
            // 
            // rentPerDayTextBox
            // 
            this.rentPerDayTextBox.Location = new System.Drawing.Point(1287, 483);
            this.rentPerDayTextBox.Name = "rentPerDayTextBox";
            this.rentPerDayTextBox.Size = new System.Drawing.Size(121, 20);
            this.rentPerDayTextBox.TabIndex = 17;
            // 
            // lateReturnFeeTextBox
            // 
            this.lateReturnFeeTextBox.Location = new System.Drawing.Point(1287, 525);
            this.lateReturnFeeTextBox.Name = "lateReturnFeeTextBox";
            this.lateReturnFeeTextBox.Size = new System.Drawing.Size(121, 20);
            this.lateReturnFeeTextBox.TabIndex = 18;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(1287, 175);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(10, 13);
            this.idLabel.TabIndex = 19;
            this.idLabel.Text = "-";
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Location = new System.Drawing.Point(1290, 560);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(10, 13);
            this.createdDateLabel.TabIndex = 20;
            this.createdDateLabel.Text = "-";
            // 
            // lastUpdateDateLabel
            // 
            this.lastUpdateDateLabel.AutoSize = true;
            this.lastUpdateDateLabel.Location = new System.Drawing.Point(1287, 599);
            this.lastUpdateDateLabel.Name = "lastUpdateDateLabel";
            this.lastUpdateDateLabel.Size = new System.Drawing.Size(10, 13);
            this.lastUpdateDateLabel.TabIndex = 21;
            this.lastUpdateDateLabel.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(1056, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 100);
            this.panel1.TabIndex = 22;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.delete_black_24dp;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(220, 21);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 56);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.edit_black_24dp;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.Location = new System.Drawing.Point(126, 21);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(63, 56);
            this.updateButton.TabIndex = 4;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = global::VideoClubManagement.Properties.Resources.add_black_24dp;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(25, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 56);
            this.addButton.TabIndex = 3;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // articleManagementLabel
            // 
            this.articleManagementLabel.AutoSize = true;
            this.articleManagementLabel.Location = new System.Drawing.Point(1211, 142);
            this.articleManagementLabel.Name = "articleManagementLabel";
            this.articleManagementLabel.Size = new System.Drawing.Size(102, 13);
            this.articleManagementLabel.TabIndex = 23;
            this.articleManagementLabel.Text = "Gestión de artículos";
            // 
            // rentalDaysLabel
            // 
            this.rentalDaysLabel.AutoSize = true;
            this.rentalDaysLabel.Location = new System.Drawing.Point(1134, 445);
            this.rentalDaysLabel.Name = "rentalDaysLabel";
            this.rentalDaysLabel.Size = new System.Drawing.Size(72, 13);
            this.rentalDaysLabel.TabIndex = 24;
            this.rentalDaysLabel.Text = "Días de renta";
            // 
            // rentalDaystextBox
            // 
            this.rentalDaystextBox.Location = new System.Drawing.Point(1287, 442);
            this.rentalDaystextBox.Name = "rentalDaystextBox";
            this.rentalDaystextBox.Size = new System.Drawing.Size(121, 20);
            this.rentalDaystextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Artículos:";
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Título";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // articleTypeId
            // 
            this.articleTypeId.DataPropertyName = "ArticleTypeId";
            this.articleTypeId.HeaderText = "Tipo de artículo";
            this.articleTypeId.Name = "articleTypeId";
            this.articleTypeId.ReadOnly = true;
            // 
            // languageId
            // 
            this.languageId.DataPropertyName = "LanguageId";
            this.languageId.HeaderText = "Idioma";
            this.languageId.Name = "languageId";
            this.languageId.ReadOnly = true;
            // 
            // rentPerDay
            // 
            this.rentPerDay.DataPropertyName = "RentPerDay";
            this.rentPerDay.HeaderText = "Renta por día";
            this.rentPerDay.Name = "rentPerDay";
            this.rentPerDay.ReadOnly = true;
            // 
            // rentalDays
            // 
            this.rentalDays.DataPropertyName = "RentalDays";
            this.rentalDays.HeaderText = "Días de renta";
            this.rentalDays.Name = "rentalDays";
            this.rentalDays.ReadOnly = true;
            // 
            // lateReturnFee
            // 
            this.lateReturnFee.DataPropertyName = "LateReturnFee";
            this.lateReturnFee.HeaderText = "Penalidad";
            this.lateReturnFee.Name = "lateReturnFee";
            this.lateReturnFee.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "IsActive";
            this.isActive.HeaderText = "Está Activo";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.lastUpdatedDate.HeaderText = "Fecha de modificación";
            this.lastUpdatedDate.Name = "lastUpdatedDate";
            this.lastUpdatedDate.ReadOnly = true;
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 648);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rentalDaystextBox);
            this.Controls.Add(this.rentalDaysLabel);
            this.Controls.Add(this.articleManagementLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lastUpdateDateLabel);
            this.Controls.Add(this.createdDateLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.lateReturnFeeTextBox);
            this.Controls.Add(this.rentPerDayTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.langaugeComboBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.articleLastUpdateDateLabel);
            this.Controls.Add(this.articleCreateDateLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.articleIdLabel);
            this.Controls.Add(this.lateReturnFeeLabel);
            this.Controls.Add(this.rentPerDayLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.articleDataGridViewPanel);
            this.Controls.Add(this.actionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ArticleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver articulos";
            this.Load += new System.EventHandler(this.articleForm_Load);
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.articleDataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label articleToSearchLabel;
        private System.Windows.Forms.Panel articleDataGridViewPanel;
        private System.Windows.Forms.DataGridView articleDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label lateReturnFeeLabel;
        private System.Windows.Forms.Label articleIdLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label articleCreateDateLabel;
        private System.Windows.Forms.Label articleLastUpdateDateLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox langaugeComboBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox rentPerDayTextBox;
        private System.Windows.Forms.TextBox lateReturnFeeTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label createdDateLabel;
        private System.Windows.Forms.Label lastUpdateDateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label articleManagementLabel;
        private System.Windows.Forms.Label rentPerDayLabel;
        private System.Windows.Forms.Label rentalDaysLabel;
        private System.Windows.Forms.TextBox rentalDaystextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exportToCSVButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateReturnFee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDate;
    }
}