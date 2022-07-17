namespace ColorPalette
{
    partial class FrmPaleta
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
            this.btnPaleta = new System.Windows.Forms.Button();
            this.fondo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaleta
            // 
            this.btnPaleta.Location = new System.Drawing.Point(148, 69);
            this.btnPaleta.Name = "btnPaleta";
            this.btnPaleta.Size = new System.Drawing.Size(75, 23);
            this.btnPaleta.TabIndex = 1;
            this.btnPaleta.Text = "Change";
            this.btnPaleta.UseVisualStyleBackColor = true;
            this.btnPaleta.Click += new System.EventHandler(this.btnPaleta_Click);
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fondo.Enabled = false;
            this.fondo.Location = new System.Drawing.Point(-5, -7);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(244, 128);
            this.fondo.TabIndex = 2;
            this.fondo.UseVisualStyleBackColor = false;
            // 
            // FrmPaleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(235, 114);
            this.Controls.Add(this.btnPaleta);
            this.Controls.Add(this.fondo);
            this.Name = "FrmPaleta";
            this.Text = "Color_Palette";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPaleta;
        private System.Windows.Forms.Button fondo;
    }
}

