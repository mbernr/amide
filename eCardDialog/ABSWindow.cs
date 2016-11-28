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
        //      bewilligungsAnfrage.setAntragstyp(java.lang.String antragstyp) 
                    //ARZTBRIEF
                    //Kennzeichnung einer Bewilligungsanfrage im Rahmen einer Arztbrieferstellung.
                    //REZEPT
                    //Kennzeichnung einer Bewilligungsanfrage im Rahmen einer Rezeptausstellung.
        //      bewilligungsAnfrage.setPatientenDaten(PatientenDaten patientenDaten) 
        //      bewilligungsAnfrage.setVerordnerinformation(java.lang.String verordnerinformation)
                    //optional 
        //      bewilligungsAnfrage.setVerordnungen(Verordnung[] verordnungen) 

        public ABSWindow(Dialog d, card eCard)
        {
            InitializeComponent();
            this.d = d;
            this.eCard = eCard;
            this.absService.Url = "https://10.196.4.114/abs/11";  
        }

        private void sendenAnfrage_Click(object sender, EventArgs e)
        {
            try
            {
                this.absService.sendenAnfrage(this.d.getDialogId(), this.bewilligungsAnfrage, this.d.getReader().id, null);
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
