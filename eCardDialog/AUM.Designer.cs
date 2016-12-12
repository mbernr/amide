namespace eCardDialog
{
    partial class AUM
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
            this.aumKVTbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aumRC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateAb = new System.Windows.Forms.TextBox();
            this.dateBis = new System.Windows.Forms.TextBox();
            this.dateBehandlung = new System.Windows.Forms.TextBox();
            this.responseText = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aumKVTbox
            // 
            this.aumKVTbox.FormattingEnabled = true;
            this.aumKVTbox.Location = new System.Drawing.Point(331, 57);
            this.aumKVTbox.Name = "aumKVTbox";
            this.aumKVTbox.Size = new System.Drawing.Size(397, 32);
            this.aumKVTbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Versicherungsträger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Diagnose";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Krankmelden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gültig ab";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gültig bis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 29);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Behandlungsdatum";
            // 
            // aumRC
            // 
            this.aumRC.FormattingEnabled = true;
            this.aumRC.Location = new System.Drawing.Point(331, 377);
            this.aumRC.Name = "aumRC";
            this.aumRC.Size = new System.Drawing.Size(397, 32);
            this.aumRC.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rückdatierungsgrund";
            // 
            // dateAb
            // 
            this.dateAb.Location = new System.Drawing.Point(330, 179);
            this.dateAb.Name = "dateAb";
            this.dateAb.Size = new System.Drawing.Size(398, 29);
            this.dateAb.TabIndex = 16;
            // 
            // dateBis
            // 
            this.dateBis.Location = new System.Drawing.Point(331, 237);
            this.dateBis.Name = "dateBis";
            this.dateBis.Size = new System.Drawing.Size(397, 29);
            this.dateBis.TabIndex = 17;
            // 
            // dateBehandlung
            // 
            this.dateBehandlung.Location = new System.Drawing.Point(330, 294);
            this.dateBehandlung.Name = "dateBehandlung";
            this.dateBehandlung.Size = new System.Drawing.Size(398, 29);
            this.dateBehandlung.TabIndex = 18;
            // 
            // responseText
            // 
            this.responseText.AutoSize = true;
            this.responseText.Location = new System.Drawing.Point(43, 532);
            this.responseText.Name = "responseText";
            this.responseText.Size = new System.Drawing.Size(0, 25);
            this.responseText.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(447, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "Bestehende Meldung stornieren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AUM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 625);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.responseText);
            this.Controls.Add(this.dateBehandlung);
            this.Controls.Add(this.dateBis);
            this.Controls.Add(this.dateAb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aumRC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aumKVTbox);
            this.Name = "AUM";
            this.Text = "AUM";
            this.Load += new System.EventHandler(this.AUM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox aumKVTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox aumRC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dateAb;
        private System.Windows.Forms.TextBox dateBis;
        private System.Windows.Forms.TextBox dateBehandlung;
        private System.Windows.Forms.Label responseText;
        private System.Windows.Forms.Button button2;
    }
}