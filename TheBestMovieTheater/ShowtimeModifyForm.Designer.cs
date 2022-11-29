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
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 279);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ShowtimeListView
            // 
            this.ShowtimeListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowtimeListView.FullRowSelect = true;
            this.ShowtimeListView.HideSelection = false;
            this.ShowtimeListView.Location = new System.Drawing.Point(0, 0);
            this.ShowtimeListView.Name = "ShowtimeListView";
            this.ShowtimeListView.Size = new System.Drawing.Size(244, 260);
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
            // ShowtimeModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(244, 323);
            this.ControlBox = false;
            this.Controls.Add(this.ShowtimeListView);
            this.Controls.Add(this.BackButton);
            this.Name = "ShowtimeModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowtimeModifyForm";
            this.Load += new System.EventHandler(this.ShowtimeModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ShowtimeListView;
        private TBMT_DBDataSetLocal tbmT_DBDataSetLocal;
        private TBMT_DBDataSetLocalTableAdapters.ShowtimeTableAdapter showtimeTableAdapter;
    }
}