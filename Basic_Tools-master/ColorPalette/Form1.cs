using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPalette
{
    public partial class FrmPaleta : Form
    {
        public FrmPaleta()
        {
            InitializeComponent();
        }

        private FrmPaleta GetFrmPaleta(FrmPaleta frmPaleta)
        {
            return frmPaleta;
        }

        ColorDialog color = new ColorDialog();
        public ColorDialog ColorDialog;

        private void btnPaleta_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fondo.BackColor = color.Color;
            }
        }

     
    }
}
