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
        public SASWindow(Dialog d, card eCard)
        {
            InitializeComponent();
            SasRef.SasService sasService = new SasRef.SasService();
            sasService.Url = "https://10.196.4.114/sas/12";
            suchkriterien kriterien = new suchkriterien();
            kriterien.familienname = "Musterpatient";
            kriterien.vorname = "Max";
            kriterien.geburtsdatum = "25.11.1970";
            abfrageErgebnis ergebnis  = sasService.svNummerAbfragen(d.getDialogId(), kriterien);
            
        }
    }
}
