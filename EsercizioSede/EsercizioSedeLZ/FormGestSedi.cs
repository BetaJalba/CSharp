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
    public partial class FormGestSedi : Form
    {
        public FormGestSedi(List<CSede> sedi)
        {
            InitializeComponent();
            this.sedi = sedi;
        }

        List<CSede> sedi; //tenere le sedi in questo form di base avrebbe più senso ma il form è strutturato in base
        //alla gestione della singola sede oramai
        public int NewSede { get; private set; }

        private void FormGestSedi_Load(object sender, EventArgs e)
        {
            updateListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSede formAdd = new FormSede();
            formAdd.ShowDialog();

            if (formAdd.DialogResult == DialogResult.OK)
            {
                sedi.Add(formAdd.Sede);
                formAdd.Close(); //aggiunge lo strumento e chiude il secondo form
                updateListBox();
            }
            else if (formAdd.DialogResult == DialogResult.Cancel || formAdd.DialogResult == DialogResult.No) //se si decide di chiudere il programma esce completamente
            {
                formAdd.Close();
            }
        }

        private void updateListBox()
        {
            listBox1.Items.Clear();

            foreach (CSede sede in sedi)
            {
                listBox1.Items.Add(sede.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Segliere una sede!");
            else
            {
                NewSede = listBox1.SelectedIndex;
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Segliere una sede!");
            else
            {
                sedi.Remove(sedi[listBox1.SelectedIndex]);
                updateListBox();
            }
        }
    }
}
