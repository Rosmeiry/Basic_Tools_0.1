using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Text_Editor
{
    public partial class frmTxtEditor : Form
    {

        String Archivo;
        public frmTxtEditor()
        {
            InitializeComponent();
        }

        private void nuevoCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MytextBox1.Clear();
            Archivo = null;
        }

        private void abrirCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Texto|*.txt";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Archivo = OpenFile.FileName;
                using (StreamReader A = new StreamReader(Archivo))
                {
                    MytextBox1.Text = A.ReadToEnd();
                }

            }
        }

        private void guardarCtrlGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Texto|*.txt";
            if (Archivo != null)
            {
                using (StreamWriter G = new StreamWriter(Archivo))
                {
                    G.Write(MytextBox1.Text);
                }
            }
            else
            {
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    Archivo = SaveFile.FileName;
                    using (StreamWriter g = new StreamWriter(SaveFile.FileName))
                    {
                        g.Write(MytextBox1.Text);

                    }
                }


            }
        }

        private void salirAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void deshacerCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MytextBox1.Undo();
        }

        private void rehacerCtrlYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MytextBox1.Redo();
        }

        private void copiarCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MytextBox1.Copy();
        }

        private void cortarCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MytextBox1.Cut();
        }

        private void pegarCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MytextBox1.Paste();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MytextBox1.SelectAll();
        }

        private void eliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MytextBox1.Clear();
        }
        
        private void colorToolStripMenuItem_Click(object sender, EventArgs e, ColorDialog colorDialog)
        {
            DialogResult colores = colorDialog.ShowDialog();
            if (colores == DialogResult.OK)
            {
                MytextBox1.ForeColor = colorDialog.Color;
            }

        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fuente = new FontDialog();

            if (fuente.ShowDialog() == DialogResult.OK)
            {
                MytextBox1.Font = fuente.Font;
            }
        }

       
    }
}
