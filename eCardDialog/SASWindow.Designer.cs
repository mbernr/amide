namespace eCardDialog
{
    partial class SASWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.l_svn = new System.Windows.Forms.Label();
            this.txt_gebdat = new System.Windows.Forms.TextBox();
            this.txt_nn = new System.Windows.Forms.TextBox();
            this.txt_vn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_personendatenAbfragen = new System.Windows.Forms.Button();
            this.l_gebdatum = new System.Windows.Forms.Label();
            this.l_nachname = new System.Windows.Forms.Label();
            this.l_vorname = new System.Windows.Forms.Label();
            this.txt_svn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.l_svn);
            this.groupBox1.Controls.Add(this.txt_gebdat);
            this.groupBox1.Controls.Add(this.txt_nn);
            this.groupBox1.Controls.Add(this.txt_vn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(-2, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sozialversicherungsnummer abfragen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "abfragen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_svn
            // 
            this.l_svn.AutoSize = true;
            this.l_svn.Location = new System.Drawing.Point(200, 120);
            this.l_svn.Name = "l_svn";
            this.l_svn.Size = new System.Drawing.Size(0, 13);
            this.l_svn.TabIndex = 8;
            // 
            // txt_gebdat
            // 
            this.txt_gebdat.Location = new System.Drawing.Point(125, 88);
            this.txt_gebdat.Name = "txt_gebdat";
            this.txt_gebdat.Size = new System.Drawing.Size(226, 20);
            this.txt_gebdat.TabIndex = 10;
            // 
            // txt_nn
            // 
            this.txt_nn.Location = new System.Drawing.Point(125, 61);
            this.txt_nn.Name = "txt_nn";
            this.txt_nn.Size = new System.Drawing.Size(226, 20);
            this.txt_nn.TabIndex = 9;
            // 
            // txt_vn
            // 
            this.txt_vn.Location = new System.Drawing.Point(125, 26);
            this.txt_vn.Name = "txt_vn";
            this.txt_vn.Size = new System.Drawing.Size(226, 20);
            this.txt_vn.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sozialversicherungsnummer: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Geburtsdatum: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nachname: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Vorname: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_personendatenAbfragen);
            this.groupBox2.Controls.Add(this.l_gebdatum);
            this.groupBox2.Controls.Add(this.l_nachname);
            this.groupBox2.Controls.Add(this.l_vorname);
            this.groupBox2.Controls.Add(this.txt_svn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patientendaten abfragen";
            // 
            // btn_personendatenAbfragen
            // 
            this.btn_personendatenAbfragen.Location = new System.Drawing.Point(373, 29);
            this.btn_personendatenAbfragen.Name = "btn_personendatenAbfragen";
            this.btn_personendatenAbfragen.Size = new System.Drawing.Size(75, 23);
            this.btn_personendatenAbfragen.TabIndex = 8;
            this.btn_personendatenAbfragen.Text = "abfragen";
            this.btn_personendatenAbfragen.UseVisualStyleBackColor = true;
            this.btn_personendatenAbfragen.Click += new System.EventHandler(this.btn_personendatenAbfragen_Click);
            // 
            // l_gebdatum
            // 
            this.l_gebdatum.AutoSize = true;
            this.l_gebdatum.Location = new System.Drawing.Point(197, 111);
            this.l_gebdatum.Name = "l_gebdatum";
            this.l_gebdatum.Size = new System.Drawing.Size(0, 13);
            this.l_gebdatum.TabIndex = 7;
            // 
            // l_nachname
            // 
            this.l_nachname.AutoSize = true;
            this.l_nachname.Location = new System.Drawing.Point(197, 87);
            this.l_nachname.Name = "l_nachname";
            this.l_nachname.Size = new System.Drawing.Size(0, 13);
            this.l_nachname.TabIndex = 6;
            // 
            // l_vorname
            // 
            this.l_vorname.AutoSize = true;
            this.l_vorname.Location = new System.Drawing.Point(197, 60);
            this.l_vorname.Name = "l_vorname";
            this.l_vorname.Size = new System.Drawing.Size(0, 13);
            this.l_vorname.TabIndex = 5;
            // 
            // txt_svn
            // 
            this.txt_svn.Location = new System.Drawing.Point(177, 31);
            this.txt_svn.Name = "txt_svn";
            this.txt_svn.Size = new System.Drawing.Size(171, 20);
            this.txt_svn.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geburtsdatum: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nachname: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sozialversicherungsnummer: ";
            // 
            // SASWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SASWindow";
            this.Text = "SASWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_svn;
        private System.Windows.Forms.TextBox txt_gebdat;
        private System.Windows.Forms.TextBox txt_nn;
        private System.Windows.Forms.TextBox txt_vn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_personendatenAbfragen;
        private System.Windows.Forms.Label l_gebdatum;
        private System.Windows.Forms.Label l_nachname;
        private System.Windows.Forms.Label l_vorname;
        private System.Windows.Forms.TextBox txt_svn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}