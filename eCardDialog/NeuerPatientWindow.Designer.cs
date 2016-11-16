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
            this.btn_SAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // neuerPatient
            // 
            this.neuerPatient.Location = new System.Drawing.Point(67, 27);
            this.neuerPatient.Name = "neuerPatient";
            this.neuerPatient.Size = new System.Drawing.Size(114, 23);
            this.neuerPatient.TabIndex = 0;
            this.neuerPatient.Text = "neuer Patient";
            this.neuerPatient.UseVisualStyleBackColor = true;
            this.neuerPatient.Click += new System.EventHandler(this.neuerPatient_Click);
            // 
            // Nachname
            // 
            this.Nachname.AutoSize = true;
            this.Nachname.Location = new System.Drawing.Point(64, 81);
            this.Nachname.Name = "Nachname";
            this.Nachname.Size = new System.Drawing.Size(59, 13);
            this.Nachname.TabIndex = 2;
            this.Nachname.Text = "Nachname";
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
            // btn_SAS
            // 
            this.btn_SAS.Location = new System.Drawing.Point(112, 136);
            this.btn_SAS.Name = "btn_SAS";
            this.btn_SAS.Size = new System.Drawing.Size(80, 23);
            this.btn_SAS.TabIndex = 4;
            this.btn_SAS.Text = "SAS";
            this.btn_SAS.UseVisualStyleBackColor = true;
            this.btn_SAS.Click += new System.EventHandler(this.btn_SAS_Click);
            // 
            // NeuerPatientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_SAS);
            this.Controls.Add(this.KSE);
            this.Controls.Add(this.Nachname);
            this.Controls.Add(this.neuerPatient);
            this.Name = "NeuerPatientWindow";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button neuerPatient;
        private System.Windows.Forms.Label Nachname;
        private System.Windows.Forms.Button KSE;
        private System.Windows.Forms.Button btn_SAS;
    }
}