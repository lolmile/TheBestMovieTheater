namespace TheBestMovieTheater
{
    partial class ScreeningRoomModifyForm
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
            this.ScreeningRoomListView = new System.Windows.Forms.ListView();
            this.tbmT_DBDataSetLocal = new TheBestMovieTheater.TBMT_DBDataSetLocal();
            this.screeningRoomTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.ScreeningRoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 178);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ScreeningRoomListView
            // 
            this.ScreeningRoomListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScreeningRoomListView.FullRowSelect = true;
            this.ScreeningRoomListView.HideSelection = false;
            this.ScreeningRoomListView.Location = new System.Drawing.Point(0, 0);
            this.ScreeningRoomListView.Name = "ScreeningRoomListView";
            this.ScreeningRoomListView.Size = new System.Drawing.Size(303, 172);
            this.ScreeningRoomListView.TabIndex = 8;
            this.ScreeningRoomListView.UseCompatibleStateImageBehavior = false;
            this.ScreeningRoomListView.View = System.Windows.Forms.View.Details;
            // 
            // tbmT_DBDataSetLocal
            // 
            this.tbmT_DBDataSetLocal.DataSetName = "TBMT_DBDataSetLocal";
            this.tbmT_DBDataSetLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // screeningRoomTableAdapter
            // 
            this.screeningRoomTableAdapter.ClearBeforeFill = true;
            // 
            // ScreeningRoomModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 217);
            this.ControlBox = false;
            this.Controls.Add(this.ScreeningRoomListView);
            this.Controls.Add(this.BackButton);
            this.Name = "ScreeningRoomModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreeningRoomModifyForm";
            this.Load += new System.EventHandler(this.ScreeningRoomModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ScreeningRoomListView;
        private TBMT_DBDataSetLocal tbmT_DBDataSetLocal;
        private TBMT_DBDataSetLocalTableAdapters.ScreeningRoomTableAdapter screeningRoomTableAdapter;
    }
}