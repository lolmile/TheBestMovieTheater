namespace TheBestMovieTheater
{
    partial class UpcomingMoviesForm
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
            this.upcomingMoviesTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.MovieTableAdapter();
            this.upcomingMovieListView = new System.Windows.Forms.ListView();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MovieTheatreLabel
            // 
            this.MovieTheatreLabel.AutoSize = true;
            this.MovieTheatreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTheatreLabel.Location = new System.Drawing.Point(190, 9);
            this.MovieTheatreLabel.Name = "MovieTheatreLabel";
            this.MovieTheatreLabel.Size = new System.Drawing.Size(325, 31);
            this.MovieTheatreLabel.TabIndex = 3;
            this.MovieTheatreLabel.Text = "The Best Movie Theater";
            this.MovieTheatreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTitleLabel
            // 
            this.UserTitleLabel.AutoSize = true;
            this.UserTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTitleLabel.Location = new System.Drawing.Point(262, 50);
            this.UserTitleLabel.Name = "UserTitleLabel";
            this.UserTitleLabel.Size = new System.Drawing.Size(174, 25);
            this.UserTitleLabel.TabIndex = 7;
            this.UserTitleLabel.Text = "Upcoming Movies!";
            this.UserTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upcomingMoviesTableAdapter
            // 
            this.upcomingMoviesTableAdapter.ClearBeforeFill = true;
            // 
            // upcomingMovieListView
            // 
            this.upcomingMovieListView.HideSelection = false;
            this.upcomingMovieListView.Location = new System.Drawing.Point(12, 101);
            this.upcomingMovieListView.Name = "upcomingMovieListView";
            this.upcomingMovieListView.Size = new System.Drawing.Size(673, 268);
            this.upcomingMovieListView.TabIndex = 8;
            this.upcomingMovieListView.UseCompatibleStateImageBehavior = false;
            this.upcomingMovieListView.View = System.Windows.Forms.View.Details;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(301, 399);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // UpcomingMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 453);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.upcomingMovieListView);
            this.Controls.Add(this.UserTitleLabel);
            this.Controls.Add(this.MovieTheatreLabel);
            this.Name = "UpcomingMoviesForm";
            this.Text = "UpcomingMoviesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieTheatreLabel;
        private System.Windows.Forms.Label UserTitleLabel;
        private TBMT_DBDataSetLocalTableAdapters.MovieTableAdapter upcomingMoviesTableAdapter;
        private System.Windows.Forms.ListView upcomingMovieListView;
        private System.Windows.Forms.Button backButton;
    }
}