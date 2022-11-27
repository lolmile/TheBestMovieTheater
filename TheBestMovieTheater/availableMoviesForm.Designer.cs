namespace TheBestMovieTheater
{
    partial class availableMoviesForm
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
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.MovieTheatreLabel = new System.Windows.Forms.Label();
            this.UserTitleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.ItemHeight = 16;
            this.movieListBox.Location = new System.Drawing.Point(138, 78);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(354, 404);
            this.movieListBox.TabIndex = 0;
            // 
            // MovieTheatreLabel
            // 
            this.MovieTheatreLabel.AutoSize = true;
            this.MovieTheatreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTheatreLabel.Location = new System.Drawing.Point(152, 10);
            this.MovieTheatreLabel.Name = "MovieTheatreLabel";
            this.MovieTheatreLabel.Size = new System.Drawing.Size(325, 31);
            this.MovieTheatreLabel.TabIndex = 2;
            this.MovieTheatreLabel.Text = "The Best Movie Theater";
            this.MovieTheatreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTitleLabel
            // 
            this.UserTitleLabel.AutoSize = true;
            this.UserTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTitleLabel.Location = new System.Drawing.Point(237, 50);
            this.UserTitleLabel.Name = "UserTitleLabel";
            this.UserTitleLabel.Size = new System.Drawing.Size(160, 25);
            this.UserTitleLabel.TabIndex = 6;
            this.UserTitleLabel.Text = "Available Movies";
            this.UserTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(272, 522);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(172, 485);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(271, 16);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Double click on a row to select a ticket to buy";
            // 
            // availableMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 560);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.UserTitleLabel);
            this.Controls.Add(this.MovieTheatreLabel);
            this.Controls.Add(this.movieListBox);
            this.Name = "availableMoviesForm";
            this.Text = "availableMoviesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.Label MovieTheatreLabel;
        private System.Windows.Forms.Label UserTitleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label infoLabel;
    }
}