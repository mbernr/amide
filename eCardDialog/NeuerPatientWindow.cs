using eCardDialog.BaseRef;
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
    public partial class NeuerPatientWindow : Form
    {
        Dialog d;
        card eCard;
        public NeuerPatientWindow(Dialog d)
        {
            InitializeComponent();
            this.d = d;
        }

        private void neuerPatient_Click(object sender, EventArgs e)
        {

            String  readerID = d.getReader().id;
            this.eCard = d.getBaseService().getCardData(readerID);
            Nachname.Text = eCard.nachname;
        }

        private void KSE_Click(object sender, EventArgs e)
        {
            KSE kseWindow = new KSE(d, eCard);
            kseWindow.Show();
        }
    }
}
