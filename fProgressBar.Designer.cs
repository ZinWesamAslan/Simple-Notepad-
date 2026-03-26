namespace notePad
{
    partial class FrmProgressBar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgressBar));
            this.pnlProgressBar = new System.Windows.Forms.Panel();
            this.pbProgressBarPicture = new System.Windows.Forms.PictureBox();
            this.TimerProgressBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgressBarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProgressBar
            // 
            this.pnlProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlProgressBar.Location = new System.Drawing.Point(0, 254);
            this.pnlProgressBar.Name = "pnlProgressBar";
            this.pnlProgressBar.Size = new System.Drawing.Size(10, 10);
            this.pnlProgressBar.TabIndex = 0;
            // 
            // pbProgressBarPicture
            // 
            this.pbProgressBarPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbProgressBarPicture.Image")));
            this.pbProgressBarPicture.Location = new System.Drawing.Point(59, 12);
            this.pbProgressBarPicture.Name = "pbProgressBarPicture";
            this.pbProgressBarPicture.Size = new System.Drawing.Size(326, 214);
            this.pbProgressBarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProgressBarPicture.TabIndex = 1;
            this.pbProgressBarPicture.TabStop = false;
            // 
            // TimerProgressBar
            // 
            this.TimerProgressBar.Interval = 10;
            this.TimerProgressBar.Tick += new System.EventHandler(this.TimerProgressBar_Tick);
            // 
            // FrmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(445, 264);
            this.Controls.Add(this.pbProgressBarPicture);
            this.Controls.Add(this.pnlProgressBar);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBarNotePad";
            this.Load += new System.EventHandler(this.FrmProgressBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgressBarPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProgressBar;
        private System.Windows.Forms.PictureBox pbProgressBarPicture;
        private System.Windows.Forms.Timer TimerProgressBar;
    }
}

