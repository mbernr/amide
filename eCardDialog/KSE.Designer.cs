namespace eCardDialog
{
    partial class KSE
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
            this.fachgebietLabel = new System.Windows.Forms.Label();
            this.behandlungsfallLabel = new System.Windows.Forms.Label();
            this.konsultationsdatenLabel = new System.Windows.Forms.Label();
            this.kseMessagesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fachgebietLabel
            // 
            this.fachgebietLabel.AutoSize = true;
            this.fachgebietLabel.Location = new System.Drawing.Point(38, 73);
            this.fachgebietLabel.Name = "fachgebietLabel";
            this.fachgebietLabel.Size = new System.Drawing.Size(60, 13);
            this.fachgebietLabel.TabIndex = 0;
            this.fachgebietLabel.Text = "Fachgebiet";
            this.fachgebietLabel.Click += new System.EventHandler(this.fachbereiche_Click);
            // 
            // behandlungsfallLabel
            // 
            this.behandlungsfallLabel.AutoSize = true;
            this.behandlungsfallLabel.Location = new System.Drawing.Point(38, 97);
            this.behandlungsfallLabel.Name = "behandlungsfallLabel";
            this.behandlungsfallLabel.Size = new System.Drawing.Size(94, 13);
            this.behandlungsfallLabel.TabIndex = 3;
            this.behandlungsfallLabel.Text = "Behandlungsfaelle";
            // 
            // konsultationsdatenLabel
            // 
            this.konsultationsdatenLabel.AutoSize = true;
            this.konsultationsdatenLabel.Location = new System.Drawing.Point(38, 120);
            this.konsultationsdatenLabel.Name = "konsultationsdatenLabel";
            this.konsultationsdatenLabel.Size = new System.Drawing.Size(97, 13);
            this.konsultationsdatenLabel.TabIndex = 4;
            this.konsultationsdatenLabel.Text = "Konsultationsdaten";
            this.konsultationsdatenLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // kseMessagesLabel
            // 
            this.kseMessagesLabel.AutoSize = true;
            this.kseMessagesLabel.Location = new System.Drawing.Point(38, 145);
            this.kseMessagesLabel.Name = "kseMessagesLabel";
            this.kseMessagesLabel.Size = new System.Drawing.Size(79, 13);
            this.kseMessagesLabel.TabIndex = 5;
            this.kseMessagesLabel.Text = "KSE Messages";
            this.kseMessagesLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // KSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 383);
            this.Controls.Add(this.kseMessagesLabel);
            this.Controls.Add(this.konsultationsdatenLabel);
            this.Controls.Add(this.behandlungsfallLabel);
            this.Controls.Add(this.fachgebietLabel);
            this.Name = "KSE";
            this.Text = "KSE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fachgebietLabel;
        private System.Windows.Forms.Label behandlungsfallLabel;
        private System.Windows.Forms.Label konsultationsdatenLabel;
        private System.Windows.Forms.Label kseMessagesLabel;
    }
}