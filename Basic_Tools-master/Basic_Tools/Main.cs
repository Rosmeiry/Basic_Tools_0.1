
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
using ColorPalette;

namespace Basic_Tools
{
    public partial class frmMain : Form
    {
        public frmMain()
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
            FrmPaleta frm = new FrmPaleta();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
