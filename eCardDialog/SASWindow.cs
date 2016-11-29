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
using System.Web.Services.Protocols;
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
            if (!String.IsNullOrEmpty(txt_svn.Text))
            {
                try
                {
                    abfrageErgebnis ergebnis = sasService.patientendatenAbfragen(d.getDialogId(), txt_svn.Text);
                    l_nachname.Text = ergebnis.familienname;
                    l_vorname.Text = ergebnis.vorname;
                    l_gebdatum.Text = ergebnis.geburtsdatum;
                }
                catch(SoapException ex)
                {
                    l_SVNeingeben1.Text = "Fehler: " + ex.Detail.InnerText;
                }
            }
            else
            {
                l_SVNeingeben1.Text = "Bitte geben Sie eine SVN ein!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_nn.Text) && !String.IsNullOrEmpty(txt_vn.Text) && !String.IsNullOrEmpty(txt_gebdat.Text))
            {
                suchkriterien kriterien = new suchkriterien();
                kriterien.familienname = txt_nn.Text;
                kriterien.vorname = txt_vn.Text;
                kriterien.geburtsdatum = txt_gebdat.Text;
                //Zu den eingegebenen Suchkriterien konnte kein Patient gefunden werden, für den eine e-card ausgestellt wurde.
                try
                {
                    abfrageErgebnis ergebnis = sasService.svNummerAbfragen(d.getDialogId(), kriterien);
                    l_svn.Text = ergebnis.svNummer;
                }
                catch(SoapException ex)
                {
                    l_SVNeingeben.Text = "Fehler: " + ex.Detail.InnerText;
                }
              
            }
            else
            {
                l_SVNeingeben.Text = "Bitte geben Sie Vorname, Nachname und Geburtsdatum ein!";
            }
        }

        private void button_adressdaten_Click(object sender, EventArgs e)
        {
            string[] berechtigungen = d.getBaseService().getBerechtigungen(d.getDialogId());
            if (berechtigungen.Contains("SAS.ADRESSABFRAGE"))
            {
                try
                {
                    adressdaten ergebnis = sasService.adressdatenAbfragen(d.getDialogId(), txt_svn.Text);
                    l_Staatscode.Text = ergebnis.staatscode;
                    l_PLZ.Text = ergebnis.plz;
                    l_ort.Text = ergebnis.ort;
                    l_abgabestelle.Text = ergebnis.abgabestelle;
                    l_strasse.Text = ergebnis.strasse;
                    l_hausnummer.Text = ergebnis.hausnummer;
                    l_stockTurNummer.Text = ergebnis.stockTuerNummer;
                    l_anschriftszusatz.Text = ergebnis.anschriftszusatz;
                    l_postfachNummer.Text = ergebnis.postfachNummer;
                    l_postfachText.Text = ergebnis.postfachText;
                }
                catch(SoapException ex)
                {
                    l_berechtigung.Text = "Fehler: " + ex.Detail.InnerText;
                }
            }
            else
            {
                l_berechtigung.Text = "Benötigte Berechtigung nicht vorhanden.";
            }
        }
    }
}
