using Color_Palette;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Text_Editor;

namespace Basic_Tools
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnTextEditor_Click(object sender, EventArgs e)
        {
            frmTxtEditor frm = new frmTxtEditor();
            frm.Show(); 
        }

        private void btnCPalette_Click(object sender, EventArgs e)
        {
            frmPaleta frm = new frmPaleta();
            frm.Show();
        }
    }
}
