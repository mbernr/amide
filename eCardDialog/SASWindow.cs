using eCardDialog.BaseRef;
using eCardDialog.SasRef;
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
    public partial class SASWindow : Form
    {
        SasRef.SasService sasService = new SasRef.SasService();
        Dialog d;
        public SASWindow(Dialog d)
        {
            this.d = d;
            InitializeComponent();     
            sasService.Url = "https://10.196.4.114/sas/12";
        }


        private void btn_personendatenAbfragen_Click(object sender, EventArgs e)
        {//1000251170
            abfrageErgebnis ergebnis = sasService.patientendatenAbfragen(d.getDialogId(), txt_svn.Text);
            l_nachname.Text = ergebnis.familienname;
            l_vorname.Text = ergebnis.vorname;
            l_gebdatum.Text = ergebnis.geburtsdatum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            suchkriterien kriterien = new suchkriterien();
            kriterien.familienname = txt_nn.Text;
            kriterien.vorname = txt_vn.Text;
            kriterien.geburtsdatum = txt_gebdat.Text;
            abfrageErgebnis ergebnis = sasService.svNummerAbfragen(d.getDialogId(), kriterien);
            l_svn.Text = ergebnis.svNummer;
        }
    }
}
