namespace Basic_Tools
{
    partial class Main
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
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(94, 52);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(165, 24);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Basic Tools 0.1";
            // 
            // lblSecondTitle
            // 
            this.lblSecondTitle.AutoSize = true;
            this.lblSecondTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondTitle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondTitle.Location = new System.Drawing.Point(23, 127);
            this.lblSecondTitle.Name = "lblSecondTitle";
            this.lblSecondTitle.Size = new System.Drawing.Size(106, 21);
            this.lblSecondTitle.TabIndex = 1;
            this.lblSecondTitle.Text = "Choose one: ";
            // 
            // btnTextEditor
            // 
            this.btnTextEditor.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextEditor.Location = new System.Drawing.Point(123, 173);
            this.btnTextEditor.Name = "btnTextEditor";
            this.btnTextEditor.Size = new System.Drawing.Size(136, 35);
            this.btnTextEditor.TabIndex = 2;
            this.btnTextEditor.Text = "Text Editor";
            this.btnTextEditor.UseVisualStyleBackColor = true;
            this.btnTextEditor.Click += new System.EventHandler(this.btnTextEditor_Click);
            // 
            // btnCPalette
            // 
            this.btnCPalette.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPalette.Location = new System.Drawing.Point(123, 214);
            this.btnCPalette.Name = "btnCPalette";
            this.btnCPalette.Size = new System.Drawing.Size(136, 35);
            this.btnCPalette.TabIndex = 3;
            this.btnCPalette.Text = "Colors Palette";
            this.btnCPalette.UseVisualStyleBackColor = true;
            this.btnCPalette.Click += new System.EventHandler(this.btnCPalette_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 445);
            this.Controls.Add(this.btnCPalette);
            this.Controls.Add(this.btnTextEditor);
            this.Controls.Add(this.lblSecondTitle);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblSecondTitle;
        private System.Windows.Forms.Button btnTextEditor;
        private System.Windows.Forms.Button btnCPalette;
    }
}

