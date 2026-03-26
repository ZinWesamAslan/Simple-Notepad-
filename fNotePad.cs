using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace notePad
{
    public partial class FrmNoteBad : Form
    {
        public FrmNoteBad()
        {
            InitializeComponent();
        }

        private void FrmNoteBad_Load(object sender, EventArgs e)
        {
            FrmProgressBar frmProgressBar = new FrmProgressBar();
            frmProgressBar.ShowDialog();
            //MainText.Text = System.IO.File.ReadAllText(@"C:\Users\USER\Documents\The developer ASLAN\14 C# level 1\notePad\MainText.text");
        }

        private void toolFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolFormatFonts_Click(object sender, EventArgs e)
        {
            MainTextFonts.ShowColor = true;
            MainTextFonts.ShowApply = true;
            MainTextFonts.ShowEffects = true;
            MainTextFonts.ShowHelp = true;


            MainTextFonts.Font = MainText.Font;

            if (MainTextFonts.ShowDialog() == DialogResult.OK)
            {

                MainText.Font = MainTextFonts.Font;
                MainText.ForeColor = MainTextFonts.Color;
            }
        }

        private void toolFileSave_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\Users\USER\Documents\The developer ASLAN\14 C# level 1\notePad\MainText.text", MainText.Text);
            MessageBox.Show("Saved File Successfully");
        }

        private void toolFileSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = @"C:\";

            saveFileDialog.Title = "koko";

            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            saveFileDialog.FilterIndex = 2;


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, MainText.Text);
            }
        }

        private void toolFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\";

            openFileDialog.Title = "koko";

            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            openFileDialog.FilterIndex = 2;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MainText.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
            }
            
        }

        private void toolEditCut_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(MainText.SelectedText))
                {
                    MainText.Cut();
                }
        }

        private void toolEditCopy_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(MainText.SelectedText))
            {
                MainText.Copy();
            }
        }

        private void toolEditPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                MainText.Paste();
            }
        }

        private void toolEditSelect_Click(object sender, EventArgs e)
        {
                MainText.SelectAll();
        }


        private void toolEditDateTime_Click(object sender, EventArgs e)
        {

            
            MainText.Text += " " +DateTime.Now.ToString();
        }

        private void toolEditDelete_Click(object sender, EventArgs e)
        {
            MainText.Clear();
        }

        private Stack<string> undoStack = new Stack<string>();
        private Stack<string> redoStack = new Stack<string>();
        

        private void MainText_TextChanged(object sender, EventArgs e)
        {
            if(undoStack.Count == 0)
            {
                undoStack.Push(MainText.Text);
            }

            if (MainText.Text != undoStack.First())
            {
                undoStack.Push(MainText.Text);
            }
        }

        private void toolEditRedo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(redoStack.First());

                redoStack.Pop();

                MainText.Text = undoStack.First();
                
            }
        }

        private void toolEditUndo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(undoStack.First());
                undoStack.Pop();
                if (undoStack.Count > 0)
                { 
                    MainText.Text = undoStack.First();
                }
            }
        }

        private void MainTextFonts_Apply(object sender, EventArgs e)
        {
            MainText.Font = MainTextFonts.Font;
            MainText.ForeColor = MainTextFonts.Color;
        }
    }
}

