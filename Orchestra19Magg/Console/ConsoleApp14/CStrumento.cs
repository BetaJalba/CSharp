using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class CStrumento
    {
        string nome;
        string tipologia;
        public float costo { get; }
        int annoFabbricazione { get; }

        public string Nome
        {
            get
            { return nome.ToLower(); } //nome = Nome = NOME
        }

        public string Tipologia
        {
            get
            { return tipologia.ToLower(); } //tipologia = Tipologia = TIPOLOGIA
        }

        public CStrumento(string nome, string tipologia, float costo, int annoFabbricazione)
        {
            this.nome = nome;
            this.tipologia = tipologia;
            this.costo = (float)Math.Round(costo, 2); //arrotonda a 2 cifre decimali
            this.annoFabbricazione = annoFabbricazione;
        }

        public override string ToString()
        {
            return $"Nome: {Tronca(nome, 6)}\tTipologia: {Tronca(tipologia, 9)}\tCosto: {Tronca(costo.ToString(), 9)}\tFabbricazione: {Tronca(annoFabbricazione.ToString(), 9)}";
        }


        private static string Tronca(string s, int n)
        {
            if (s.Length > n)
                s = s.Substring(0, n) + "...";

            return s;
        }

    }
}
