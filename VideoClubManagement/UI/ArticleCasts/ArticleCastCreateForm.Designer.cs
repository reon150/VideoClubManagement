
namespace VideoClubManagement.UI.ArticleCasts
{
    partial class ArticleCastCreateForm
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
            this.createArticleCastButton = new System.Windows.Forms.Button();
            this.backToListButton = new System.Windows.Forms.Button();
            this.castComboBox = new System.Windows.Forms.ComboBox();
            this.currentDateTimeLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.legalPersonTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.articleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createArticleCastButton
            // 
            this.createArticleCastButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createArticleCastButton.Image = global::VideoClubManagement.Properties.Resources.baseline_add_black_24dp;
            this.createArticleCastButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createArticleCastButton.Location = new System.Drawing.Point(513, 283);
            this.createArticleCastButton.Name = "createArticleCastButton";
            this.createArticleCastButton.Size = new System.Drawing.Size(262, 58);
            this.createArticleCastButton.TabIndex = 67;
            this.createArticleCastButton.Text = "Crear artículo - elenco";
            this.createArticleCastButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createArticleCastButton.UseVisualStyleBackColor = true;
            this.createArticleCastButton.Click += new System.EventHandler(this.createArticleCastButton_Click);
            // 
            // backToListButton
            // 
            this.backToListButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToListButton.Image = global::VideoClubManagement.Properties.Resources.baseline_list_black_24dp;
            this.backToListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backToListButton.Location = new System.Drawing.Point(49, 283);
            this.backToListButton.Name = "backToListButton";
            this.backToListButton.Size = new System.Drawing.Size(192, 58);
            this.backToListButton.TabIndex = 66;
            this.backToListButton.Text = "Volver a la lista";
            this.backToListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backToListButton.UseVisualStyleBackColor = true;
            this.backToListButton.Click += new System.EventHandler(this.backToListButton_Click);
            // 
            // castComboBox
            // 
            this.castComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.castComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.castComboBox.FormattingEnabled = true;
            this.castComboBox.Location = new System.Drawing.Point(123, 111);
            this.castComboBox.Name = "castComboBox";
            this.castComboBox.Size = new System.Drawing.Size(269, 33);
            this.castComboBox.TabIndex = 65;
            // 
            // currentDateTimeLabel
            // 
            this.currentDateTimeLabel.AutoSize = true;
            this.currentDateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateTimeLabel.Location = new System.Drawing.Point(508, 35);
            this.currentDateTimeLabel.Name = "currentDateTimeLabel";
            this.currentDateTimeLabel.Size = new System.Drawing.Size(0, 30);
            this.currentDateTimeLabel.TabIndex = 64;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Checked = true;
            this.isActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isActiveCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveCheckBox.Location = new System.Drawing.Point(554, 201);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isActiveCheckBox.TabIndex = 56;
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveLabel.Location = new System.Drawing.Point(443, 195);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(105, 25);
            this.isActiveLabel.TabIndex = 55;
            this.isActiveLabel.Text = "Esta activo";
            // 
            // legalPersonTypeLabel
            // 
            this.legalPersonTypeLabel.AutoSize = true;
            this.legalPersonTypeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legalPersonTypeLabel.Location = new System.Drawing.Point(47, 114);
            this.legalPersonTypeLabel.Name = "legalPersonTypeLabel";
            this.legalPersonTypeLabel.Size = new System.Drawing.Size(70, 25);
            this.legalPersonTypeLabel.TabIndex = 54;
            this.legalPersonTypeLabel.Text = "Elenco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 50;
            this.label1.Text = "Crear nuevo artículo - elenco";
            // 
            // roleComboBox
            // 
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(519, 111);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(269, 33);
            this.roleComboBox.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Rol";
            // 
            // articleComboBox
            // 
            this.articleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articleComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.articleComboBox.FormattingEnabled = true;
            this.articleComboBox.Location = new System.Drawing.Point(137, 192);
            this.articleComboBox.Name = "articleComboBox";
            this.articleComboBox.Size = new System.Drawing.Size(255, 33);
            this.articleComboBox.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Artículo";
            // 
            // ArticleCastCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.articleComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createArticleCastButton);
            this.Controls.Add(this.backToListButton);
            this.Controls.Add(this.castComboBox);
            this.Controls.Add(this.currentDateTimeLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.legalPersonTypeLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ArticleCastCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticleCastCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createArticleCastButton;
        private System.Windows.Forms.Button backToListButton;
        private System.Windows.Forms.ComboBox castComboBox;
        private System.Windows.Forms.Label currentDateTimeLabel;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.Label legalPersonTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox articleComboBox;
        private System.Windows.Forms.Label label3;
    }
}