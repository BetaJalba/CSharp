
namespace FormsOrchestra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private System.Threading.Timer autoSave = new System.Threading.Timer(eseguiFunzione => update()); //salva sul JSON in automatico
        COrchestra orchestra; //orchestra non inizializzata

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 formAdd = new Form2();
            formAdd.ShowDialog();

            if (formAdd.DialogResult == DialogResult.OK)
            {
                orchestra.AddStrumento(formAdd.strumento);
                formAdd.Close(); //aggiunge lo strumento e chiude il secondo form
                updateListBox(); //aggiorna la list box
            }
            else if (formAdd.DialogResult == DialogResult.Cancel)
            {
                formAdd.Close();
            }
        }

        private void btnOrcstr_Click(object sender, EventArgs e)
        {
            orchestra = new COrchestra(dateTimePicker1.Value);
            panel2.Visible = false;
            panel1.Visible = true; //cambia la visibilità dei due panel
        }

        public void updateListBox()
        {
            listBox1.Items.Clear();

            string[] items = orchestra.updateListBox();

            for (int i = 0; i < items.Length; i++)
            {
                listBox1.Items.Add(items[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autoSave.Change(0, (20 * 1000) /* ogni 20 secondi */);
        }

        private static void update()
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                orchestra.EliminaStrumento(orchestra.strumenti[listBox1.SelectedIndex].Nome);
                updateListBox();
                //passa all'elimina strumento il nome dell'oggetto nell'index scelto della
                //listbox (in quanto per la funzione updateListBox() sono resi paralleli 
                //array e lista)
            }
            else
                MessageBox.Show("Scegliere lo strumento da rimuovere!");
        }

        private void btnSrt_Click(object sender, EventArgs e)
        {
            orchestra.Ordina();
            updateListBox();
            //molto pulito :)
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                MessageBox.Show(orchestra.Costo(orchestra.strumenti[listBox1.SelectedIndex].Tipologia));
                updateListBox();
            }
            else
                MessageBox.Show("Scegliere la tipologia da analizzare!");
        }
    }
}
