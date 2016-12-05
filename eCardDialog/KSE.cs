using eCardDialog.BaseRef;
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
    public partial class KSE : Form
    {

        private KSERef.KseService kseService;
        private Dialog dialog;
        private card eCard;
        private baseProperty[] allFachgebiete;
        private baseProperty fachgebiet;
        private KSERef.baseProperty[] allBehandlungsfaelle;
        private KSERef.baseProperty behandlungsfall;
        private svtProperty[] allKvts;
        private svtProperty kvt;

        public KSE(Dialog dialog, card eCard)
        {
            InitializeComponent();

            this.kseService = new KSERef.KseService();
            this.kseService.Url = "https://10.196.4.114/kse/17";
            this.dialog = dialog;
            this.eCard = eCard;

            this.getDataFromWebservice();
        }

        private void doKonsultationButton_Click(object sender, EventArgs e)
        {
            konsultationsdatenLabel.Text = "";
            this.getSelectedData();
            this.tryToDoKonsultation();        
        }

        private void tryToDoKonsultation()
        {
            try
            {
                KSERef.ergebnisKonsultation ergebnisKonstultation = kseService.doKonsultation(eCard.cin, dialog.getDialogId(), eCard.nummer, this.kvt.code, null, this.fachgebiet.code, this.behandlungsfall.code, null, null, true, true, dialog.getReader().id);
                konsultationsdatenLabel.Text = "Konsultation erfolgreich";
            }
            catch (SoapException ex)
            {
                konsultationsdatenLabel.Text = "Fehler: " + ex.Detail.InnerText;
            }
        }

        private void getDataFromWebservice()
        {
            this.getFachgebieteAndWriteThemIntoComboBox();
            this.getBehandlungsfaelleAndWriteThemIntoComboBox();
            this.getKvtsAndWriteThemIntoComboBox();
        }

        private void getFachgebieteAndWriteThemIntoComboBox()
        {
            this.allFachgebiete = dialog.getBaseService().getFachgebieteByOrdId(dialog.getDialogId(), dialog.getOrdination()[0].ordinationId, dialog.getBereich().id);
            foreach (baseProperty tempFachgebiet in this.allFachgebiete)
            {
                fachgebieteComboBox.Items.Add(tempFachgebiet.text);
            }
            fachgebieteComboBox.Sorted = true;
            fachgebieteComboBox.SelectedIndex = 0;
            this.fachgebiet = this.allFachgebiete[0];
        }

        private void getBehandlungsfaelleAndWriteThemIntoComboBox()
        {          
            this.allBehandlungsfaelle = kseService.getBehandlungsfaelleByFachgebiet(this.fachgebiet.code);
            foreach (KSERef.baseProperty tempBehandlungsfall in this.allBehandlungsfaelle)
            {
                behandlungsfaelleComboBox.Items.Add(tempBehandlungsfall.text);
            }
            behandlungsfaelleComboBox.Sorted = true;
            behandlungsfaelleComboBox.SelectedIndex = 0;
        }

        private void getKvtsAndWriteThemIntoComboBox()
        {
            this.allKvts = dialog.getBaseService().getSVTs();
            foreach (svtProperty tempKvt in this.allKvts)
            {
                svtProperitesComboBox.Items.Add(tempKvt.text);
            }
            svtProperitesComboBox.Sorted = true;
            svtProperitesComboBox.SelectedIndex = 0;
        }

        private void getSelectedData()
        {
            this.getSelectedFachgebiet();
            this.getSelectedBehandlungsfall();
            this.getSelectedKvt();
        }

        private void getSelectedFachgebiet()
        {
            foreach (baseProperty tempFachgebiet in this.allFachgebiete)
            {
                if (tempFachgebiet.text.Equals(fachgebieteComboBox.SelectedItem))
                {
                    this.fachgebiet = tempFachgebiet;
                    break;
                }
            }
        }

        private void getSelectedBehandlungsfall()
        {
            foreach (KSERef.baseProperty tempBehandlungsfall in this.allBehandlungsfaelle)
            {
                if (tempBehandlungsfall.text.Equals(behandlungsfaelleComboBox.SelectedItem))
                {
                    this.behandlungsfall = tempBehandlungsfall;
                    break;
                }
            }
        }

        private void getSelectedKvt()
        {
            foreach (svtProperty tempKvt in this.allKvts)
            {
                if (tempKvt.text.Equals(svtProperitesComboBox.SelectedItem))
                {
                    this.kvt = tempKvt;
                    break;
                }
            }
        }

        private void KSE_Load(object sender, EventArgs e)
        {

        }

    }


}
