namespace notePad
{
    partial class FrmNoteBad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoteBad));
            this.MainText = new System.Windows.Forms.TextBox();
            this.NotePadMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFileLine = new System.Windows.Forms.ToolStripSeparator();
            this.toolFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolEditSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditDateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFormatFonts = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTextFonts = new System.Windows.Forms.FontDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.NotePadMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainText
            // 
            this.MainText.BackColor = System.Drawing.Color.Black;
            this.MainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainText.Font = new System.Drawing.Font("Castellar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainText.ForeColor = System.Drawing.Color.White;
            this.MainText.Location = new System.Drawing.Point(0, 28);
            this.MainText.Multiline = true;
            this.MainText.Name = "MainText";
            this.MainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainText.Size = new System.Drawing.Size(800, 422);
            this.MainText.TabIndex = 0;
            this.MainText.TextChanged += new System.EventHandler(this.MainText_TextChanged);
            // 
            // NotePadMenuStrip
            // 
            this.NotePadMenuStrip.BackColor = System.Drawing.Color.Black;
            this.NotePadMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFile,
            this.toolEdit,
            this.toolFormat});
            this.NotePadMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.NotePadMenuStrip.Name = "NotePadMenuStrip";
            this.NotePadMenuStrip.Size = new System.Drawing.Size(800, 28);
            this.NotePadMenuStrip.TabIndex = 1;
            this.NotePadMenuStrip.Text = "NotePadMenuStrip";
            // 
            // toolFile
            // 
            this.toolFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFileOpen,
            this.toolFileSave,
            this.toolFileSaveAs,
            this.toolFileLine,
            this.toolFileExit});
            this.toolFile.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolFile.ForeColor = System.Drawing.Color.Gray;
            this.toolFile.Name = "toolFile";
            this.toolFile.ShortcutKeyDisplayString = "";
            this.toolFile.Size = new System.Drawing.Size(57, 24);
            this.toolFile.Text = "&File";
            // 
            // toolFileOpen
            // 
            this.toolFileOpen.BackColor = System.Drawing.Color.Black;
            this.toolFileOpen.ForeColor = System.Drawing.Color.Gray;
            this.toolFileOpen.Name = "toolFileOpen";
            this.toolFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolFileOpen.Size = new System.Drawing.Size(240, 24);
            this.toolFileOpen.Text = "Open";
            this.toolFileOpen.Click += new System.EventHandler(this.toolFileOpen_Click);
            // 
            // toolFileSave
            // 
            this.toolFileSave.BackColor = System.Drawing.Color.Black;
            this.toolFileSave.ForeColor = System.Drawing.Color.Gray;
            this.toolFileSave.Name = "toolFileSave";
            this.toolFileSave.ShortcutKeyDisplayString = "";
            this.toolFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolFileSave.Size = new System.Drawing.Size(240, 24);
            this.toolFileSave.Text = "Save";
            this.toolFileSave.Click += new System.EventHandler(this.toolFileSave_Click);
            // 
            // toolFileSaveAs
            // 
            this.toolFileSaveAs.BackColor = System.Drawing.Color.Black;
            this.toolFileSaveAs.ForeColor = System.Drawing.Color.Gray;
            this.toolFileSaveAs.Name = "toolFileSaveAs";
            this.toolFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.toolFileSaveAs.Size = new System.Drawing.Size(240, 24);
            this.toolFileSaveAs.Text = "Save As";
            this.toolFileSaveAs.Click += new System.EventHandler(this.toolFileSaveAs_Click);
            // 
            // toolFileLine
            // 
            this.toolFileLine.BackColor = System.Drawing.Color.Black;
            this.toolFileLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolFileLine.Name = "toolFileLine";
            this.toolFileLine.Size = new System.Drawing.Size(237, 6);
            // 
            // toolFileExit
            // 
            this.toolFileExit.BackColor = System.Drawing.Color.Black;
            this.toolFileExit.ForeColor = System.Drawing.Color.Gray;
            this.toolFileExit.Name = "toolFileExit";
            this.toolFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolFileExit.Size = new System.Drawing.Size(240, 24);
            this.toolFileExit.Text = "Exit";
            this.toolFileExit.Click += new System.EventHandler(this.toolFileExit_Click);
            // 
            // toolEdit
            // 
            this.toolEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEditRedo,
            this.toolEditUndo,
            this.toolEditLine1,
            this.toolEditCut,
            this.toolEditCopy,
            this.toolEditPaste,
            this.toolEditDelete,
            this.toolEditLine2,
            this.toolEditSelect,
            this.toolEditDateTime});
            this.toolEdit.Font = new System.Drawing.Font("Cascadia Code", 11.25F);
            this.toolEdit.ForeColor = System.Drawing.Color.Gray;
            this.toolEdit.Name = "toolEdit";
            this.toolEdit.Size = new System.Drawing.Size(57, 24);
            this.toolEdit.Text = "&Edit";
            // 
            // toolEditRedo
            // 
            this.toolEditRedo.BackColor = System.Drawing.Color.Black;
            this.toolEditRedo.ForeColor = System.Drawing.Color.Gray;
            this.toolEditRedo.Name = "toolEditRedo";
            this.toolEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolEditRedo.Size = new System.Drawing.Size(231, 24);
            this.toolEditRedo.Text = "Redo";
            this.toolEditRedo.Click += new System.EventHandler(this.toolEditRedo_Click);
            // 
            // toolEditUndo
            // 
            this.toolEditUndo.BackColor = System.Drawing.Color.Black;
            this.toolEditUndo.ForeColor = System.Drawing.Color.Gray;
            this.toolEditUndo.Name = "toolEditUndo";
            this.toolEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.toolEditUndo.Size = new System.Drawing.Size(231, 24);
            this.toolEditUndo.Text = "Undo";
            this.toolEditUndo.Click += new System.EventHandler(this.toolEditUndo_Click);
            // 
            // toolEditLine1
            // 
            this.toolEditLine1.BackColor = System.Drawing.Color.Black;
            this.toolEditLine1.ForeColor = System.Drawing.Color.Black;
            this.toolEditLine1.Name = "toolEditLine1";
            this.toolEditLine1.Size = new System.Drawing.Size(228, 6);
            // 
            // toolEditCut
            // 
            this.toolEditCut.BackColor = System.Drawing.Color.Black;
            this.toolEditCut.ForeColor = System.Drawing.Color.Gray;
            this.toolEditCut.Name = "toolEditCut";
            this.toolEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.toolEditCut.Size = new System.Drawing.Size(231, 24);
            this.toolEditCut.Text = "Cut";
            this.toolEditCut.Click += new System.EventHandler(this.toolEditCut_Click);
            // 
            // toolEditCopy
            // 
            this.toolEditCopy.BackColor = System.Drawing.Color.Black;
            this.toolEditCopy.ForeColor = System.Drawing.Color.Gray;
            this.toolEditCopy.Name = "toolEditCopy";
            this.toolEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolEditCopy.Size = new System.Drawing.Size(231, 24);
            this.toolEditCopy.Text = "Copy";
            this.toolEditCopy.Click += new System.EventHandler(this.toolEditCopy_Click);
            // 
            // toolEditPaste
            // 
            this.toolEditPaste.BackColor = System.Drawing.Color.Black;
            this.toolEditPaste.ForeColor = System.Drawing.Color.Gray;
            this.toolEditPaste.Name = "toolEditPaste";
            this.toolEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolEditPaste.Size = new System.Drawing.Size(231, 24);
            this.toolEditPaste.Text = "Paste";
            this.toolEditPaste.Click += new System.EventHandler(this.toolEditPaste_Click);
            // 
            // toolEditDelete
            // 
            this.toolEditDelete.BackColor = System.Drawing.Color.Black;
            this.toolEditDelete.ForeColor = System.Drawing.Color.Gray;
            this.toolEditDelete.Name = "toolEditDelete";
            this.toolEditDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.toolEditDelete.Size = new System.Drawing.Size(231, 24);
            this.toolEditDelete.Text = "Delete";
            this.toolEditDelete.Click += new System.EventHandler(this.toolEditDelete_Click);
            // 
            // toolEditLine2
            // 
            this.toolEditLine2.Name = "toolEditLine2";
            this.toolEditLine2.Size = new System.Drawing.Size(228, 6);
            // 
            // toolEditSelect
            // 
            this.toolEditSelect.BackColor = System.Drawing.Color.Black;
            this.toolEditSelect.ForeColor = System.Drawing.Color.Gray;
            this.toolEditSelect.Name = "toolEditSelect";
            this.toolEditSelect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolEditSelect.Size = new System.Drawing.Size(231, 24);
            this.toolEditSelect.Text = "Select All";
            this.toolEditSelect.Click += new System.EventHandler(this.toolEditSelect_Click);
            // 
            // toolEditDateTime
            // 
            this.toolEditDateTime.BackColor = System.Drawing.Color.Black;
            this.toolEditDateTime.ForeColor = System.Drawing.Color.Gray;
            this.toolEditDateTime.Name = "toolEditDateTime";
            this.toolEditDateTime.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolEditDateTime.Size = new System.Drawing.Size(231, 24);
            this.toolEditDateTime.Text = "Date/time";
            this.toolEditDateTime.Click += new System.EventHandler(this.toolEditDateTime_Click);
            // 
            // toolFormat
            // 
            this.toolFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFormatFonts});
            this.toolFormat.Font = new System.Drawing.Font("Cascadia Code", 11.25F);
            this.toolFormat.ForeColor = System.Drawing.Color.Gray;
            this.toolFormat.Name = "toolFormat";
            this.toolFormat.Size = new System.Drawing.Size(75, 24);
            this.toolFormat.Text = "F&ormat";
            // 
            // toolFormatFonts
            // 
            this.toolFormatFonts.BackColor = System.Drawing.Color.Black;
            this.toolFormatFonts.ForeColor = System.Drawing.Color.Gray;
            this.toolFormatFonts.Name = "toolFormatFonts";
            this.toolFormatFonts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.toolFormatFonts.Size = new System.Drawing.Size(186, 24);
            this.toolFormatFonts.Text = "Fonts";
            this.toolFormatFonts.Click += new System.EventHandler(this.toolFormatFonts_Click);
            // 
            // MainTextFonts
            // 
            this.MainTextFonts.Color = System.Drawing.Color.White;
            this.MainTextFonts.Apply += new System.EventHandler(this.MainTextFonts_Apply);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FrmNoteBad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.NotePadMenuStrip);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.NotePadMenuStrip;
            this.Name = "FrmNoteBad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotePad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNoteBad_Load);
            this.NotePadMenuStrip.ResumeLayout(false);
            this.NotePadMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainText;
        private System.Windows.Forms.MenuStrip NotePadMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolFile;
        private System.Windows.Forms.ToolStripMenuItem toolEdit;
        private System.Windows.Forms.ToolStripMenuItem toolFormat;
        private System.Windows.Forms.ToolStripMenuItem toolFileOpen;
        private System.Windows.Forms.ToolStripMenuItem toolFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolFileSave;
        private System.Windows.Forms.ToolStripSeparator toolFileLine;
        private System.Windows.Forms.ToolStripMenuItem toolFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolEditUndo;
        private System.Windows.Forms.ToolStripSeparator toolEditLine1;
        private System.Windows.Forms.ToolStripMenuItem toolEditCut;
        private System.Windows.Forms.ToolStripMenuItem toolEditCopy;
        private System.Windows.Forms.ToolStripMenuItem toolEditPaste;
        private System.Windows.Forms.ToolStripMenuItem toolEditDelete;
        private System.Windows.Forms.ToolStripSeparator toolEditLine2;
        private System.Windows.Forms.ToolStripMenuItem toolEditSelect;
        private System.Windows.Forms.ToolStripMenuItem toolEditDateTime;
        private System.Windows.Forms.ToolStripMenuItem toolFormatFonts;
        private System.Windows.Forms.FontDialog MainTextFonts;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem toolEditRedo;
    }
}