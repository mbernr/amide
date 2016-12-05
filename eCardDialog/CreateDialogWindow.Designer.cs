namespace eCardDialog
{
    partial class CreateDialogWindow
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
            this.createDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createDialog
            // 
            this.createDialog.Location = new System.Drawing.Point(82, 94);
            this.createDialog.Name = "createDialog";
            this.createDialog.Size = new System.Drawing.Size(128, 40);
            this.createDialog.TabIndex = 0;
            this.createDialog.Text = "Mit Ordinationskarte anmelden";
            this.createDialog.UseVisualStyleBackColor = true;
            this.createDialog.Click += new System.EventHandler(this.createDialog_Click);
            // 
            // CreateDialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.createDialog);
            this.Name = "CreateDialogWindow";
            this.Text = "Arztsoftware";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createDialog;
    }
}