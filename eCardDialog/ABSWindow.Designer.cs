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
            this.medikamentInput = new System.Windows.Forms.TextBox();
            this.packungsanzahlInput = new System.Windows.Forms.NumericUpDown();
            this.statusBewilligungsAnfrageAuswahl = new System.Windows.Forms.ComboBox();
            this.rueckantwortButton = new System.Windows.Forms.Button();
            this.antwortNachricht = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.diagnoseInput = new System.Windows.Forms.TextBox();
            this.begruendungInput = new System.Windows.Forms.TextBox();
            this.medikamentAnzeige = new System.Windows.Forms.Label();
            this.rueckantwortEntscheid = new System.Windows.Forms.Label();
            this.rueckantwortMedikament = new System.Windows.Forms.Label();
            this.rueckantwortPackungszahl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packungsanzahlInput)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Anfrage senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sendenAnfrage_Click);
            // 
            // antragstyp
            // 
            this.antragstyp.FormattingEnabled = true;
            this.antragstyp.Location = new System.Drawing.Point(48, 49);
            this.antragstyp.Name = "antragstyp";
            this.antragstyp.Size = new System.Drawing.Size(121, 28);
            this.antragstyp.TabIndex = 1;
            // 
            // medikamentInput
            // 
            this.medikamentInput.Location = new System.Drawing.Point(48, 115);
            this.medikamentInput.Name = "medikamentInput";
            this.medikamentInput.Size = new System.Drawing.Size(121, 26);
            this.medikamentInput.TabIndex = 2;
            this.medikamentInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // packungsanzahlInput
            // 
            this.packungsanzahlInput.Location = new System.Drawing.Point(48, 179);
            this.packungsanzahlInput.Name = "packungsanzahlInput";
            this.packungsanzahlInput.Size = new System.Drawing.Size(120, 26);
            this.packungsanzahlInput.TabIndex = 3;
            // 
            // statusBewilligungsAnfrageAuswahl
            // 
            this.statusBewilligungsAnfrageAuswahl.FormattingEnabled = true;
            this.statusBewilligungsAnfrageAuswahl.Location = new System.Drawing.Point(416, 69);
            this.statusBewilligungsAnfrageAuswahl.Name = "statusBewilligungsAnfrageAuswahl";
            this.statusBewilligungsAnfrageAuswahl.Size = new System.Drawing.Size(245, 28);
            this.statusBewilligungsAnfrageAuswahl.TabIndex = 4;
            // 
            // rueckantwortButton
            // 
            this.rueckantwortButton.Location = new System.Drawing.Point(398, 392);
            this.rueckantwortButton.Name = "rueckantwortButton";
            this.rueckantwortButton.Size = new System.Drawing.Size(215, 67);
            this.rueckantwortButton.TabIndex = 5;
            this.rueckantwortButton.Text = "Rückantwort abfragen";
            this.rueckantwortButton.UseVisualStyleBackColor = true;
            this.rueckantwortButton.Click += new System.EventHandler(this.rueckantwortButton_Click);
            // 
            // antwortNachricht
            // 
            this.antwortNachricht.AutoSize = true;
            this.antwortNachricht.Location = new System.Drawing.Point(398, 156);
            this.antwortNachricht.Name = "antwortNachricht";
            this.antwortNachricht.Size = new System.Drawing.Size(37, 20);
            this.antwortNachricht.TabIndex = 6;
            this.antwortNachricht.Text = "Info";
            this.antwortNachricht.Click += new System.EventHandler(this.antwortNachricht_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Medikament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Packungszahl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Antragstyp (Arztbrief, Rezept)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Anfrageauswahl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Diagnose";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Begründung";
            // 
            // diagnoseInput
            // 
            this.diagnoseInput.Location = new System.Drawing.Point(48, 251);
            this.diagnoseInput.Name = "diagnoseInput";
            this.diagnoseInput.Size = new System.Drawing.Size(100, 26);
            this.diagnoseInput.TabIndex = 14;
            // 
            // begruendungInput
            // 
            this.begruendungInput.Location = new System.Drawing.Point(48, 317);
            this.begruendungInput.Name = "begruendungInput";
            this.begruendungInput.Size = new System.Drawing.Size(100, 26);
            this.begruendungInput.TabIndex = 15;
            // 
            // medikamentAnzeige
            // 
            this.medikamentAnzeige.AutoSize = true;
            this.medikamentAnzeige.Location = new System.Drawing.Point(416, 130);
            this.medikamentAnzeige.Name = "medikamentAnzeige";
            this.medikamentAnzeige.Size = new System.Drawing.Size(0, 20);
            this.medikamentAnzeige.TabIndex = 16;
            // 
            // rueckantwortEntscheid
            // 
            this.rueckantwortEntscheid.AutoSize = true;
            this.rueckantwortEntscheid.Location = new System.Drawing.Point(394, 240);
            this.rueckantwortEntscheid.Name = "rueckantwortEntscheid";
            this.rueckantwortEntscheid.Size = new System.Drawing.Size(92, 20);
            this.rueckantwortEntscheid.TabIndex = 17;
            this.rueckantwortEntscheid.Text = "rückantwort";
            // 
            // rueckantwortMedikament
            // 
            this.rueckantwortMedikament.AutoSize = true;
            this.rueckantwortMedikament.Location = new System.Drawing.Point(398, 293);
            this.rueckantwortMedikament.Name = "rueckantwortMedikament";
            this.rueckantwortMedikament.Size = new System.Drawing.Size(96, 20);
            this.rueckantwortMedikament.TabIndex = 18;
            this.rueckantwortMedikament.Text = "medikament";
            // 
            // rueckantwortPackungszahl
            // 
            this.rueckantwortPackungszahl.AutoSize = true;
            this.rueckantwortPackungszahl.Location = new System.Drawing.Point(398, 340);
            this.rueckantwortPackungszahl.Name = "rueckantwortPackungszahl";
            this.rueckantwortPackungszahl.Size = new System.Drawing.Size(107, 20);
            this.rueckantwortPackungszahl.TabIndex = 19;
            this.rueckantwortPackungszahl.Text = "packungszahl";
            // 
            // ABSWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 471);
            this.Controls.Add(this.rueckantwortPackungszahl);
            this.Controls.Add(this.rueckantwortMedikament);
            this.Controls.Add(this.rueckantwortEntscheid);
            this.Controls.Add(this.medikamentAnzeige);
            this.Controls.Add(this.begruendungInput);
            this.Controls.Add(this.diagnoseInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.antwortNachricht);
            this.Controls.Add(this.rueckantwortButton);
            this.Controls.Add(this.statusBewilligungsAnfrageAuswahl);
            this.Controls.Add(this.packungsanzahlInput);
            this.Controls.Add(this.medikamentInput);
            this.Controls.Add(this.antragstyp);
            this.Controls.Add(this.button1);
            this.Name = "ABSWindow";
            this.Text = "ABSWindow";
            this.Load += new System.EventHandler(this.ABSWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packungsanzahlInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox antragstyp;
        private System.Windows.Forms.TextBox medikamentInput;
        private System.Windows.Forms.NumericUpDown packungsanzahlInput;
        private System.Windows.Forms.ComboBox statusBewilligungsAnfrageAuswahl;
        private System.Windows.Forms.Button rueckantwortButton;
        private System.Windows.Forms.Label antwortNachricht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox diagnoseInput;
        private System.Windows.Forms.TextBox begruendungInput;
        private System.Windows.Forms.Label medikamentAnzeige;
        private System.Windows.Forms.Label rueckantwortEntscheid;
        private System.Windows.Forms.Label rueckantwortMedikament;
        private System.Windows.Forms.Label rueckantwortPackungszahl;
    }
}