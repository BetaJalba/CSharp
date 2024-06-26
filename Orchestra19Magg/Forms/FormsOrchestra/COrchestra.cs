﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrchestra
{
    public class COrchestra
    {
        public List<CStrumento> strumenti { get; private set; }
        public DateTime lastConc { get; }

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

        public string[] updateListBox()
        {
            string[] r = new string[strumenti.Count];
            int count = 0;

            foreach (var strumento in strumenti)
            {
                r[count] = strumento.ToString();
                count++;
            }

            return r;
        }

        public string Costo(string tipologia)
        {
            tipologia = tipologia.Trim().ToLower();

            float r = 0.00f;
            int count = 0;

            foreach (var strumento in strumenti)
            {
                if (strumento.tipologia.ToLower() == tipologia)
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
                if (strumento.nome.ToLower() == nome.ToLower())
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
                    if (strumenti[i].nome.ToLower().CompareTo(strumenti[i - 1].nome.ToLower()) < 0)
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
