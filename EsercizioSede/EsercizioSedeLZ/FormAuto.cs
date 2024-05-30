using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EsercizioSedeLZ
{
    public partial class FormAuto : Form
    {
        public FormAuto(CAutomobile currentAuto)
        {
            InitializeComponent();
            this.currentAuto = currentAuto;
        }

        CAutomobile currentAuto;

        bool hasVirgola = false;
        private void txtDrive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != 8 && e.KeyChar != 46)
                e.KeyChar = '\0';

            if (e.KeyChar == 46 && textBox1.Text.Length == 0)
                e.KeyChar = '\0';
            else
            {
                hasVirgola = true;
            }

            if (!textBox1.Text.Contains('.'))
                hasVirgola = false;

            if (e.KeyChar == 46 && textBox1.Text.Contains((char)44))
                e.KeyChar = '\0';

            if (hasVirgola)
                textBox1.MaxLength = textBox1.Text.IndexOf('.') + 3;
            else
                textBox1.MaxLength = int.MaxValue;
        }

        private void txtRefill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != 8 && e.KeyChar != 46)
                e.KeyChar = '\0';

            if (e.KeyChar == 46 && textBox2.Text.Length == 0)
                e.KeyChar = '\0';
            else
            {
                hasVirgola = true;
            }

            if (!textBox2.Text.Contains('.'))
                hasVirgola = false;

            if (e.KeyChar == 46 && textBox2.Text.Contains((char)44))
                e.KeyChar = '\0';

            if (hasVirgola)
                textBox2.MaxLength = textBox2.Text.IndexOf('.') + 3;
            else
                textBox2.MaxLength = int.MaxValue;
        }

        private void button1_Click(object sender, EventArgs e) //bottone guida
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Inserire distanza!");
                return;
            }

            try
            {
                currentAuto.Drive(int.Parse(textBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBox1.Text = null;
                updateLabel();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Inserire distanza!");
                return;
            }

            currentAuto.Rifornimento(int.Parse(textBox2.Text));

            textBox2.Text = null;
            updateLabel();
        }

        private void updateLabel()
        {
            label1.Text = currentAuto.ToString();
        }

        private void FormAuto_Load_1(object sender, EventArgs e)
        {
            updateLabel();
        }
    }
}
