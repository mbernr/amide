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
    public partial class KSE : Form
    {
        public KSE(Dialog d, card eCard)
        {
            InitializeComponent();

            KSERef.KseService kseService = new KSERef.KseService();
            kseService.Url = "https://10.196.4.114/kse/17";

            baseProperty fachgebiet = d.getBaseService().getFachgebieteByOrdId(d.getDialogId(), d.getOrdination()[0].ordinationId, d.getBereich().id)[0];

            KSERef.baseProperty[] behandlungsfalle = kseService.getBehandlungsfaelle();

            svtProperty[] svtProp = d.getBaseService().getSVTs();

            KSERef.ergebnisKonsultation ergebnisKonstultation = kseService.doKonsultation(eCard.cin, d.getDialogId(), eCard.nummer, svtProp[0].code, null, fachgebiet.code, behandlungsfalle[0].code, null, null, true, true, d.getReader().id);

            fachgebietLabel.Text = fachgebiet.text;
            behandlungsfallLabel.Text = behandlungsfalle.Length.ToString();
            konsultationsdatenLabel.Text = ergebnisKonstultation.konsultationsDaten.ToString();
        }

        public void fachbereiche_Click(object sender, System.EventArgs e)
        {

        }

        public void label1_Click(object sender, System.EventArgs e)
        {

        }

        public void label2_Click(object sender, System.EventArgs e)
        {

        }

    }


}
