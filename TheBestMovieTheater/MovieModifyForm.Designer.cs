namespace TheBestMovieTheater
{
    partial class MovieModifyForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.tbmT_DBDataSetLocal = new TheBestMovieTheater.TBMT_DBDataSetLocal();
            this.movieTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.MovieTableAdapter();
            this.MovieListView = new System.Windows.Forms.ListView();
            this.AddButton = new System.Windows.Forms.Button();
            this.movieInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.movieIDTextBox = new System.Windows.Forms.TextBox();
            this.movieYearTextBox = new System.Windows.Forms.TextBox();
            this.movieLengthTextBox = new System.Windows.Forms.TextBox();
            this.movieGenreTextBox = new System.Windows.Forms.TextBox();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.movieYearLabel = new System.Windows.Forms.Label();
            this.movieLengthLabel = new System.Windows.Forms.Label();
            this.movieGenreLabel = new System.Windows.Forms.Label();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.movieIDLabel = new System.Windows.Forms.Label();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).BeginInit();
            this.movieInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(163, 377);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(124, 40);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tbmT_DBDataSetLocal
            // 
            this.tbmT_DBDataSetLocal.DataSetName = "TBMT_DBDataSetLocal";
            this.tbmT_DBDataSetLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // MovieListView
            // 
            this.MovieListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MovieListView.FullRowSelect = true;
            this.MovieListView.HideSelection = false;
            this.MovieListView.Location = new System.Drawing.Point(0, 0);
            this.MovieListView.MultiSelect = false;
            this.MovieListView.Name = "MovieListView";
            this.MovieListView.Size = new System.Drawing.Size(893, 446);
            this.MovieListView.TabIndex = 1;
            this.MovieListView.UseCompatibleStateImageBehavior = false;
            this.MovieListView.View = System.Windows.Forms.View.Details;
            this.MovieListView.SelectedIndexChanged += new System.EventHandler(this.MovieListView_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(33, 285);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 40);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // movieInfoGroupBox
            // 
            this.movieInfoGroupBox.Controls.Add(this.errorLabel);
            this.movieInfoGroupBox.Controls.Add(this.ClearButton);
            this.movieInfoGroupBox.Controls.Add(this.movieIDTextBox);
            this.movieInfoGroupBox.Controls.Add(this.movieYearTextBox);
            this.movieInfoGroupBox.Controls.Add(this.BackButton);
            this.movieInfoGroupBox.Controls.Add(this.movieLengthTextBox);
            this.movieInfoGroupBox.Controls.Add(this.movieGenreTextBox);
            this.movieInfoGroupBox.Controls.Add(this.movieTitleTextBox);
            this.movieInfoGroupBox.Controls.Add(this.endDateTimePicker);
            this.movieInfoGroupBox.Controls.Add(this.startDateTimePicker);
            this.movieInfoGroupBox.Controls.Add(this.endLabel);
            this.movieInfoGroupBox.Controls.Add(this.startLabel);
            this.movieInfoGroupBox.Controls.Add(this.movieYearLabel);
            this.movieInfoGroupBox.Controls.Add(this.movieLengthLabel);
            this.movieInfoGroupBox.Controls.Add(this.movieGenreLabel);
            this.movieInfoGroupBox.Controls.Add(this.movieTitleLabel);
            this.movieInfoGroupBox.Controls.Add(this.movieIDLabel);
            this.movieInfoGroupBox.Controls.Add(this.ModifyButton);
            this.movieInfoGroupBox.Controls.Add(this.AddButton);
            this.movieInfoGroupBox.Controls.Add(this.DeleteButton);
            this.movieInfoGroupBox.Location = new System.Drawing.Point(899, 0);
            this.movieInfoGroupBox.Name = "movieInfoGroupBox";
            this.movieInfoGroupBox.Size = new System.Drawing.Size(317, 434);
            this.movieInfoGroupBox.TabIndex = 9;
            this.movieInfoGroupBox.TabStop = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(8, 174);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(96, 16);
            this.errorLabel.TabIndex = 27;
            this.errorLabel.Text = "Error message";
            this.errorLabel.Visible = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(163, 285);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(124, 86);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // movieIDTextBox
            // 
            this.movieIDTextBox.Location = new System.Drawing.Point(82, 18);
            this.movieIDTextBox.Name = "movieIDTextBox";
            this.movieIDTextBox.ReadOnly = true;
            this.movieIDTextBox.Size = new System.Drawing.Size(56, 22);
            this.movieIDTextBox.TabIndex = 25;
            this.movieIDTextBox.TabStop = false;
            // 
            // movieYearTextBox
            // 
            this.movieYearTextBox.Location = new System.Drawing.Point(82, 139);
            this.movieYearTextBox.MaxLength = 4;
            this.movieYearTextBox.Name = "movieYearTextBox";
            this.movieYearTextBox.Size = new System.Drawing.Size(56, 22);
            this.movieYearTextBox.TabIndex = 5;
            // 
            // movieLengthTextBox
            // 
            this.movieLengthTextBox.Location = new System.Drawing.Point(82, 107);
            this.movieLengthTextBox.MaxLength = 3;
            this.movieLengthTextBox.Name = "movieLengthTextBox";
            this.movieLengthTextBox.Size = new System.Drawing.Size(56, 22);
            this.movieLengthTextBox.TabIndex = 4;
            // 
            // movieGenreTextBox
            // 
            this.movieGenreTextBox.Location = new System.Drawing.Point(82, 74);
            this.movieGenreTextBox.Name = "movieGenreTextBox";
            this.movieGenreTextBox.Size = new System.Drawing.Size(221, 22);
            this.movieGenreTextBox.TabIndex = 3;
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.Location = new System.Drawing.Point(82, 46);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(221, 22);
            this.movieTitleTextBox.TabIndex = 2;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(194, 139);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.endDateTimePicker.TabIndex = 7;
            this.endDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(194, 107);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.startDateTimePicker.TabIndex = 6;
            this.startDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(149, 140);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(34, 18);
            this.endLabel.TabIndex = 18;
            this.endLabel.Text = "End";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(144, 111);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(39, 18);
            this.startLabel.TabIndex = 17;
            this.startLabel.Text = "Start";
            // 
            // movieYearLabel
            // 
            this.movieYearLabel.AutoSize = true;
            this.movieYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieYearLabel.Location = new System.Drawing.Point(30, 139);
            this.movieYearLabel.Name = "movieYearLabel";
            this.movieYearLabel.Size = new System.Drawing.Size(46, 18);
            this.movieYearLabel.TabIndex = 15;
            this.movieYearLabel.Text = "Year :";
            // 
            // movieLengthLabel
            // 
            this.movieLengthLabel.AutoSize = true;
            this.movieLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLengthLabel.Location = new System.Drawing.Point(8, 108);
            this.movieLengthLabel.Name = "movieLengthLabel";
            this.movieLengthLabel.Size = new System.Drawing.Size(68, 18);
            this.movieLengthLabel.TabIndex = 14;
            this.movieLengthLabel.Text = "Minutes :";
            // 
            // movieGenreLabel
            // 
            this.movieGenreLabel.AutoSize = true;
            this.movieGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieGenreLabel.Location = new System.Drawing.Point(19, 74);
            this.movieGenreLabel.Name = "movieGenreLabel";
            this.movieGenreLabel.Size = new System.Drawing.Size(57, 18);
            this.movieGenreLabel.TabIndex = 13;
            this.movieGenreLabel.Text = "Genre :";
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleLabel.Location = new System.Drawing.Point(33, 47);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(43, 18);
            this.movieTitleLabel.TabIndex = 12;
            this.movieTitleLabel.Text = "Title :";
            // 
            // movieIDLabel
            // 
            this.movieIDLabel.AutoSize = true;
            this.movieIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieIDLabel.Location = new System.Drawing.Point(46, 19);
            this.movieIDLabel.Name = "movieIDLabel";
            this.movieIDLabel.Size = new System.Drawing.Size(30, 18);
            this.movieIDLabel.TabIndex = 11;
            this.movieIDLabel.Text = "ID :";
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(33, 331);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(124, 40);
            this.ModifyButton.TabIndex = 9;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(33, 377);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(124, 40);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MovieModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 446);
            this.ControlBox = false;
            this.Controls.Add(this.movieInfoGroupBox);
            this.Controls.Add(this.MovieListView);
            this.Name = "MovieModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieModifyForm";
            this.Load += new System.EventHandler(this.MovieModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).EndInit();
            this.movieInfoGroupBox.ResumeLayout(false);
            this.movieInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private TBMT_DBDataSetLocal tbmT_DBDataSetLocal;
        private TBMT_DBDataSetLocalTableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.ListView MovieListView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox movieInfoGroupBox;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label movieYearLabel;
        private System.Windows.Forms.Label movieLengthLabel;
        private System.Windows.Forms.Label movieGenreLabel;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label movieIDLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.TextBox movieIDTextBox;
        private System.Windows.Forms.TextBox movieYearTextBox;
        private System.Windows.Forms.TextBox movieLengthTextBox;
        private System.Windows.Forms.TextBox movieGenreTextBox;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label errorLabel;
    }
}