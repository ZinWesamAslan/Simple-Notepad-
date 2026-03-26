using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notePad
{
    public partial class FrmProgressBar : Form
    {
        public FrmProgressBar()
        {
            InitializeComponent();
            
        }

        private void TimerProgressBar_Tick(object sender, EventArgs e)
        {
            pnlProgressBar.Width += 5;
            if(pnlProgressBar.Width ==445)
            {
                TimerProgressBar.Stop();
                this.Close();
            }
        }

        private void FrmProgressBar_Load(object sender, EventArgs e)
        {
            TimerProgressBar.Start();
        }
    }
}
