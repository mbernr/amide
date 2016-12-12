namespace eCardDialog
{
    partial class NeuerPatientWindow
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
            this.neuerPatient = new System.Windows.Forms.Button();
            this.Nachname = new System.Windows.Forms.Label();
            this.KSE = new System.Windows.Forms.Button();
            this.ABS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // neuerPatient
            // 
            this.neuerPatient.Location = new System.Drawing.Point(122, 50);
            this.neuerPatient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.neuerPatient.Name = "neuerPatient";
            this.neuerPatient.Size = new System.Drawing.Size(209, 42);
            this.neuerPatient.TabIndex = 0;
            this.neuerPatient.Text = "neuer Patient";
            this.neuerPatient.UseVisualStyleBackColor = true;
            this.neuerPatient.Click += new System.EventHandler(this.neuerPatient_Click);
            // 
            // Nachname
            // 
            this.Nachname.AutoSize = true;
            this.Nachname.Location = new System.Drawing.Point(117, 150);
            this.Nachname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Nachname.Name = "Nachname";
            this.Nachname.Size = new System.Drawing.Size(107, 25);
            this.Nachname.TabIndex = 2;
            this.Nachname.Text = "Nachname";
            // 
            // KSE
            // 
            this.KSE.Location = new System.Drawing.Point(22, 251);
            this.KSE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.KSE.Name = "KSE";
            this.KSE.Size = new System.Drawing.Size(137, 42);
            this.KSE.TabIndex = 3;
            this.KSE.Text = "KSE";
            this.KSE.UseVisualStyleBackColor = true;
            this.KSE.Click += new System.EventHandler(this.KSE_Click);
            // 
            // ABS
            // 
            this.ABS.Location = new System.Drawing.Point(22, 324);
            this.ABS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ABS.Name = "ABS";
            this.ABS.Size = new System.Drawing.Size(137, 46);
            this.ABS.TabIndex = 4;
            this.ABS.Text = "ABS";
            this.ABS.UseVisualStyleBackColor = true;
            this.ABS.Click += new System.EventHandler(this.ABS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "AUM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NeuerPatientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ABS);
            this.Controls.Add(this.KSE);
            this.Controls.Add(this.Nachname);
            this.Controls.Add(this.neuerPatient);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "NeuerPatientWindow";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button neuerPatient;
        private System.Windows.Forms.Label Nachname;
        private System.Windows.Forms.Button KSE;
        private System.Windows.Forms.Button ABS;
        private System.Windows.Forms.Button button1;
    }
}