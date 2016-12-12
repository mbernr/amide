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
    public partial class ABSWindow : Form
    {
        private Dialog d;
        private card eCard;
        private ABSRef.AbsService absService = new ABSRef.AbsService();
        private ABSRef.bewilligungsAnfrage bewilligungsAnfrage = new ABSRef.bewilligungsAnfrage();
        private ABSRef.anfrageAntwort anfrageAntwort = new ABSRef.anfrageAntwort();

        //      bewilligungsAnfrage.setVerordnungen(Verordnung[] verordnungen) 

        public ABSWindow(Dialog d, card eCard)
        {
            InitializeComponent();
            this.d = d;
            this.eCard = eCard;
            this.absService.Url = "https://10.196.4.114/abs/11";
            antragstyp.Items.Add("A");
            antragstyp.Items.Add("R");
            this.bewilligungsAnfrage.patientenDaten = this.createPatientenDaten(eCard);
         
        }
        
        private ABSRef.patientenDaten createPatientenDaten(card eCard)
        {
            ABSRef.patientenDaten patientenDaten = new ABSRef.patientenDaten();
            patientenDaten.SVNummer = eCard.nummer;
            patientenDaten.nachname = eCard.nachname;
            patientenDaten.vorname = eCard.vorname;
            patientenDaten.geschlecht = eCard.geschlechtCode;
            patientenDaten.rezeptGebBefreit = true;
            patientenDaten.druckNachname = eCard.nachname;
            patientenDaten.druckVorname = eCard.vorname;
           
            return patientenDaten;
        }

        private ABSRef.verordnung createVerordnung()
        {
            ABSRef.verordnung verordnung = new ABSRef.verordnung();
            ABSRef.medikament medikament = new ABSRef.medikament();
            medikament.name = medikamentInput.Text;
            verordnung.medikament = medikament;
            verordnung.packungsanzahl = (int)packungsanzahlInput.Value;
            verordnung.packungsanzahlSpecified = true;
            verordnung.diagnose = diagnoseInput.Text.Length > 0 ? diagnoseInput.Text.ToString() : "diagnose";
            verordnung.begruendung = begruendungInput.Text.Length > 0 ? begruendungInput.Text.ToString() : "begruendung";
            
            return verordnung;
        }

        private void sendenAnfrage_Click(object sender, EventArgs e)
        {
            if (antragstyp.SelectedItem == null)
            {
                return;
            }
            
            this.bewilligungsAnfrage.antragstyp = antragstyp.SelectedItem.ToString();
            
            try
            {
                var verordnungen = new List<ABSRef.verordnung>();
                verordnungen.Add(this.createVerordnung());
                this.bewilligungsAnfrage.verordnungen = verordnungen.ToArray();

                this.anfrageAntwort = this.absService.sendenAnfrage(this.d.getDialogId(), this.bewilligungsAnfrage, this.d.getReader().id, null);
                this.statusBewilligung();
                antwortNachricht.Text = "Anfrage erfolgreich gesendet.";
                //Console.WriteLine("ABS Erfolg");
            }
            catch (Exception exception)
            {
                antwortNachricht.Text = exception.Message.ToString();
                Console.WriteLine(exception.ToString());
            }

        }

        private void statusBewilligung()
        {
            if(this.anfrageAntwort == null)
            {
                return;
            }
            ABSRef.statusBewilligungsAnfrage[] statusBewilligungsAnfrage = this.absService.getStatusBewilligungsAnfragen(this.d.getDialogId(), null);
            List<string> test = new List<string>();
 
            foreach(var x in statusBewilligungsAnfrage)
            {
                // x.anfrageId;
               test.Add(x.anfrageId);
            }
            statusBewilligungsAnfrageAuswahl.Items.AddRange(test.ToArray());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rueckantwortButton_Click(object sender, EventArgs e)
        {
            ABSRef.rueckantwort rueckantwort = this.absService.getRueckantwort(this.d.getDialogId(), statusBewilligungsAnfrageAuswahl.SelectedItem.ToString());
            antwortNachricht.Text = rueckantwort.anfrageEntscheide[0].infoText;
            rueckantwortEntscheid.Text = rueckantwort.anfrageEntscheide[0].verordnungsEntscheidung;
            rueckantwortPackungszahl.Text = "Bewilligte Packungszahl: " + rueckantwort.anfrageEntscheide[0].bewilligtePackungsanzahl.ToString();
            rueckantwortMedikament.Text = "Bewilligtes Medikament: " + rueckantwort.anfrageEntscheide[0].bewilligtesMedikament.name;
        }

        private void ABSWindow_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void antwortNachricht_Click(object sender, EventArgs e)
        {

        }
    }
}
