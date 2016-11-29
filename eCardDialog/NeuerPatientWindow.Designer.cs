namespace eCardDialog
{
    partial class Form2
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
            this.patientNameUndGeschlecht = new System.Windows.Forms.Label();
            this.KSE = new System.Windows.Forms.Button();
            this.ABS = new System.Windows.Forms.Button();
            this.patientGeburtsdatum = new System.Windows.Forms.Label();
            this.patientSvz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // neuerPatient
            // 
            this.neuerPatient.Location = new System.Drawing.Point(12, 12);
            this.neuerPatient.Name = "neuerPatient";
            this.neuerPatient.Size = new System.Drawing.Size(114, 23);
            this.neuerPatient.TabIndex = 0;
            this.neuerPatient.Text = "neuer Patient";
            this.neuerPatient.UseVisualStyleBackColor = true;
            this.neuerPatient.Click += new System.EventHandler(this.neuerPatient_Click);
            // 
            // patientNameUndGeschlecht
            // 
            this.patientNameUndGeschlecht.AutoSize = true;
            this.patientNameUndGeschlecht.Location = new System.Drawing.Point(12, 47);
            this.patientNameUndGeschlecht.Name = "patientNameUndGeschlecht";
            this.patientNameUndGeschlecht.Size = new System.Drawing.Size(121, 13);
            this.patientNameUndGeschlecht.TabIndex = 2;
            this.patientNameUndGeschlecht.Text = "Kein Patient ausgewählt";
            // 
            // KSE
            // 
            this.KSE.Location = new System.Drawing.Point(12, 136);
            this.KSE.Name = "KSE";
            this.KSE.Size = new System.Drawing.Size(75, 23);
            this.KSE.TabIndex = 3;
            this.KSE.Text = "KSE";
            this.KSE.UseVisualStyleBackColor = true;
            this.KSE.Click += new System.EventHandler(this.KSE_Click);
            // 
            // ABS
            // 
            this.ABS.Location = new System.Drawing.Point(12, 175);
            this.ABS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ABS.Name = "ABS";
            this.ABS.Size = new System.Drawing.Size(75, 25);
            this.ABS.TabIndex = 4;
            this.ABS.Text = "ABS";
            this.ABS.UseVisualStyleBackColor = true;
            this.ABS.Click += new System.EventHandler(this.ABS_Click);
            // 
            // patientGeburtsdatum
            // 
            this.patientGeburtsdatum.AutoSize = true;
            this.patientGeburtsdatum.Location = new System.Drawing.Point(12, 69);
            this.patientGeburtsdatum.Name = "patientGeburtsdatum";
            this.patientGeburtsdatum.Size = new System.Drawing.Size(0, 13);
            this.patientGeburtsdatum.TabIndex = 5;
            // 
            // patientSvz
            // 
            this.patientSvz.AutoSize = true;
            this.patientSvz.Location = new System.Drawing.Point(12, 91);
            this.patientSvz.Name = "patientSvz";
            this.patientSvz.Size = new System.Drawing.Size(0, 13);
            this.patientSvz.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.patientSvz);
            this.Controls.Add(this.patientGeburtsdatum);
            this.Controls.Add(this.ABS);
            this.Controls.Add(this.KSE);
            this.Controls.Add(this.patientNameUndGeschlecht);
            this.Controls.Add(this.neuerPatient);
            this.Name = "Form2";
            this.Text = "Arztsoftware";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button neuerPatient;
        private System.Windows.Forms.Label patientNameUndGeschlecht;
        private System.Windows.Forms.Button KSE;
        private System.Windows.Forms.Button ABS;
        private System.Windows.Forms.Label patientGeburtsdatum;
        private System.Windows.Forms.Label patientSvz;
    }
}