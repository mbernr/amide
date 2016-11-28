namespace eCardDialog
{
    partial class ABSWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.antragstyp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 116);
            this.button1.TabIndex = 0;
            this.button1.Text = "Anfrage senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sendenAnfrage_Click);
            // 
            // antragstyp
            // 
            this.antragstyp.FormattingEnabled = true;
            this.antragstyp.Location = new System.Drawing.Point(294, 163);
            this.antragstyp.Name = "antragstyp";
            this.antragstyp.Size = new System.Drawing.Size(121, 28);
            this.antragstyp.TabIndex = 1;
            // 
            // ABSWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 471);
            this.Controls.Add(this.antragstyp);
            this.Controls.Add(this.button1);
            this.Name = "ABSWindow";
            this.Text = "ABSWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox antragstyp;
    }
}