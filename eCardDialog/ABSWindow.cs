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
            antragstyp.Items.Add("ARZTBRIEF");
            antragstyp.Items.Add("REZEPT");
            this.bewilligungsAnfrage.patientenDaten = this.createPatientenDaten(eCard);
            var verordnungen = new List<ABSRef.verordnung>();
            verordnungen.Add(this.createVerordnung());
            this.bewilligungsAnfrage.verordnungen = verordnungen.ToArray();
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
            medikament.name = "Axt";
            verordnung.medikament = medikament;
            verordnung.packungsanzahl = 5;
            verordnung.diagnose = "knie an'ghaut :(";
            verordnung.begruendung = "pfft";
            
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
                this.anfrageAntwort =  this.absService.sendenAnfrage(this.d.getDialogId(), this.bewilligungsAnfrage, this.d.getReader().id, null);
                Console.WriteLine("ABS Erfolg");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                //TODO: Better error handling;
                //          throws ServiceException,
                //                 CardException,
                //                 DialogException,
                //                 InvalidParameterBewilligungsanfrageException,
                //                 AbsException,
                //                 AccessException
            }

        }
    }
}
