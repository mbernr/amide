using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCardDialog
{
    public partial class CreateDialogWindow : Form
    {
        public CreateDialogWindow()
        {
            InitializeComponent();
            
        }

        private void createDialog_Click(object sender, EventArgs e)
        {
            Dialog d = new Dialog();
            d.createDialog();
            this.Hide();
            NeuerPatientWindow form2 = new NeuerPatientWindow(d);
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
