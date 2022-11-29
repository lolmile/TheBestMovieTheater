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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.movieIDTextBox = new System.Windows.Forms.TextBox();
            this.movieYearTextBox = new System.Windows.Forms.TextBox();
            this.movieLengthTextBox = new System.Windows.Forms.TextBox();
            this.movieGenreTextBox = new System.Windows.Forms.TextBox();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.screeningTimeLabel = new System.Windows.Forms.Label();
            this.movieYearLabel = new System.Windows.Forms.Label();
            this.movieLengthLabel = new System.Windows.Forms.Label();
            this.movieGenreLabel = new System.Windows.Forms.Label();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.movieIDLabel = new System.Windows.Forms.Label();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(924, 60);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 5;
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
            this.MovieListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovieListView.FullRowSelect = true;
            this.MovieListView.HideSelection = false;
            this.MovieListView.Location = new System.Drawing.Point(0, 0);
            this.MovieListView.MultiSelect = false;
            this.MovieListView.Name = "MovieListView";
            this.MovieListView.Size = new System.Drawing.Size(1039, 172);
            this.MovieListView.TabIndex = 7;
            this.MovieListView.UseCompatibleStateImageBehavior = false;
            this.MovieListView.View = System.Windows.Forms.View.Details;
            this.MovieListView.SelectedIndexChanged += new System.EventHandler(this.MovieListView_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(813, 18);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 32);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.movieIDTextBox);
            this.groupBox1.Controls.Add(this.movieYearTextBox);
            this.groupBox1.Controls.Add(this.BackButton);
            this.groupBox1.Controls.Add(this.movieLengthTextBox);
            this.groupBox1.Controls.Add(this.movieGenreTextBox);
            this.groupBox1.Controls.Add(this.movieTitleTextBox);
            this.groupBox1.Controls.Add(this.endDateTimePicker);
            this.groupBox1.Controls.Add(this.startDateTimePicker);
            this.groupBox1.Controls.Add(this.toLabel);
            this.groupBox1.Controls.Add(this.fromLabel);
            this.groupBox1.Controls.Add(this.screeningTimeLabel);
            this.groupBox1.Controls.Add(this.movieYearLabel);
            this.groupBox1.Controls.Add(this.movieLengthLabel);
            this.groupBox1.Controls.Add(this.movieGenreLabel);
            this.groupBox1.Controls.Add(this.movieTitleLabel);
            this.groupBox1.Controls.Add(this.movieIDLabel);
            this.groupBox1.Controls.Add(this.ModifyButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 108);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // movieIDTextBox
            // 
            this.movieIDTextBox.Location = new System.Drawing.Point(104, 28);
            this.movieIDTextBox.Name = "movieIDTextBox";
            this.movieIDTextBox.ReadOnly = true;
            this.movieIDTextBox.Size = new System.Drawing.Size(56, 22);
            this.movieIDTextBox.TabIndex = 25;
            this.movieIDTextBox.TabStop = false;
            // 
            // movieYearTextBox
            // 
            this.movieYearTextBox.Location = new System.Drawing.Point(245, 62);
            this.movieYearTextBox.Name = "movieYearTextBox";
            this.movieYearTextBox.Size = new System.Drawing.Size(56, 22);
            this.movieYearTextBox.TabIndex = 24;
            // 
            // movieLengthTextBox
            // 
            this.movieLengthTextBox.Location = new System.Drawing.Point(104, 62);
            this.movieLengthTextBox.Name = "movieLengthTextBox";
            this.movieLengthTextBox.Size = new System.Drawing.Size(56, 22);
            this.movieLengthTextBox.TabIndex = 23;
            // 
            // movieGenreTextBox
            // 
            this.movieGenreTextBox.Location = new System.Drawing.Point(570, 26);
            this.movieGenreTextBox.Name = "movieGenreTextBox";
            this.movieGenreTextBox.Size = new System.Drawing.Size(204, 22);
            this.movieGenreTextBox.TabIndex = 22;
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.Location = new System.Drawing.Point(245, 28);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(204, 22);
            this.movieTitleTextBox.TabIndex = 21;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(664, 60);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.endDateTimePicker.TabIndex = 20;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(522, 60);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.startDateTimePicker.TabIndex = 19;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(637, 63);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(21, 18);
            this.toLabel.TabIndex = 18;
            this.toLabel.Text = "to";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(472, 63);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 18);
            this.fromLabel.TabIndex = 17;
            this.fromLabel.Text = "From";
            // 
            // screeningTimeLabel
            // 
            this.screeningTimeLabel.AutoSize = true;
            this.screeningTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screeningTimeLabel.Location = new System.Drawing.Point(347, 63);
            this.screeningTimeLabel.Name = "screeningTimeLabel";
            this.screeningTimeLabel.Size = new System.Drawing.Size(119, 18);
            this.screeningTimeLabel.TabIndex = 16;
            this.screeningTimeLabel.Text = "Screening Time :";
            // 
            // movieYearLabel
            // 
            this.movieYearLabel.AutoSize = true;
            this.movieYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieYearLabel.Location = new System.Drawing.Point(193, 62);
            this.movieYearLabel.Name = "movieYearLabel";
            this.movieYearLabel.Size = new System.Drawing.Size(46, 18);
            this.movieYearLabel.TabIndex = 15;
            this.movieYearLabel.Text = "Year :";
            // 
            // movieLengthLabel
            // 
            this.movieLengthLabel.AutoSize = true;
            this.movieLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLengthLabel.Location = new System.Drawing.Point(30, 63);
            this.movieLengthLabel.Name = "movieLengthLabel";
            this.movieLengthLabel.Size = new System.Drawing.Size(68, 18);
            this.movieLengthLabel.TabIndex = 14;
            this.movieLengthLabel.Text = "Minutes :";
            // 
            // movieGenreLabel
            // 
            this.movieGenreLabel.AutoSize = true;
            this.movieGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieGenreLabel.Location = new System.Drawing.Point(507, 29);
            this.movieGenreLabel.Name = "movieGenreLabel";
            this.movieGenreLabel.Size = new System.Drawing.Size(57, 18);
            this.movieGenreLabel.TabIndex = 13;
            this.movieGenreLabel.Text = "Genre :";
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleLabel.Location = new System.Drawing.Point(196, 29);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(43, 18);
            this.movieTitleLabel.TabIndex = 12;
            this.movieTitleLabel.Text = "Title :";
            // 
            // movieIDLabel
            // 
            this.movieIDLabel.AutoSize = true;
            this.movieIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieIDLabel.Location = new System.Drawing.Point(30, 29);
            this.movieIDLabel.Name = "movieIDLabel";
            this.movieIDLabel.Size = new System.Drawing.Size(30, 18);
            this.movieIDLabel.TabIndex = 11;
            this.movieIDLabel.Text = "ID :";
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(924, 18);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 32);
            this.ModifyButton.TabIndex = 9;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(813, 62);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 32);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // MovieModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 299);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MovieListView);
            this.Name = "MovieModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieModifyForm";
            this.Load += new System.EventHandler(this.MovieModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private TBMT_DBDataSetLocal tbmT_DBDataSetLocal;
        private TBMT_DBDataSetLocalTableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.ListView MovieListView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label screeningTimeLabel;
        private System.Windows.Forms.Label movieYearLabel;
        private System.Windows.Forms.Label movieLengthLabel;
        private System.Windows.Forms.Label movieGenreLabel;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label movieIDLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox movieIDTextBox;
        private System.Windows.Forms.TextBox movieYearTextBox;
        private System.Windows.Forms.TextBox movieLengthTextBox;
        private System.Windows.Forms.TextBox movieGenreTextBox;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
    }
}