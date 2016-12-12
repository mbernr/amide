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
    public partial class Form2 : Form
    {
        Dialog d;
        card eCard;
        public Form2(Dialog d)
        {
            InitializeComponent();
            this.d = d;
        }

        private void neuerPatient_Click(object sender, EventArgs e)
        {

            String  readerID = d.getReader().id;
            this.eCard = d.getBaseService().getCardData(readerID);
            patientNameUndGeschlecht.Text = eCard.vorname + " " + eCard.nachname + " (" + eCard.geschlechtCode + ")";
            patientGeburtsdatum.Text = eCard.geburtsdatum;
            patientSvz.Text = eCard.nummer;
        }

        private void KSE_Click(object sender, EventArgs e)
        {
            KSE kseWindow = new KSE(d, eCard);
            kseWindow.Show();
        }

        private void ABS_Click(object sender, EventArgs e)
        {
            ABSWindow absWindow = new ABSWindow(d, eCard);
            absWindow.Show();
        }

        private void btn_SAS_Click(object sender, EventArgs e)
        {
            SASWindow sasWindow = new SASWindow(d);
            sasWindow.Show();
        private void button1_Click(object sender, EventArgs e)
        {
            AUM aum = new AUM(d, eCard);
            aum.Show();
        }
    }
}
