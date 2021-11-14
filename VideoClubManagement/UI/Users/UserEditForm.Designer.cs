namespace VideoClubManagement.UI.Users
{
    partial class UserEditForm
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
            this.backToListButton = new System.Windows.Forms.Button();
            this.userRoleComboBox = new System.Windows.Forms.ComboBox();
            this.currentDateTimeLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.identificationNumberTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.identificationNumberLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastUpdatedValueDateLabel = new System.Windows.Forms.Label();
            this.lastUpdatedDateLabel = new System.Windows.Forms.Label();
            this.createdDateValueLabel = new System.Windows.Forms.Label();
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.idValueLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.editUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToListButton
            // 
            this.backToListButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToListButton.Image = global::VideoClubManagement.Properties.Resources.baseline_list_black_24dp;
            this.backToListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backToListButton.Location = new System.Drawing.Point(97, 483);
            this.backToListButton.Name = "backToListButton";
            this.backToListButton.Size = new System.Drawing.Size(192, 58);
            this.backToListButton.TabIndex = 82;
            this.backToListButton.Text = "Volver a la lista";
            this.backToListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backToListButton.UseVisualStyleBackColor = true;
            this.backToListButton.Click += new System.EventHandler(this.backToListButton_Click);
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userRoleComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Location = new System.Drawing.Point(238, 380);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(199, 33);
            this.userRoleComboBox.TabIndex = 81;
            // 
            // currentDateTimeLabel
            // 
            this.currentDateTimeLabel.AutoSize = true;
            this.currentDateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateTimeLabel.Location = new System.Drawing.Point(609, 47);
            this.currentDateTimeLabel.Name = "currentDateTimeLabel";
            this.currentDateTimeLabel.Size = new System.Drawing.Size(0, 30);
            this.currentDateTimeLabel.TabIndex = 80;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(525, 307);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(280, 33);
            this.emailTextBox.TabIndex = 79;
            // 
            // identificationNumberTextBox
            // 
            this.identificationNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identificationNumberTextBox.Location = new System.Drawing.Point(171, 307);
            this.identificationNumberTextBox.Multiline = true;
            this.identificationNumberTextBox.Name = "identificationNumberTextBox";
            this.identificationNumberTextBox.Size = new System.Drawing.Size(266, 33);
            this.identificationNumberTextBox.TabIndex = 78;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(558, 234);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(247, 33);
            this.passwordTextBox.TabIndex = 77;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(199, 234);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(238, 33);
            this.usernameTextBox.TabIndex = 76;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(460, 237);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(97, 25);
            this.passwordLabel.TabIndex = 75;
            this.passwordLabel.Text = "Password";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Checked = true;
            this.isActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isActiveCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveCheckBox.Location = new System.Drawing.Point(571, 393);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isActiveCheckBox.TabIndex = 74;
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveLabel.Location = new System.Drawing.Point(460, 383);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(105, 25);
            this.isActiveLabel.TabIndex = 73;
            this.isActiveLabel.Text = "Esta activo";
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRoleLabel.Location = new System.Drawing.Point(92, 383);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(140, 25);
            this.userRoleLabel.TabIndex = 72;
            this.userRoleLabel.Text = "Rol de usuario";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(460, 310);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 25);
            this.emailLabel.TabIndex = 71;
            this.emailLabel.Text = "Email";
            // 
            // identificationNumberLabel
            // 
            this.identificationNumberLabel.AutoSize = true;
            this.identificationNumberLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identificationNumberLabel.Location = new System.Drawing.Point(92, 310);
            this.identificationNumberLabel.Name = "identificationNumberLabel";
            this.identificationNumberLabel.Size = new System.Drawing.Size(73, 25);
            this.identificationNumberLabel.TabIndex = 70;
            this.identificationNumberLabel.Text = "Cédula";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(92, 237);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(101, 25);
            this.usernameLabel.TabIndex = 69;
            this.usernameLabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 68;
            this.label1.Text = "Editar usuario";
            // 
            // lastUpdatedValueDateLabel
            // 
            this.lastUpdatedValueDateLabel.AutoSize = true;
            this.lastUpdatedValueDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdatedValueDateLabel.Location = new System.Drawing.Point(609, 164);
            this.lastUpdatedValueDateLabel.Name = "lastUpdatedValueDateLabel";
            this.lastUpdatedValueDateLabel.Size = new System.Drawing.Size(0, 25);
            this.lastUpdatedValueDateLabel.TabIndex = 89;
            // 
            // lastUpdatedDateLabel
            // 
            this.lastUpdatedDateLabel.AutoSize = true;
            this.lastUpdatedDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdatedDateLabel.Location = new System.Drawing.Point(460, 164);
            this.lastUpdatedDateLabel.Name = "lastUpdatedDateLabel";
            this.lastUpdatedDateLabel.Size = new System.Drawing.Size(143, 25);
            this.lastUpdatedDateLabel.TabIndex = 88;
            this.lastUpdatedDateLabel.Text = "Actualizado en";
            // 
            // createdDateValueLabel
            // 
            this.createdDateValueLabel.AutoSize = true;
            this.createdDateValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdDateValueLabel.Location = new System.Drawing.Point(215, 164);
            this.createdDateValueLabel.Name = "createdDateValueLabel";
            this.createdDateValueLabel.Size = new System.Drawing.Size(0, 25);
            this.createdDateValueLabel.TabIndex = 87;
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdDateLabel.Location = new System.Drawing.Point(92, 164);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(117, 25);
            this.createdDateLabel.TabIndex = 86;
            this.createdDateLabel.Text = "Creación en";
            // 
            // idValueLabel
            // 
            this.idValueLabel.AutoSize = true;
            this.idValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idValueLabel.Location = new System.Drawing.Point(421, 117);
            this.idValueLabel.Name = "idValueLabel";
            this.idValueLabel.Size = new System.Drawing.Size(0, 25);
            this.idValueLabel.TabIndex = 85;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(367, 117);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 25);
            this.idLabel.TabIndex = 84;
            this.idLabel.Text = "Id";
            // 
            // editUserButton
            // 
            this.editUserButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserButton.Image = global::VideoClubManagement.Properties.Resources.edit_black_24dp;
            this.editUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editUserButton.Location = new System.Drawing.Point(605, 483);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(200, 58);
            this.editUserButton.TabIndex = 90;
            this.editUserButton.Text = "Guardar edición";
            this.editUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editClientButton_Click);
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 586);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.lastUpdatedValueDateLabel);
            this.Controls.Add(this.lastUpdatedDateLabel);
            this.Controls.Add(this.createdDateValueLabel);
            this.Controls.Add(this.createdDateLabel);
            this.Controls.Add(this.idValueLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.backToListButton);
            this.Controls.Add(this.userRoleComboBox);
            this.Controls.Add(this.currentDateTimeLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.identificationNumberTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.userRoleLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.identificationNumberLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "UserEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backToListButton;
        private System.Windows.Forms.ComboBox userRoleComboBox;
        private System.Windows.Forms.Label currentDateTimeLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox identificationNumberTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.Label userRoleLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label identificationNumberLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lastUpdatedValueDateLabel;
        private System.Windows.Forms.Label lastUpdatedDateLabel;
        private System.Windows.Forms.Label createdDateValueLabel;
        private System.Windows.Forms.Label createdDateLabel;
        private System.Windows.Forms.Label idValueLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button editUserButton;
    }
}