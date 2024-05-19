using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class COrchestra
    {
        List<CStrumento> strumenti;
        DateTime lastConc;

        public COrchestra(DateTime lastConc)
        {
            this.lastConc = lastConc;
            strumenti = new List<CStrumento>();
        }

        public COrchestra()
        {
            lastConc = DateTime.Now;
            strumenti = new List<CStrumento>();
        }

        public override string ToString()
        {
            string r = string.Join("\n", strumenti.Select((strumento, index) => new StringBuilder ($"Posizione: {index}\t{strumento}")));
            return r;
        }

        public string Costo(string tipologia)
        {
            tipologia = tipologia.Trim().ToLower();

            float r = 0.00f;
            int count = 0;

            foreach (var strumento in strumenti)
            {
                if (strumento.Tipologia == tipologia)
                {
                    r += strumento.costo;
                    count++;
                }
            }

            r /= count;

            r = (float)Math.Round(r, 2);

            return $"Il costo medio degli strumenti di tipologia {tipologia} è: {r}";
        }

        public void AddStrumento(CStrumento strumento)
        {
            strumenti.Add(strumento);
        }

        public void EliminaStrumento(string nome)
        {
            nome = nome.Trim().ToLower();

            foreach (var strumento in strumenti)
            {
                if (strumento.Nome == nome.ToLower())
                {
                    strumenti.Remove(strumento);
                    return;
                }
            }
        }

        public void Ordina()
        {
            bool ordinato;

            do
            {
                ordinato = true;

                for (int i = 1; i < strumenti.Count; i++)
                {
                    if (strumenti[i].Nome.CompareTo(strumenti[i - 1].Nome) < 0)
                    {
                        Swap(i, i - 1);
                        ordinato = false;
                    }  
                }
            } while (!ordinato);
        }

        private void Swap(int indx1, int indx2)
        {
            var temp = strumenti[indx1];
            strumenti[indx1] = strumenti[indx2];
            strumenti[indx2] = temp;
        }
    }
}
