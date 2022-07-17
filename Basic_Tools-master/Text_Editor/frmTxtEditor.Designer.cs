namespace Text_Editor
{
    partial class frmTxtEditor
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
            this.MytextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCtrlGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerCtrlYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MytextBox1
            // 
            this.MytextBox1.Location = new System.Drawing.Point(0, 27);
            this.MytextBox1.Name = "MytextBox1";
            this.MytextBox1.Size = new System.Drawing.Size(531, 241);
            this.MytextBox1.TabIndex = 0;
            this.MytextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.formatoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.abrirCtrlAToolStripMenuItem,
            this.guardarCtrlGToolStripMenuItem,
            this.salirAltF4ToolStripMenuItem});
            this.aToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.aToolStripMenuItem.Text = "Archivo";
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(200, 22);
            this.Nuevo.Text = "Nuevo                  Ctrl+N";
            this.Nuevo.Click += new System.EventHandler(this.nuevoCtrlNToolStripMenuItem_Click);
            // 
            // abrirCtrlAToolStripMenuItem
            // 
            this.abrirCtrlAToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.abrirCtrlAToolStripMenuItem.Name = "abrirCtrlAToolStripMenuItem";
            this.abrirCtrlAToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.abrirCtrlAToolStripMenuItem.Text = "Abrir                     Ctrl+A";
            this.abrirCtrlAToolStripMenuItem.Click += new System.EventHandler(this.abrirCtrlAToolStripMenuItem_Click);
            // 
            // guardarCtrlGToolStripMenuItem
            // 
            this.guardarCtrlGToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guardarCtrlGToolStripMenuItem.Name = "guardarCtrlGToolStripMenuItem";
            this.guardarCtrlGToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.guardarCtrlGToolStripMenuItem.Text = "Guardar                Ctrl+G";
            this.guardarCtrlGToolStripMenuItem.Click += new System.EventHandler(this.guardarCtrlGToolStripMenuItem_Click);
            // 
            // salirAltF4ToolStripMenuItem
            // 
            this.salirAltF4ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.salirAltF4ToolStripMenuItem.Name = "salirAltF4ToolStripMenuItem";
            this.salirAltF4ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.salirAltF4ToolStripMenuItem.Text = "Salir                       Alt+F4";
            this.salirAltF4ToolStripMenuItem.Click += new System.EventHandler(this.salirAltF4ToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerCtrlZToolStripMenuItem,
            this.rehacerCtrlYToolStripMenuItem,
            this.copiarCtrlCToolStripMenuItem,
            this.cortarCtrlXToolStripMenuItem,
            this.pegarCtrlVToolStripMenuItem,
            this.seleccionarTodoToolStripMenuItem,
            this.eliminarTodoToolStripMenuItem});
            this.edicionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // deshacerCtrlZToolStripMenuItem
            // 
            this.deshacerCtrlZToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.deshacerCtrlZToolStripMenuItem.Name = "deshacerCtrlZToolStripMenuItem";
            this.deshacerCtrlZToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.deshacerCtrlZToolStripMenuItem.Text = "Deshacer                Ctrl+Z";
            this.deshacerCtrlZToolStripMenuItem.Click += new System.EventHandler(this.deshacerCtrlZToolStripMenuItem_Click);
            // 
            // rehacerCtrlYToolStripMenuItem
            // 
            this.rehacerCtrlYToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rehacerCtrlYToolStripMenuItem.Name = "rehacerCtrlYToolStripMenuItem";
            this.rehacerCtrlYToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.rehacerCtrlYToolStripMenuItem.Text = "Rehacer                  Ctrl+Y";
            this.rehacerCtrlYToolStripMenuItem.Click += new System.EventHandler(this.rehacerCtrlYToolStripMenuItem_Click);
            // 
            // copiarCtrlCToolStripMenuItem
            // 
            this.copiarCtrlCToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.copiarCtrlCToolStripMenuItem.Name = "copiarCtrlCToolStripMenuItem";
            this.copiarCtrlCToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.copiarCtrlCToolStripMenuItem.Text = "Copiar                    Ctrl+C";
            this.copiarCtrlCToolStripMenuItem.Click += new System.EventHandler(this.copiarCtrlCToolStripMenuItem_Click);
            // 
            // cortarCtrlXToolStripMenuItem
            // 
            this.cortarCtrlXToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cortarCtrlXToolStripMenuItem.Name = "cortarCtrlXToolStripMenuItem";
            this.cortarCtrlXToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cortarCtrlXToolStripMenuItem.Text = "Cortar                     Ctrl+X";
            this.cortarCtrlXToolStripMenuItem.Click += new System.EventHandler(this.cortarCtrlXToolStripMenuItem_Click);
            // 
            // pegarCtrlVToolStripMenuItem
            // 
            this.pegarCtrlVToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pegarCtrlVToolStripMenuItem.Name = "pegarCtrlVToolStripMenuItem";
            this.pegarCtrlVToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.pegarCtrlVToolStripMenuItem.Text = "Pegar                      Ctrl+V";
            this.pegarCtrlVToolStripMenuItem.Click += new System.EventHandler(this.pegarCtrlVToolStripMenuItem_Click);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo   Ctrl+E";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // eliminarTodoToolStripMenuItem
            // 
            this.eliminarTodoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.eliminarTodoToolStripMenuItem.Name = "eliminarTodoToolStripMenuItem";
            this.eliminarTodoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.eliminarTodoToolStripMenuItem.Text = "Eliminar todo     Ctrl+Alt+X";
            this.eliminarTodoToolStripMenuItem.Click += new System.EventHandler(this.eliminarTodoToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem});
            this.formatoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rosmeiry M Garabito Maria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "2021-0587";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(400, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmTxtEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(535, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MytextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTxtEditor";
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MytextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Nuevo;
        private System.Windows.Forms.ToolStripMenuItem abrirCtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarCtrlGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerCtrlZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerCtrlYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarCtrlVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

