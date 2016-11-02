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

            baseProperty[] prop = d.getBaseService().getFachgebieteByOrdId(d.getDialogId(), d.getOrdination()[0].ordinationId, d.getBereich().id);
            Console.WriteLine("getFachgebieteByOrdId funktioniert");
            //Console.ReadLine();
/*
            KSERef.KseService kseService = new KSERef.KseService();
            kseService.Url = "https://10.196.4.114/kse/17";
            KSERef.behandlungsfallZusatzProperty[] behandlungsfall = kseService.getBehandlungsfaelleByFachgebietZusatz("01");

            KSERef.baseProperty[] behandlungsfallCode = kseService.getBehandlungsfaelle();

            Console.WriteLine(behandlungsfall[0]);
            //Console.ReadLine();

            svtProperty[] svtProp = d.getBaseService().getSVTs();
            //Console.WriteLine(svtProp[0]);
            //Console.ReadLine();

            KSERef.ergebnisKonsultation ergebnisKonstultation = kseService.doKonsultation(eCard.cin, d.getDialogID(), eCard.nummer, svtProp[0].code, null, prop[0].code, behandlungsfallCode[0].code, null, null, true, true, d.getReader().id);
            */
            d.getBaseService().closeDialog(d.createDialog());
            
        }
    }
}
