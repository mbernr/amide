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
using eCardDialog.AUMRef;

namespace eCardDialog
{
    public partial class AUM : Form
    {
        private Dialog d;
        private card eCard;
        private AumService aumService;
        private svtProperty[] allKvts;
        private svtProperty kvt;
        private rueckdatierungsgrund[] rcAll;
        private rueckdatierungsgrund rc;

        public AUM(Dialog dialog, card eCard)
        {
            InitializeComponent();
            this.d = dialog;
            this.eCard = eCard;
            this.aumService = new AumService();
            this.aumService.Url = "https://10.196.4.114/aum/6";
            getKvtsAndWriteThemIntoComboBox();
            getRCsAndWriteThemIntoComboBox();
        }

        private void AUM_Load(object sender, EventArgs e)
        {

        }

        private void getKvtsAndWriteThemIntoComboBox()
        {
            this.allKvts = d.getBaseService().getSVTs();
            foreach (svtProperty tempKvt in this.allKvts)
            {
                aumKVTbox.Items.Add(tempKvt.text);
            }
            aumKVTbox.Sorted = true;
            aumKVTbox.SelectedIndex = 0;
        }

        private void getSelectedKvt()
        {
            foreach (svtProperty tempKvt in this.allKvts)
            {
                if (tempKvt.text.Equals(aumKVTbox.SelectedItem))
                {
                    this.kvt = tempKvt;
                    break;
                }
            }
        }

        private void getRCsAndWriteThemIntoComboBox()
        {
            this.rcAll = aumService.getRueckdatierungsgrundCodes();
            aumRC.Items.Add("");
            foreach (rueckdatierungsgrund tempRc in this.rcAll)
            {
                aumRC.Items.Add(tempRc.beschreibung);
            }
            aumRC.Sorted = true;
            aumRC.SelectedIndex = 0;
        }

        private void getSelectedRC()
        {
            rc = null;
            foreach (rueckdatierungsgrund tempRc in this.rcAll)
            {
                if (tempRc.beschreibung.Equals(aumRC.SelectedItem))
                {
                    this.rc = tempRc;
                    break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getSelectedKvt();
            getSelectedRC();
            person patient = new person();
            patient.svNummer = eCard.nummer;
            
            meldungsdaten meldung = new meldungsdaten();
            meldung.diagnose = textBox1.Text;
            meldung.arbeitsunfaehigVon = dateAb.Text;
            meldung.svtCode = kvt.code;
            meldung.arbeitsunfaehigBis = dateBis.Text;
            meldung.behandlungsDatum = dateBehandlung.Text;

           
            if (rc != null)
            {
                meldung.rueckdatierungsgrundCode = rc.code;
            }
            try{
             quittung[] abschluss = aumService.meldungAnlegen(d.getDialogId(), d.getReader().id, meldung, "AU", patient, true, true, false, true, true, true);
                responseText.Text = "Meldung erfolgreich";
                
            } catch(Exception exception)
            {
                responseText.Text = "Meldung nicht erfolgreich";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suchkriterien suche = new suchkriterien();
            suche.svNummer = eCard.nummer;
            aufSuchergebnis[] ergebnis = aumService.selbstErstellteMeldungenSuchen(d.getDialogId(), suche);
            try
            {
                aumService.meldungStornieren(d.getDialogId(), ergebnis[0].aufID, true, ergebnis[0].aufVersion, true);
                responseText.Text = "Bestehende Meldung storniert!";
            } catch (Exception exception)
            {
                responseText.Text = "Keine Meldung vorhanden";
            }
        }
    }
}
