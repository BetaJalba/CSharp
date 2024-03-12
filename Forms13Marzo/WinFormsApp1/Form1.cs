namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //esercizio 1
        private void BTN1_Click(object sender, EventArgs e)
        {
            int n;
            int div;
            float ris;
            int m = 0;
            int M = 4;

            //assegnazione input
            try
            {
                n = Convert.ToInt32(TXT1.Text);
            }

            catch (FormatException)
            {
                LBLERR.Text = "Errore: non un Integer.";
                ResetError();
                return; //chiude la funzione
            }

            finally
            {
                TXT1.Text = "";
            }

            //generazione numero randomico
            Random rand = new Random();
            div = rand.Next(m, M);

            try
            {
                ris = n / div;
            }

            catch (DivideByZeroException)
            {
                LBLRIS.Text = "Risultato: ";
                LBLERR.Text = "Errore: divisione per 0.";
                ResetError();
                return; //chiude la funzione
            }

            LBLRIS.Text = $"Risultato: {n}:{div} = {ris}";

        }

        async void ResetError()
        {
            //riporta la label allo stato originale dopo 3 secondi
            await Task.Delay(TimeSpan.FromSeconds(3));
            LBLERR.Text = "Errore: nessuno.";
        }

        //esercizio 2
        int[] nums = new int[5];
        private void BTN2_Click(object sender, EventArgs e)
        {
            int indx;
            int n;

            //assegnazione input
            try
            {
                n = Convert.ToInt32(TXT2.Text);
                indx = Convert.ToInt32(TXT3.Text);
            }

            catch (FormatException)
            {
                LBLERR2.Text = "Errore: non un Integer.";
                ResetError2();
                return; //chiude la funzione
            }

            finally
            {
                TXT2.Text = "";
                TXT3.Text = "";
            }

            try
            {
                nums[indx] = n;
            }

            catch (IndexOutOfRangeException)
            {
                LBLERR2.Text = "Errore: index fuori dall'array.";
            }

            LBLARR.Text = "Array: ";
            for (int i = 0; i < nums.Length; i++)
            {
                LBLARR.Text = String.Concat(LBLARR.Text, String.Concat(nums[i], "  "));
            }
        }

        async void ResetError2()
        {
            //riporta la label allo stato originale dopo 3 secondi
            await Task.Delay(TimeSpan.FromSeconds(3));
            LBLERR2.Text = "Errore: nessuno.";
        }
    }
}
