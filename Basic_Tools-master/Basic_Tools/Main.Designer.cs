namespace Basic_Tools
{
    partial class frmMain
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
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblSecondTitle = new System.Windows.Forms.Label();
            this.btnTextEditor = new System.Windows.Forms.Button();
            this.btnCPalette = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMainTitle.Location = new System.Drawing.Point(105, 49);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(165, 24);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Basic Tools 0.1";
            // 
            // lblSecondTitle
            // 
            this.lblSecondTitle.AutoSize = true;
            this.lblSecondTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondTitle.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSecondTitle.Location = new System.Drawing.Point(23, 127);
            this.lblSecondTitle.Name = "lblSecondTitle";
            this.lblSecondTitle.Size = new System.Drawing.Size(112, 21);
            this.lblSecondTitle.TabIndex = 1;
            this.lblSecondTitle.Text = "Choose one: ";
            // 
            // btnTextEditor
            // 
            this.btnTextEditor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTextEditor.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextEditor.ForeColor = System.Drawing.Color.LightGray;
            this.btnTextEditor.Location = new System.Drawing.Point(123, 173);
            this.btnTextEditor.Name = "btnTextEditor";
            this.btnTextEditor.Size = new System.Drawing.Size(136, 35);
            this.btnTextEditor.TabIndex = 2;
            this.btnTextEditor.Text = "Text Editor";
            this.btnTextEditor.UseVisualStyleBackColor = false;
            this.btnTextEditor.Click += new System.EventHandler(this.btnTextEditor_Click);
            // 
            // btnCPalette
            // 
            this.btnCPalette.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCPalette.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPalette.ForeColor = System.Drawing.Color.LightGray;
            this.btnCPalette.Location = new System.Drawing.Point(123, 214);
            this.btnCPalette.Name = "btnCPalette";
            this.btnCPalette.Size = new System.Drawing.Size(136, 35);
            this.btnCPalette.TabIndex = 3;
            this.btnCPalette.Text = "Colors Palette";
            this.btnCPalette.UseVisualStyleBackColor = false;
            this.btnCPalette.Click += new System.EventHandler(this.btnCPalette_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(86, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(377, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCPalette);
            this.Controls.Add(this.btnTextEditor);
            this.Controls.Add(this.lblSecondTitle);
            this.Controls.Add(this.lblMainTitle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmMain";
            this.Text = "Basic_Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblSecondTitle;
        private System.Windows.Forms.Button btnTextEditor;
        private System.Windows.Forms.Button btnCPalette;
        private System.Windows.Forms.Button button1;
    }
}

