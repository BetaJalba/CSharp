using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsOrchestra
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string nome;
        string tipologia;
        float prezzo;
        int annoProduzione;
        public CStrumento strumento { get; private set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0'; //non ci si può scrivere
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntConf_Click(object sender, EventArgs e)
        {
            //controlli
            string msg = string.Empty;

            if (txtName.TextLength == 0)
                msg += "Inserire Nome!!!\n";
            if (ctrlTipo.SelectedIndex == -1)
                msg += "Inserire Tipologia!!!\n";
            if (txtPrz.TextLength == 0)
                msg += "Inserire Prezzo!!!\n";
            if (txtYear.TextLength == 0 || int.Parse(txtYear.Text) > DateTime.Now.Year)
                msg += "Inserire un anno valido!!!";

            if (msg != string.Empty)
            {
                MessageBox.Show(msg);
                return;
            }

            //fine controlli

            nome = txtName.Text;
            tipologia = ctrlTipo.Text;
            prezzo = float.Parse(txtPrz.Text);
            annoProduzione = int.Parse(txtYear.Text);

            strumento = new CStrumento(nome, tipologia, prezzo, annoProduzione); //si passa l'oggetto

            DialogResult = DialogResult.OK;
        }

        bool hasVirgola = false;
        private void txtPrz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != 8 && e.KeyChar != 46)
                e.KeyChar = '\0';

            if (e.KeyChar == 46 && txtPrz.Text.Length == 0)
                e.KeyChar = '\0';
            else
            {
                hasVirgola = true;
            }

            if (!txtPrz.Text.Contains('.'))
                hasVirgola = false;

            if (e.KeyChar == 46 && txtPrz.Text.Contains((char)44))
                e.KeyChar = '\0';

            if (hasVirgola)
                txtPrz.MaxLength = txtPrz.Text.IndexOf('.') + 3;
            else
                txtPrz.MaxLength = int.MaxValue;
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != 8)
                e.KeyChar = '\0';
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
