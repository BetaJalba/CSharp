//programma
using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            COrchestra orchestra = new COrchestra(new DateTime(2021, 05, 12)); // yyyy/mm/dd
            CStrumento strumento1 = new CStrumento("Tamburo", "Percussioni", 2150.00f, 1995);
            CStrumento strumento2 = new CStrumento("Violino", "Corda", 1100.00f, 2015);
            CStrumento strumento3 = new CStrumento("Batteria", "Percussioni", 956.50f, 2020);
            CStrumento strumento4 = new CStrumento("PianoForte", "Corda", 11725.80f, 2019);
            CStrumento strumento5 = new CStrumento("Clarinetto", "Fiato", 549.99f, 2016);

            Console.Write("Orchestra Console.");
            Console.Write(PrintLn(20));
            orchestra.AddStrumento(strumento1);
            orchestra.AddStrumento(strumento2);
            Console.Write(orchestra.ToString());
            Console.Write(PrintLn(20));
            orchestra.AddStrumento(strumento3);
            orchestra.AddStrumento(strumento4);
            orchestra.AddStrumento(strumento5);
            Console.Write(orchestra.ToString());
            Console.Write(PrintLn(20));
            orchestra.Ordina();
            Console.Write(orchestra.ToString());
            Console.Write(PrintLn(20));
            orchestra.EliminaStrumento("Batteria");
            Console.Write(orchestra.ToString());
            Console.Write(PrintLn(20));
            Console.Write(orchestra.Costo("Corda"));
            Console.Write(PrintLn(20));
        }

        static string PrintLn(int n)
        {
            string r = "\n";

            for (int i = 0; i < n; i++)
            {
                r += "-";
            }

            r += "\n";

            return r;
        }
    }
}