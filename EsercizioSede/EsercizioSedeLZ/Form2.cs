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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        float consumo;
        int serbatoio;
        string targa;
        public CAutomobile Auto { get; private set; }

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
                msg += "Inserire targa!!!\n";
            if (txtPrz.TextLength == 0)
                msg += "Inserire consumo!!!\n";
            if (txtYear.TextLength == 0 || int.Parse(txtYear.Text) > 60)
                msg += "Inserire capacità valida!!!";

            if (msg != string.Empty)
            {
                MessageBox.Show(msg);
                return;
            }

            //fine controlli

            targa = txtName.Text;
            consumo = float.Parse(txtPrz.Text);
            serbatoio = int.Parse(txtYear.Text);

            Auto = new CAutomobile(consumo, targa, serbatoio); //si inizializza l'oggetto

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

        private void txtYear_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtYear.Text.Length > 0 && int.Parse(txtYear.Text) > 60)
                txtYear.Text = "60";
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
