
namespace VideoClubManagement.UI.ArticleLendings
{
    partial class ArticleLendingEditForm
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
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountPerDayTextBox = new System.Windows.Forms.TextBox();
            this.amountPerDayLabel = new System.Windows.Forms.Label();
            this.articleComboBox = new System.Windows.Forms.ComboBox();
            this.articleLabel = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.editClientButton = new System.Windows.Forms.Button();
            this.backToListButton = new System.Windows.Forms.Button();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.currentDateTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idValueLabel = new System.Windows.Forms.Label();
            this.createdDateValueLabel = new System.Windows.Forms.Label();
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.returnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.setReturnDateButton = new System.Windows.Forms.Button();
            this.resetReturnDateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commentTextBox
            // 
            this.commentTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentTextBox.Location = new System.Drawing.Point(149, 372);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(590, 184);
            this.commentTextBox.TabIndex = 83;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLabel.Location = new System.Drawing.Point(7, 372);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(117, 25);
            this.commentLabel.TabIndex = 82;
            this.commentLabel.Text = "Comentario";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(7, 161);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(203, 25);
            this.dueDateLabel.TabIndex = 81;
            this.dueDateLabel.Text = "Fecha de vencimiento";
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(212, 155);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(172, 33);
            this.dueDateDateTimePicker.TabIndex = 80;
            this.dueDateDateTimePicker.Value = new System.DateTime(2021, 10, 16, 0, 0, 0, 0);
            // 
            // amountPerDayTextBox
            // 
            this.amountPerDayTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPerDayTextBox.Location = new System.Drawing.Point(567, 298);
            this.amountPerDayTextBox.Multiline = true;
            this.amountPerDayTextBox.Name = "amountPerDayTextBox";
            this.amountPerDayTextBox.Size = new System.Drawing.Size(224, 33);
            this.amountPerDayTextBox.TabIndex = 79;
            this.amountPerDayTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountPerDayTextBox_KeyPress);
            // 
            // amountPerDayLabel
            // 
            this.amountPerDayLabel.AutoSize = true;
            this.amountPerDayLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPerDayLabel.Location = new System.Drawing.Point(424, 301);
            this.amountPerDayLabel.Name = "amountPerDayLabel";
            this.amountPerDayLabel.Size = new System.Drawing.Size(142, 25);
            this.amountPerDayLabel.TabIndex = 78;
            this.amountPerDayLabel.Text = "Monto por día";
            // 
            // articleComboBox
            // 
            this.articleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articleComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.articleComboBox.FormattingEnabled = true;
            this.articleComboBox.Location = new System.Drawing.Point(97, 298);
            this.articleComboBox.Name = "articleComboBox";
            this.articleComboBox.Size = new System.Drawing.Size(287, 33);
            this.articleComboBox.TabIndex = 77;
            // 
            // articleLabel
            // 
            this.articleLabel.AutoSize = true;
            this.articleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleLabel.Location = new System.Drawing.Point(7, 301);
            this.articleLabel.Name = "articleLabel";
            this.articleLabel.Size = new System.Drawing.Size(84, 25);
            this.articleLabel.TabIndex = 76;
            this.articleLabel.Text = "Artículo";
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(504, 228);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(287, 33);
            this.clientComboBox.TabIndex = 75;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.Location = new System.Drawing.Point(425, 231);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(73, 25);
            this.clientLabel.TabIndex = 74;
            this.clientLabel.Text = "Cliente";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(109, 228);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(275, 33);
            this.employeeComboBox.TabIndex = 73;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.Location = new System.Drawing.Point(7, 231);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(100, 25);
            this.employeeLabel.TabIndex = 72;
            this.employeeLabel.Text = "Empleado";
            // 
            // editClientButton
            // 
            this.editClientButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientButton.Image = global::VideoClubManagement.Properties.Resources.baseline_add_black_24dp;
            this.editClientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editClientButton.Location = new System.Drawing.Point(511, 694);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(277, 58);
            this.editClientButton.TabIndex = 71;
            this.editClientButton.Text = "Editar Renta - Devolución";
            this.editClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editClientButton.UseVisualStyleBackColor = true;
            this.editClientButton.Click += new System.EventHandler(this.editClientButton_Click);
            // 
            // backToListButton
            // 
            this.backToListButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToListButton.Image = global::VideoClubManagement.Properties.Resources.baseline_list_black_24dp;
            this.backToListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backToListButton.Location = new System.Drawing.Point(12, 694);
            this.backToListButton.Name = "backToListButton";
            this.backToListButton.Size = new System.Drawing.Size(192, 58);
            this.backToListButton.TabIndex = 70;
            this.backToListButton.Text = "Volver a la lista";
            this.backToListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backToListButton.UseVisualStyleBackColor = true;
            this.backToListButton.Click += new System.EventHandler(this.backToListButton_Click);
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Checked = true;
            this.isActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isActiveCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveCheckBox.Location = new System.Drawing.Point(448, 595);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isActiveCheckBox.TabIndex = 69;
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveLabel.Location = new System.Drawing.Point(338, 589);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(105, 25);
            this.isActiveLabel.TabIndex = 68;
            this.isActiveLabel.Text = "Esta activo";
            // 
            // currentDateTimeLabel
            // 
            this.currentDateTimeLabel.AutoSize = true;
            this.currentDateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateTimeLabel.Location = new System.Drawing.Point(543, 18);
            this.currentDateTimeLabel.Name = "currentDateTimeLabel";
            this.currentDateTimeLabel.Size = new System.Drawing.Size(0, 30);
            this.currentDateTimeLabel.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 32);
            this.label1.TabIndex = 66;
            this.label1.Text = "Editar renta - Devolución";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(7, 91);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(100, 25);
            this.idLabel.TabIndex = 91;
            this.idLabel.Text = "No. Renta";
            // 
            // idValueLabel
            // 
            this.idValueLabel.AutoSize = true;
            this.idValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idValueLabel.Location = new System.Drawing.Point(107, 91);
            this.idValueLabel.Name = "idValueLabel";
            this.idValueLabel.Size = new System.Drawing.Size(0, 25);
            this.idValueLabel.TabIndex = 90;
            // 
            // createdDateValueLabel
            // 
            this.createdDateValueLabel.AutoSize = true;
            this.createdDateValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdDateValueLabel.Location = new System.Drawing.Point(566, 91);
            this.createdDateValueLabel.Name = "createdDateValueLabel";
            this.createdDateValueLabel.Size = new System.Drawing.Size(0, 25);
            this.createdDateValueLabel.TabIndex = 93;
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdDateLabel.Location = new System.Drawing.Point(425, 91);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(141, 25);
            this.createdDateLabel.TabIndex = 92;
            this.createdDateLabel.Text = "Fecha de renta";
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLabel.Location = new System.Drawing.Point(424, 161);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(193, 25);
            this.returnDateLabel.TabIndex = 95;
            this.returnDateLabel.Text = "Fecha de devolución";
            // 
            // returnDateDateTimePicker
            // 
            this.returnDateDateTimePicker.CustomFormat = " ";
            this.returnDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.returnDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnDateDateTimePicker.Location = new System.Drawing.Point(623, 155);
            this.returnDateDateTimePicker.Name = "returnDateDateTimePicker";
            this.returnDateDateTimePicker.Size = new System.Drawing.Size(165, 33);
            this.returnDateDateTimePicker.TabIndex = 94;
            this.returnDateDateTimePicker.Value = new System.DateTime(2021, 10, 16, 0, 0, 0, 0);
            // 
            // setReturnDateButton
            // 
            this.setReturnDateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setReturnDateButton.Location = new System.Drawing.Point(613, 627);
            this.setReturnDateButton.Name = "setReturnDateButton";
            this.setReturnDateButton.Size = new System.Drawing.Size(175, 35);
            this.setReturnDateButton.TabIndex = 96;
            this.setReturnDateButton.Text = "Poner fecha de devolución";
            this.setReturnDateButton.UseVisualStyleBackColor = true;
            this.setReturnDateButton.Click += new System.EventHandler(this.setReturnDateButton_Click);
            // 
            // resetReturnDateButton
            // 
            this.resetReturnDateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetReturnDateButton.Location = new System.Drawing.Point(12, 627);
            this.resetReturnDateButton.Name = "resetReturnDateButton";
            this.resetReturnDateButton.Size = new System.Drawing.Size(192, 35);
            this.resetReturnDateButton.TabIndex = 97;
            this.resetReturnDateButton.Text = "Resetar fecha de devolución";
            this.resetReturnDateButton.UseVisualStyleBackColor = true;
            this.resetReturnDateButton.Click += new System.EventHandler(this.resetReturnDateButton_Click);
            // 
            // ArticleLendingEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 764);
            this.Controls.Add(this.resetReturnDateButton);
            this.Controls.Add(this.setReturnDateButton);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.returnDateDateTimePicker);
            this.Controls.Add(this.createdDateValueLabel);
            this.Controls.Add(this.createdDateLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idValueLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.dueDateDateTimePicker);
            this.Controls.Add(this.amountPerDayTextBox);
            this.Controls.Add(this.amountPerDayLabel);
            this.Controls.Add(this.articleComboBox);
            this.Controls.Add(this.articleLabel);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.editClientButton);
            this.Controls.Add(this.backToListButton);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.currentDateTimeLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ArticleLendingEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Renta - Devolución";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private System.Windows.Forms.TextBox amountPerDayTextBox;
        private System.Windows.Forms.Label amountPerDayLabel;
        private System.Windows.Forms.ComboBox articleComboBox;
        private System.Windows.Forms.Label articleLabel;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button editClientButton;
        private System.Windows.Forms.Button backToListButton;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.Label currentDateTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label idValueLabel;
        private System.Windows.Forms.Label createdDateValueLabel;
        private System.Windows.Forms.Label createdDateLabel;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.DateTimePicker returnDateDateTimePicker;
        private System.Windows.Forms.Button setReturnDateButton;
        private System.Windows.Forms.Button resetReturnDateButton;
    }
}