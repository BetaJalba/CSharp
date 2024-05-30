using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsercizioSedeLZ
{
    public partial class FormSede : Form
    {
        public FormSede()
        {
            InitializeComponent();
        }

        string responsabile, indirizzo, citta, regione;
        public CSede Sede { get; private set; } //sede da passare

        private void FormSede_Load(object sender, EventArgs e)
        {

        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            //controlli
            string msg = string.Empty;

            if (txtName.TextLength == 0)
                msg += "Inserire nome!!!\n";
            if (txtAddr.TextLength == 0)
                msg += "Inserire indirizzo!!!\n";
            if (txtCit.TextLength == 0)
                msg += "Inserire citta\'!!!\n";
            if (txtReg.TextLength == 0)
                msg += "Inserire regione!!!\n";

            if (msg != string.Empty)
            {
                MessageBox.Show(msg);
                return;
            }

            //fine controlli

            responsabile = txtName.Text;
            indirizzo = txtAddr.Text;
            citta = txtCit.Text;
            regione = txtReg.Text;

            Sede = new CSede(responsabile, indirizzo, citta, regione); //inizializzazione oggetto

            DialogResult = DialogResult.OK;
        }

        private void btnCnc_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
