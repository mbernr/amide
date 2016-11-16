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
            this.behandlungsfaelleComboBox = new System.Windows.Forms.ComboBox();
            this.fachgebietText = new System.Windows.Forms.Label();
            this.doKonsultationButton = new System.Windows.Forms.Button();
            this.fachgebieteComboBox = new System.Windows.Forms.ComboBox();
            this.svtPropertiesLabel = new System.Windows.Forms.Label();
            this.svtProperitesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fachgebietLabel
            // 
            this.fachgebietLabel.AutoSize = true;
            this.fachgebietLabel.Location = new System.Drawing.Point(148, 81);
            this.fachgebietLabel.Name = "fachgebietLabel";
            this.fachgebietLabel.Size = new System.Drawing.Size(0, 13);
            this.fachgebietLabel.TabIndex = 0;
            // 
            // behandlungsfallLabel
            // 
            this.behandlungsfallLabel.AutoSize = true;
            this.behandlungsfallLabel.Location = new System.Drawing.Point(38, 100);
            this.behandlungsfallLabel.Name = "behandlungsfallLabel";
            this.behandlungsfallLabel.Size = new System.Drawing.Size(82, 13);
            this.behandlungsfallLabel.TabIndex = 3;
            this.behandlungsfallLabel.Text = "Behandlungsfall";
            // 
            // konsultationsdatenLabel
            // 
            this.konsultationsdatenLabel.AutoSize = true;
            this.konsultationsdatenLabel.Location = new System.Drawing.Point(38, 202);
            this.konsultationsdatenLabel.Name = "konsultationsdatenLabel";
            this.konsultationsdatenLabel.Size = new System.Drawing.Size(0, 13);
            this.konsultationsdatenLabel.TabIndex = 4;
            // 
            // behandlungsfaelleComboBox
            // 
            this.behandlungsfaelleComboBox.FormattingEnabled = true;
            this.behandlungsfaelleComboBox.Location = new System.Drawing.Point(151, 97);
            this.behandlungsfaelleComboBox.Name = "behandlungsfaelleComboBox";
            this.behandlungsfaelleComboBox.Size = new System.Drawing.Size(226, 21);
            this.behandlungsfaelleComboBox.TabIndex = 6;
            // 
            // fachgebietText
            // 
            this.fachgebietText.AutoSize = true;
            this.fachgebietText.Location = new System.Drawing.Point(38, 73);
            this.fachgebietText.Name = "fachgebietText";
            this.fachgebietText.Size = new System.Drawing.Size(60, 13);
            this.fachgebietText.TabIndex = 9;
            this.fachgebietText.Text = "Fachgebiet";
            // 
            // doKonsultationButton
            // 
            this.doKonsultationButton.Location = new System.Drawing.Point(41, 162);
            this.doKonsultationButton.Name = "doKonsultationButton";
            this.doKonsultationButton.Size = new System.Drawing.Size(149, 23);
            this.doKonsultationButton.TabIndex = 10;
            this.doKonsultationButton.Text = "Konsultation ausführen";
            this.doKonsultationButton.UseVisualStyleBackColor = true;
            this.doKonsultationButton.Click += new System.EventHandler(this.doKonsultationButton_Click);
            // 
            // fachgebieteComboBox
            // 
            this.fachgebieteComboBox.FormattingEnabled = true;
            this.fachgebieteComboBox.Location = new System.Drawing.Point(151, 70);
            this.fachgebieteComboBox.Name = "fachgebieteComboBox";
            this.fachgebieteComboBox.Size = new System.Drawing.Size(226, 21);
            this.fachgebieteComboBox.TabIndex = 13;
            // 
            // svtPropertiesLabel
            // 
            this.svtPropertiesLabel.AutoSize = true;
            this.svtPropertiesLabel.Location = new System.Drawing.Point(38, 128);
            this.svtPropertiesLabel.Name = "svtPropertiesLabel";
            this.svtPropertiesLabel.Size = new System.Drawing.Size(28, 13);
            this.svtPropertiesLabel.TabIndex = 14;
            this.svtPropertiesLabel.Text = "KVT";
            // 
            // svtProperitesComboBox
            // 
            this.svtProperitesComboBox.FormattingEnabled = true;
            this.svtProperitesComboBox.Location = new System.Drawing.Point(151, 125);
            this.svtProperitesComboBox.Name = "svtProperitesComboBox";
            this.svtProperitesComboBox.Size = new System.Drawing.Size(226, 21);
            this.svtProperitesComboBox.TabIndex = 17;
            // 
            // KSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 383);
            this.Controls.Add(this.svtProperitesComboBox);
            this.Controls.Add(this.svtPropertiesLabel);
            this.Controls.Add(this.fachgebieteComboBox);
            this.Controls.Add(this.doKonsultationButton);
            this.Controls.Add(this.fachgebietText);
            this.Controls.Add(this.behandlungsfaelleComboBox);
            this.Controls.Add(this.konsultationsdatenLabel);
            this.Controls.Add(this.behandlungsfallLabel);
            this.Controls.Add(this.fachgebietLabel);
            this.Name = "KSE";
            this.Text = "KSE";
            this.Load += new System.EventHandler(this.KSE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fachgebietLabel;
        private System.Windows.Forms.Label behandlungsfallLabel;
        private System.Windows.Forms.Label konsultationsdatenLabel;
        private System.Windows.Forms.ComboBox behandlungsfaelleComboBox;
        private System.Windows.Forms.Label fachgebietText;
        private System.Windows.Forms.Button doKonsultationButton;
        private System.Windows.Forms.ComboBox fachgebieteComboBox;
        private System.Windows.Forms.Label svtPropertiesLabel;
        private System.Windows.Forms.ComboBox svtProperitesComboBox;
    }
}