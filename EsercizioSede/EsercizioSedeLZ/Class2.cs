using System.CodeDom.Compiler;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSedeLZ
{
    public class CSede
    {
        public string Responsabile { get; }
        public string Indirizzo { get; }
        public string Citta { get; }
        public string Regione { get; }

        static int count = 0;
        int sedeId;
        public List<CAutomobile> _parcoAuto {  get; private set; }
        public string SedeId
        {
            get
            {
                string r = string.Empty;

                //restituisce uhn valore contenente sempre 4 cifre
                if (sedeId < 10)
                    r += "000";
                else if (sedeId < 100)
                    r += "00";
                else if (sedeId < 1000)
                    r += "0";

                r += sedeId.ToString();

                return r;
            }
        }

        public CSede(string responsabile, string indirizzo, string citta, string regione)
        {
            this.Responsabile = responsabile;
            this.Indirizzo = indirizzo;
            this.Citta = citta;
            this.Regione = regione;
            this.sedeId = count;
            count++;
            _parcoAuto = new List<CAutomobile>();
        }

        public override string ToString()
        {
            return $"ID: {SedeId} --->\tIndirizzo: {Indirizzo}\tCittà: {Citta}\tRegione: {Regione}";
        }

        public void AddAuto(CAutomobile auto)
        {
            _parcoAuto.Add(auto);
        }

        public string[] updateListBox()
        {
            string[] r = new string[_parcoAuto.Count];
            int count = 0;

            foreach (var auto in _parcoAuto)
            {
                r[count] = auto.ToStringForList();
                count++;
            }

            return r;
        }

        public void EliminaAuto(CAutomobile auto)
        {
            _parcoAuto.Remove(auto); //si seleziona un'auto dal parcoauto quindi ci sarà sempre
        }

        public void OrdinaAuto()
        {
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = 1; i < _parcoAuto.Count; i++)
                {
                    if (_parcoAuto[i].Targa.CompareTo(_parcoAuto[i - 1].Targa) < 0)
                    {
                        Swap(i, i - 1);
                        sorted = false;
                    }
                }
            }
        }

        private void Swap(int indx1, int indx2)
        {
            CAutomobile temp = _parcoAuto[indx1];
            _parcoAuto[indx1] = _parcoAuto[indx2];
            _parcoAuto[indx2] = temp;
        }
    }
}
