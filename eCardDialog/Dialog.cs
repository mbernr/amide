using eCardDialog.BaseRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCardDialog
{
    public class Dialog
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

        public String createDialog()
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

        public String getDialogId()
        {
            return this.dialogId;
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
            //Console.ReadLine();
        }

        public void setOrdination()
        {
            this.ordinationen = partner.ordination;
        }

        public ordination[] getOrdination()
        {
            return this.ordinationen;
        }

        public void createAndAuthenticateDialog()
        {
            this.dialogId = createDialog();   //createDialog
            getVertragspartner();	    //authenticateDialog
            setOrdination();
            setTaetigkeitsbereich();
            setDialogAddress();
            //bla();
        }

        public cardReader getReader()
        {
            return this.reader;
        }

        public taetigkeitsBereich getBereich()
        {
            return this.bereich;
        }

        public BaseService getBaseService()
        {
            return this.baseService;
        }

        ~Dialog()
        {
            this.baseService.closeDialog(this.dialogId);
        }



    }
}
