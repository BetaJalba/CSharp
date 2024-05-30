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
    public partial class FormTrasfer : Form
    {
        public FormTrasfer(List<CSede> sedi)
        {
            InitializeComponent();
            this.sedi = sedi;
        }

        List<CSede> sedi;
        public int SedeIndx { get; private set; }

        //praticamente una versione troncata di gestione sedi (form)
        private void FormTrasfer_Load(object sender, EventArgs e)
        {
            updateListBox();
        }
        private void updateListBox()
        {
            listBox1.Items.Clear();

            foreach (CSede sede in sedi)
            {
                listBox1.Items.Add(sede.ToString());
            }
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Segliere una sede!");
            else
            {
                SedeIndx = listBox1.SelectedIndex;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
