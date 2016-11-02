using eCardDialog.BaseRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCardDialog
{
    class Dialogcreate
    {
        private BaseService baseService;
        private cardReader reader;
        private cardReader[] readers;
        private vertragspartnerV2 partner;
        private produktInfo myInfo;
        private String dialogId;
        private card myCard;
        private ordination[] ordinationen;
        taetigkeitsBereich bereich;

        public String getDialogID()
        {
            baseService = new BaseService();
            baseService.Url = "https://10.196.4.114/base/15";
            readers = baseService.getCardReaders();
            reader = readers[0];
            myInfo = new produktInfo();
            myInfo.produktId = 900101;
            myInfo.produktVersion = "0.0.1";
            myInfo.produktIdSpecified = true;
            myCard = baseService.getCardData(reader.id);
            return baseService.createDialog(reader.id, myInfo, null, true, true);
        }

        public void getVertragspartner()
        {
            partner = baseService.authenticateDialog(dialogId, myCard.cin, "1122", reader.id);
        }

        public void setTaetigkeitsbereich()
        {
            bereich = ordinationen[0].taetigkeitsBereich[0];
        }

        public void setDialogAddress()
        {
            baseService.setDialogAddress(dialogId, ordinationen[0].ordinationId, bereich.id, null, null, null);
            property[] test = baseService.checkStatus(dialogId);
            test = baseService.checkStatus(dialogId);
            Console.WriteLine("Dialog aufgebaut" + " Dialog-Status: " + test[0].value);
            Console.ReadLine();
        }

        public void setOrdination()
        {
            this.ordinationen = partner.ordination;
        }

        public void createDialog()
        {
            dialogId = getDialogID();   //createDialog
            getVertragspartner();	    //authenticateDialog
            setOrdination();
            setTaetigkeitsbereich();
            setDialogAddress();
            bla();
        }

        public void bla()
        {
            //KSE Abfrage
            Console.ReadLine();
            card eCard = baseService.getCardData(reader.id);
            baseProperty[] prop = baseService.getFachgebieteByOrdId(dialogId, ordinationen[0].ordinationId, bereich.id);
            Console.WriteLine("getFachgebieteByOrdId funktioniert");
            Console.ReadLine();

            KSERef.KseService kseService = new KSERef.KseService();
            kseService.Url = "https://10.196.4.114/kse/17";
            KSERef.behandlungsfallZusatzProperty[] behandlungsfall = kseService.getBehandlungsfaelleByFachgebietZusatz("01");

            KSERef.baseProperty[] behandlungsfallCode = kseService.getBehandlungsfaelle();

            Console.WriteLine(behandlungsfall[0]);
            Console.ReadLine();

            svtProperty[] svtProp = baseService.getSVTs();
            Console.WriteLine(svtProp[0]);
            Console.ReadLine();

            KSERef.ergebnisKonsultation ergebnisKonstultation = kseService.doKonsultation(eCard.cin, dialogId, eCard.nummer, svtProp[0].code, null, prop[0].code, behandlungsfallCode[0].code,null,null,true, true,reader.id);

            baseService.closeDialog(dialogId);
        }
    }
}
