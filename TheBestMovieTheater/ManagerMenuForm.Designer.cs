namespace TheBestMovieTheater
{
    partial class ManagerMenuForm
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
            this.MovieTheatreLabel = new System.Windows.Forms.Label();
            this.UserTitleLabel = new System.Windows.Forms.Label();
            this.consultGroupBox = new System.Windows.Forms.GroupBox();
            this.viewsComboBox = new System.Windows.Forms.ComboBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.consultLabel = new System.Windows.Forms.Label();
            this.modifyGroupBox = new System.Windows.Forms.GroupBox();
            this.modifyComboBox = new System.Windows.Forms.ComboBox();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.modifyLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.consultGroupBox.SuspendLayout();
            this.modifyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieTheatreLabel
            // 
            this.MovieTheatreLabel.AutoSize = true;
            this.MovieTheatreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTheatreLabel.Location = new System.Drawing.Point(98, 22);
            this.MovieTheatreLabel.Name = "MovieTheatreLabel";
            this.MovieTheatreLabel.Size = new System.Drawing.Size(325, 31);
            this.MovieTheatreLabel.TabIndex = 0;
            this.MovieTheatreLabel.Text = "The Best Movie Theater";
            this.MovieTheatreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTitleLabel
            // 
            this.UserTitleLabel.AutoSize = true;
            this.UserTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTitleLabel.Location = new System.Drawing.Point(189, 69);
            this.UserTitleLabel.Name = "UserTitleLabel";
            this.UserTitleLabel.Size = new System.Drawing.Size(141, 25);
            this.UserTitleLabel.TabIndex = 1;
            this.UserTitleLabel.Text = "Manager Page";
            this.UserTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consultGroupBox
            // 
            this.consultGroupBox.Controls.Add(this.viewsComboBox);
            this.consultGroupBox.Controls.Add(this.ViewButton);
            this.consultGroupBox.Controls.Add(this.consultLabel);
            this.consultGroupBox.Location = new System.Drawing.Point(12, 106);
            this.consultGroupBox.Name = "consultGroupBox";
            this.consultGroupBox.Size = new System.Drawing.Size(225, 165);
            this.consultGroupBox.TabIndex = 2;
            this.consultGroupBox.TabStop = false;
            // 
            // viewsComboBox
            // 
            this.viewsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewsComboBox.FormattingEnabled = true;
            this.viewsComboBox.Items.AddRange(new object[] {
            "Client List",
            "Ticket Sales"});
            this.viewsComboBox.Location = new System.Drawing.Point(17, 65);
            this.viewsComboBox.Name = "viewsComboBox";
            this.viewsComboBox.Size = new System.Drawing.Size(186, 24);
            this.viewsComboBox.TabIndex = 6;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(73, 102);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(81, 38);
            this.ViewButton.TabIndex = 5;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // consultLabel
            // 
            this.consultLabel.AutoSize = true;
            this.consultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultLabel.Location = new System.Drawing.Point(68, 18);
            this.consultLabel.Name = "consultLabel";
            this.consultLabel.Size = new System.Drawing.Size(86, 25);
            this.consultLabel.TabIndex = 4;
            this.consultLabel.Text = "Consult";
            this.consultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modifyGroupBox
            // 
            this.modifyGroupBox.Controls.Add(this.modifyComboBox);
            this.modifyGroupBox.Controls.Add(this.ModifyButton);
            this.modifyGroupBox.Controls.Add(this.modifyLabel);
            this.modifyGroupBox.Location = new System.Drawing.Point(243, 106);
            this.modifyGroupBox.Name = "modifyGroupBox";
            this.modifyGroupBox.Size = new System.Drawing.Size(270, 165);
            this.modifyGroupBox.TabIndex = 3;
            this.modifyGroupBox.TabStop = false;
            // 
            // modifyComboBox
            // 
            this.modifyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modifyComboBox.FormattingEnabled = true;
            this.modifyComboBox.Items.AddRange(new object[] {
            "Movies",
            "Screening Rooms",
            "Showtimes",
            "Prices"});
            this.modifyComboBox.Location = new System.Drawing.Point(49, 65);
            this.modifyComboBox.Name = "modifyComboBox";
            this.modifyComboBox.Size = new System.Drawing.Size(186, 24);
            this.modifyComboBox.TabIndex = 7;
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(91, 102);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(89, 38);
            this.ModifyButton.TabIndex = 4;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // modifyLabel
            // 
            this.modifyLabel.AutoSize = true;
            this.modifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyLabel.Location = new System.Drawing.Point(44, 18);
            this.modifyLabel.Name = "modifyLabel";
            this.modifyLabel.Size = new System.Drawing.Size(191, 25);
            this.modifyLabel.TabIndex = 7;
            this.modifyLabel.Text = "Add/Modify/Delete";
            this.modifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(418, 288);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 32);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ManagerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 332);
            this.ControlBox = false;
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.modifyGroupBox);
            this.Controls.Add(this.consultGroupBox);
            this.Controls.Add(this.UserTitleLabel);
            this.Controls.Add(this.MovieTheatreLabel);
            this.Name = "ManagerMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerMenuForm";
            this.consultGroupBox.ResumeLayout(false);
            this.consultGroupBox.PerformLayout();
            this.modifyGroupBox.ResumeLayout(false);
            this.modifyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieTheatreLabel;
        private System.Windows.Forms.Label UserTitleLabel;
        private System.Windows.Forms.GroupBox consultGroupBox;
        private System.Windows.Forms.GroupBox modifyGroupBox;
        private System.Windows.Forms.ComboBox viewsComboBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label consultLabel;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Label modifyLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.ComboBox modifyComboBox;
    }
}