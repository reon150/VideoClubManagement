
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
            this.backButton = new System.Windows.Forms.Button();
            this.articleToSearchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.articleDataGridViewPanel = new System.Windows.Forms.Panel();
            this.articleDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateReturnFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.articleManagementLabel = new System.Windows.Forms.Label();
            this.firstButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.currentPageTextBox = new System.Windows.Forms.TextBox();
            this.lastPageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rentalDaysLabel = new System.Windows.Forms.Label();
            this.rentalDaysTextBox = new System.Windows.Forms.TextBox();
            this.actionPanel.SuspendLayout();
            this.articleDataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.actionPanel.Controls.Add(this.backButton);
            this.actionPanel.Controls.Add(this.articleToSearchLabel);
            this.actionPanel.Controls.Add(this.searchButton);
            this.actionPanel.Controls.Add(this.searchTextBox);
            this.actionPanel.Location = new System.Drawing.Point(12, 12);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(642, 103);
            this.actionPanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(548, 20);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(63, 56);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Retornar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(421, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(63, 56);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Buscar";
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
            // addButton
            // 
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(25, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 56);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // articleDataGridViewPanel
            // 
            this.articleDataGridViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.articleDataGridViewPanel.Controls.Add(this.articleDataGridView);
            this.articleDataGridViewPanel.Location = new System.Drawing.Point(12, 136);
            this.articleDataGridViewPanel.Name = "articleDataGridViewPanel";
            this.articleDataGridViewPanel.Size = new System.Drawing.Size(642, 479);
            this.articleDataGridViewPanel.TabIndex = 1;
            // 
            // articleDataGridView
            // 
            this.articleDataGridView.AllowUserToAddRows = false;
            this.articleDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.articleType,
            this.Language,
            this.rentPerDay,
            this.rentalDays,
            this.lateReturnFee,
            this.isActive,
            this.createDate,
            this.lastUpdatedDate});
            this.articleDataGridView.Location = new System.Drawing.Point(4, 4);
            this.articleDataGridView.Name = "articleDataGridView";
            this.articleDataGridView.ReadOnly = true;
            this.articleDataGridView.Size = new System.Drawing.Size(631, 468);
            this.articleDataGridView.TabIndex = 0;
            this.articleDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.articleDataGridView_CellMouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 59;
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Título";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 59;
            // 
            // articleType
            // 
            this.articleType.DataPropertyName = "ArticleTypeId";
            this.articleType.HeaderText = "Tipo De Artículo";
            this.articleType.Name = "articleType";
            this.articleType.ReadOnly = true;
            this.articleType.Width = 58;
            // 
            // Language
            // 
            this.Language.DataPropertyName = "LanguageId";
            this.Language.HeaderText = "Idioma";
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            this.Language.Width = 59;
            // 
            // rentPerDay
            // 
            this.rentPerDay.DataPropertyName = "RentPerDay";
            this.rentPerDay.HeaderText = "Renta por día";
            this.rentPerDay.Name = "rentPerDay";
            this.rentPerDay.ReadOnly = true;
            this.rentPerDay.Width = 59;
            // 
            // rentalDays
            // 
            this.rentalDays.DataPropertyName = "RentalDays";
            this.rentalDays.HeaderText = "Días de renta ";
            this.rentalDays.Name = "rentalDays";
            this.rentalDays.ReadOnly = true;
            this.rentalDays.Width = 59;
            // 
            // lateReturnFee
            // 
            this.lateReturnFee.DataPropertyName = "LateReturnFee";
            this.lateReturnFee.HeaderText = "Penalidad ";
            this.lateReturnFee.Name = "lateReturnFee";
            this.lateReturnFee.ReadOnly = true;
            this.lateReturnFee.Width = 59;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "IsActive";
            this.isActive.HeaderText = "Activo";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isActive.Width = 58;
            // 
            // createDate
            // 
            this.createDate.DataPropertyName = "CreatedDate";
            this.createDate.HeaderText = "Fecha De Creación";
            this.createDate.Name = "createDate";
            this.createDate.ReadOnly = true;
            this.createDate.Width = 59;
            // 
            // lastUpdatedDate
            // 
            this.lastUpdatedDate.DataPropertyName = "LastUpdatedDate";
            this.lastUpdatedDate.HeaderText = "Ultima Fecha De Actualización";
            this.lastUpdatedDate.Name = "lastUpdatedDate";
            this.lastUpdatedDate.ReadOnly = true;
            this.lastUpdatedDate.Width = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(747, 325);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(42, 13);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Género";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(747, 373);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(38, 13);
            this.languageLabel.TabIndex = 5;
            this.languageLabel.Text = "Idioma";
            // 
            // rentPerDayLabel
            // 
            this.rentPerDayLabel.AutoSize = true;
            this.rentPerDayLabel.Location = new System.Drawing.Point(747, 456);
            this.rentPerDayLabel.Name = "rentPerDayLabel";
            this.rentPerDayLabel.Size = new System.Drawing.Size(113, 13);
            this.rentPerDayLabel.TabIndex = 6;
            this.rentPerDayLabel.Text = "Costo de renta por día";
            // 
            // lateReturnFeeLabel
            // 
            this.lateReturnFeeLabel.AutoSize = true;
            this.lateReturnFeeLabel.Location = new System.Drawing.Point(747, 490);
            this.lateReturnFeeLabel.Name = "lateReturnFeeLabel";
            this.lateReturnFeeLabel.Size = new System.Drawing.Size(142, 13);
            this.lateReturnFeeLabel.TabIndex = 7;
            this.lateReturnFeeLabel.Text = "Penalidad por entrega tardía";
            // 
            // articleIdLabel
            // 
            this.articleIdLabel.AutoSize = true;
            this.articleIdLabel.Location = new System.Drawing.Point(747, 184);
            this.articleIdLabel.Name = "articleIdLabel";
            this.articleIdLabel.Size = new System.Drawing.Size(16, 13);
            this.articleIdLabel.TabIndex = 8;
            this.articleIdLabel.Text = "Id";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(744, 535);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Estado";
            // 
            // articleCreateDateLabel
            // 
            this.articleCreateDateLabel.AutoSize = true;
            this.articleCreateDateLabel.Location = new System.Drawing.Point(744, 571);
            this.articleCreateDateLabel.Name = "articleCreateDateLabel";
            this.articleCreateDateLabel.Size = new System.Drawing.Size(96, 13);
            this.articleCreateDateLabel.TabIndex = 10;
            this.articleCreateDateLabel.Text = "Fecha de creación";
            // 
            // articleLastUpdateDateLabel
            // 
            this.articleLastUpdateDateLabel.AutoSize = true;
            this.articleLastUpdateDateLabel.Location = new System.Drawing.Point(744, 602);
            this.articleLastUpdateDateLabel.Name = "articleLastUpdateDateLabel";
            this.articleLastUpdateDateLabel.Size = new System.Drawing.Size(98, 13);
            this.articleLastUpdateDateLabel.TabIndex = 11;
            this.articleLastUpdateDateLabel.Text = "Ultima modificación";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(900, 275);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 12;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Checked = true;
            this.statusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusCheckBox.Location = new System.Drawing.Point(900, 531);
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
            this.genreComboBox.Location = new System.Drawing.Point(900, 322);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(121, 21);
            this.genreComboBox.TabIndex = 14;
            // 
            // langaugeComboBox
            // 
            this.langaugeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langaugeComboBox.FormattingEnabled = true;
            this.langaugeComboBox.Location = new System.Drawing.Point(900, 365);
            this.langaugeComboBox.Name = "langaugeComboBox";
            this.langaugeComboBox.Size = new System.Drawing.Size(121, 21);
            this.langaugeComboBox.TabIndex = 15;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(900, 226);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(174, 20);
            this.titleTextBox.TabIndex = 16;
            // 
            // rentPerDayTextBox
            // 
            this.rentPerDayTextBox.Location = new System.Drawing.Point(900, 449);
            this.rentPerDayTextBox.Name = "rentPerDayTextBox";
            this.rentPerDayTextBox.Size = new System.Drawing.Size(121, 20);
            this.rentPerDayTextBox.TabIndex = 17;
            // 
            // lateReturnFeeTextBox
            // 
            this.lateReturnFeeTextBox.Location = new System.Drawing.Point(900, 483);
            this.lateReturnFeeTextBox.Name = "lateReturnFeeTextBox";
            this.lateReturnFeeTextBox.Size = new System.Drawing.Size(121, 20);
            this.lateReturnFeeTextBox.TabIndex = 18;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(897, 183);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(10, 13);
            this.idLabel.TabIndex = 19;
            this.idLabel.Text = "-";
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Location = new System.Drawing.Point(897, 571);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(10, 13);
            this.createdDateLabel.TabIndex = 20;
            this.createdDateLabel.Text = "-";
            // 
            // lastUpdateDateLabel
            // 
            this.lastUpdateDateLabel.AutoSize = true;
            this.lastUpdateDateLabel.Location = new System.Drawing.Point(897, 602);
            this.lastUpdateDateLabel.Name = "lastUpdateDateLabel";
            this.lastUpdateDateLabel.Size = new System.Drawing.Size(10, 13);
            this.lastUpdateDateLabel.TabIndex = 21;
            this.lastUpdateDateLabel.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(687, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 100);
            this.panel1.TabIndex = 22;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(302, 21);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 56);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(169, 21);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(63, 56);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Actualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // articleManagementLabel
            // 
            this.articleManagementLabel.AutoSize = true;
            this.articleManagementLabel.Location = new System.Drawing.Point(858, 136);
            this.articleManagementLabel.Name = "articleManagementLabel";
            this.articleManagementLabel.Size = new System.Drawing.Size(102, 13);
            this.articleManagementLabel.TabIndex = 23;
            this.articleManagementLabel.Text = "Gestión de artículos";
            // 
            // firstButton
            // 
            this.firstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButton.Location = new System.Drawing.Point(43, 628);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(75, 23);
            this.firstButton.TabIndex = 24;
            this.firstButton.Text = "Primero";
            this.firstButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Location = new System.Drawing.Point(151, 628);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 25;
            this.previousButton.Text = "Anterior";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(402, 628);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 26;
            this.nextButton.Text = "Próximo";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // lastButton
            // 
            this.lastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastButton.Location = new System.Drawing.Point(507, 628);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(75, 23);
            this.lastButton.TabIndex = 27;
            this.lastButton.Text = "Ultimo";
            this.lastButton.UseVisualStyleBackColor = true;
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Location = new System.Drawing.Point(264, 631);
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(29, 20);
            this.currentPageTextBox.TabIndex = 28;
            // 
            // lastPageTextBox
            // 
            this.lastPageTextBox.Location = new System.Drawing.Point(324, 631);
            this.lastPageTextBox.Name = "lastPageTextBox";
            this.lastPageTextBox.Size = new System.Drawing.Size(29, 20);
            this.lastPageTextBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "/";
            // 
            // rentalDaysLabel
            // 
            this.rentalDaysLabel.AutoSize = true;
            this.rentalDaysLabel.Location = new System.Drawing.Point(747, 419);
            this.rentalDaysLabel.Name = "rentalDaysLabel";
            this.rentalDaysLabel.Size = new System.Drawing.Size(72, 13);
            this.rentalDaysLabel.TabIndex = 32;
            this.rentalDaysLabel.Text = "Días de renta";
            // 
            // rentalDaysTextBox
            // 
            this.rentalDaysTextBox.Location = new System.Drawing.Point(900, 412);
            this.rentalDaysTextBox.Name = "rentalDaysTextBox";
            this.rentalDaysTextBox.Size = new System.Drawing.Size(121, 20);
            this.rentalDaysTextBox.TabIndex = 33;
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 663);
            this.Controls.Add(this.rentalDaysTextBox);
            this.Controls.Add(this.rentalDaysLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastPageTextBox);
            this.Controls.Add(this.currentPageTextBox);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.firstButton);
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
            this.Name = "ArticleForm";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateReturnFee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDate;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.TextBox currentPageTextBox;
        private System.Windows.Forms.TextBox lastPageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rentalDaysLabel;
        private System.Windows.Forms.TextBox rentalDaysTextBox;
    }
}