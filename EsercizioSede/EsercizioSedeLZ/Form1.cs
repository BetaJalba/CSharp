using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.DataFormats;

namespace EsercizioSedeLZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //il form1 è blindato comunque, credo

        //private System.Threading.Timer autoSave; //salva sul JSON in automatico (troppo avanti questa idea per questo progetto)(non che non riesca a farlo ;))
        List<CSede> sedi; //lista sedi

        CSede currentSede; //sede corrente, la prima tra tutte le disponibili all'avvio del programma
        //l'assegnazione funziona perché in assegnazione l'oggetto viene passato per reference, quindi modificando il corrente si
        //modifica anche quello nella lista
        int currenteSedeIndx;
        bool hasSede;

        DirectoryInfo dirinf;
        string pathname;


        private void Form1_Load(object sender, EventArgs e)
        {
            sedi = new List<CSede>();

            pathname = Directory.GetCurrentDirectory();
            dirinf = new DirectoryInfo(pathname);

            pathname = dirinf.Parent.Parent.FullName + @"\Pippo.json";

            //autoSave = new System.Threading.Timer(eseguiFunzione => update());
            //autoSave.Change(0, (20 * 1000) /* ogni 20 secondi */);

            if (File.Exists(pathname))
            {
                if (File.ReadAllLines(pathname).Length > 2) //se il file contiene qualcosa
                {
                    sedi = JsonConvert.DeserializeObject<List<CSede>>(File.ReadAllText(pathname)); //il verdino mente
                }
            }

            if (!sedi.Any())
            {
                //prompta la creazione di una nuova sede
                MessageBox.Show("Salve nuovo utente, prima di tutto crei una sede!");
                hasSede = false; //controlla se ha una sede
            }
            else
                hasSede = true;

            do
            {
                if (!hasSede) //procede con la creazione di una sede
                {
                    FormSede formAdd = new FormSede();
                    formAdd.ShowDialog();

                    if (formAdd.DialogResult == DialogResult.OK)
                    {
                        sedi.Add(formAdd.Sede);
                        hasSede = true;
                        formAdd.Close(); //aggiunge lo strumento e chiude il secondo form
                    }
                    else if (formAdd.DialogResult == DialogResult.No) //inutile ma lo tengo comunque
                    {
                        formAdd.Close();
                        MessageBox.Show("Prima sede obbligatoria");
                    }
                    else if (formAdd.DialogResult == DialogResult.Cancel) //se si decide di chiudere il programma esce completamente
                    {
                        hasSede = true;
                        formAdd.Close();
                        this.Close();
                    }
                }
            } while (!hasSede); //creazione prima sede obbligatoria

            currentSede = sedi.First();
            currenteSedeIndx = sedi.IndexOf(currentSede);

            lblInfo.Text = $"Sede ID: {currentSede.SedeId}"; //da rendere una funzione a parte
            updateListBox(); //aggiorna la list box
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            Form2 formAdd = new Form2();
            formAdd.ShowDialog();

            if (formAdd.DialogResult == DialogResult.OK)
            {
                currentSede.AddAuto(formAdd.Auto);
                formAdd.Close(); //aggiunge lo strumento e chiude il secondo form
                updateListBox(); //aggiorna la list box
            }
            else if (formAdd.DialogResult == DialogResult.Cancel) //inutile ma lo tengo comunque
            {
                formAdd.Close();
            }
        }

        private void btnSede_Click(object sender, EventArgs e)
        {
            FormGestSedi formAdd = new FormGestSedi(sedi);
            formAdd.ShowDialog();

            if (formAdd.DialogResult == DialogResult.OK)
            {
                currenteSedeIndx = formAdd.NewSede;
                currentSede = sedi[currenteSedeIndx];

                lblInfo.Text = $"Sede ID: {currentSede.SedeId}"; //da rendere una funzione a parte
                updateListBox(); //aggiorna la list box
            }
        }

        private void btnOrdn_Click(object sender, EventArgs e)
        {
            //preferisco farlo nella classe direttamente
            currentSede.OrdinaAuto();
            updateListBox();
        }

        public void updateListBox()
        {
            listBox1.Items.Clear();

            string[] items = currentSede.updateListBox();

            for (int i = 0; i < items.Length; i++)
            {
                listBox1.Items.Add(items[i]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            if (sedi != null)
            {
                string jsonSedi = JsonConvert.SerializeObject(sedi, Newtonsoft.Json.Formatting.Indented);
                if (!File.Exists(pathname))
                {
                    File.Create(pathname).Close(); //crea il file
                }
                File.WriteAllText(pathname, jsonSedi); //ci scrive il json

                MessageBox.Show("File salvato successamente!!1!");
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                MessageBox.Show("Aggiungi un'auto!");
            else if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Scegli un'auto!!");
            else
            {
                currentSede.EliminaAuto(currentSede._parcoAuto[listBox1.SelectedIndex]);
                updateListBox();
            }
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                MessageBox.Show("Aggiungi un'auto!");
            else if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Scegli un'auto!!");
            else
            {
                FormAuto formAdd = new FormAuto(currentSede._parcoAuto[listBox1.SelectedIndex]); //passa la sede corrente
                formAdd.ShowDialog();

                if (formAdd.DialogResult == DialogResult.Cancel)
                    updateListBox(); //quando la finestra viene chiusa aggiornare la listbox
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                MessageBox.Show("Aggiungi un'auto!");
            else if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Scegli un'auto!!");
            else
            {
                CAutomobile auto = currentSede._parcoAuto[listBox1.SelectedIndex];
                FormTrasfer formAdd = new FormTrasfer(sedi); //passa la lista di sedi e l'auto eliminata
                formAdd.ShowDialog();

                if (formAdd.DialogResult == DialogResult.OK)
                {
                    currentSede.EliminaAuto(auto); //elimina l'auto nella sede corrente

                    currenteSedeIndx = formAdd.SedeIndx; //cambia sede
                    currentSede = sedi[currenteSedeIndx];
                    
                    currentSede.AddAuto(auto); //aggiunge l'auto

                    lblInfo.Text = $"Sede ID: {currentSede.SedeId}"; //da rendere una funzione a parte (magari)
                    updateListBox(); //aggiorna la list box
                }
                else if (formAdd.DialogResult == DialogResult.Cancel)
                {
                    updateListBox(); //quando la finestra viene chiusa aggiornare la listbox
                }
            }
        }
    }
}
