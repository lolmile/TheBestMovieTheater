namespace TheBestMovieTheater
{
    partial class ShowtimeModifyForm
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
            this.ShowtimeListView = new System.Windows.Forms.ListView();
            this.tbmT_DBDataSetLocal = new TheBestMovieTheater.TBMT_DBDataSetLocal();
            this.showtimeTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.ShowtimeTableAdapter();
            this.showtimeIdLabel = new System.Windows.Forms.Label();
            this.showtimeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(347, 232);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ShowtimeListView
            // 
            this.ShowtimeListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ShowtimeListView.FullRowSelect = true;
            this.ShowtimeListView.HideSelection = false;
            this.ShowtimeListView.Location = new System.Drawing.Point(0, 0);
            this.ShowtimeListView.Name = "ShowtimeListView";
            this.ShowtimeListView.Size = new System.Drawing.Size(244, 276);
            this.ShowtimeListView.TabIndex = 8;
            this.ShowtimeListView.UseCompatibleStateImageBehavior = false;
            this.ShowtimeListView.View = System.Windows.Forms.View.Details;
            // 
            // tbmT_DBDataSetLocal
            // 
            this.tbmT_DBDataSetLocal.DataSetName = "TBMT_DBDataSetLocal";
            this.tbmT_DBDataSetLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showtimeTableAdapter
            // 
            this.showtimeTableAdapter.ClearBeforeFill = true;
            // 
            // showtimeIdLabel
            // 
            this.showtimeIdLabel.AutoSize = true;
            this.showtimeIdLabel.Location = new System.Drawing.Point(299, 15);
            this.showtimeIdLabel.Name = "showtimeIdLabel";
            this.showtimeIdLabel.Size = new System.Drawing.Size(29, 16);
            this.showtimeIdLabel.TabIndex = 9;
            this.showtimeIdLabel.Text = "ID : ";
            // 
            // showtimeLabel
            // 
            this.showtimeLabel.AutoSize = true;
            this.showtimeLabel.Location = new System.Drawing.Point(254, 43);
            this.showtimeLabel.Name = "showtimeLabel";
            this.showtimeLabel.Size = new System.Drawing.Size(74, 16);
            this.showtimeLabel.TabIndex = 10;
            this.showtimeLabel.Text = "Showtime : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(85, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(334, 40);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 22);
            this.textBox2.TabIndex = 12;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(347, 156);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 70);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(253, 156);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 32);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(253, 194);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 32);
            this.ModifyButton.TabIndex = 15;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(253, 232);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 32);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(257, 73);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(96, 16);
            this.errorMessage.TabIndex = 17;
            this.errorMessage.Text = "Error Message";
            this.errorMessage.Visible = false;
            // 
            // ShowtimeModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(431, 276);
            this.ControlBox = false;
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.showtimeLabel);
            this.Controls.Add(this.showtimeIdLabel);
            this.Controls.Add(this.ShowtimeListView);
            this.Controls.Add(this.BackButton);
            this.Name = "ShowtimeModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowtimeModifyForm";
            this.Load += new System.EventHandler(this.ShowtimeModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ShowtimeListView;
        private TBMT_DBDataSetLocal tbmT_DBDataSetLocal;
        private TBMT_DBDataSetLocalTableAdapters.ShowtimeTableAdapter showtimeTableAdapter;
        private System.Windows.Forms.Label showtimeIdLabel;
        private System.Windows.Forms.Label showtimeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label errorMessage;
    }
}