using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EsercizioSedeLZ
{
    public class CAutomobile
    {
        public float Consumo { get; }
        public float Serbatoio { get; private set; }
        public float SerbatoioMax { get; private set; }
        public string Targa { get; }
        public float Chilometraggio { get; private set; }

        public CAutomobile(float consumo, string targa, float serbatoioMax)
        {
            this.Consumo = consumo;
            this.Targa = targa;
            Serbatoio = 0;
            this.SerbatoioMax = serbatoioMax;
            this.Chilometraggio = 0;
        }

        [Newtonsoft.Json.JsonConstructor] //attributo per indicare al deserializer di utilizzare questo construttore
        public CAutomobile(float consumo, string targa, float serbatoio, float serbatoioMax, float chilometraggio) //per il JSON
        {
            this.Consumo = consumo;
            this.Targa = targa;
            this.Serbatoio = serbatoio;
            this.SerbatoioMax = serbatoioMax;
            this.Chilometraggio = chilometraggio;
        }


        public void Drive(float distanza)
        {
            float temp = Serbatoio;
            temp -= (float)Math.Round(distanza / Consumo, 2);
            if (temp < 0)
            {
                throw new Exception("La distanza inserita non è percorribile");
            }
            else
            {
                Serbatoio = temp;
                Chilometraggio += distanza;
            }
        }

        public float GetCarburante()
        {
            return Serbatoio;
        }

        public void Rifornimento(float rifornimento)
        {
            Serbatoio += rifornimento;

            if (Serbatoio > SerbatoioMax)
            {
                float diff = Serbatoio - SerbatoioMax;
                Serbatoio = SerbatoioMax;

                MessageBox.Show($"Hai inserito {diff}L extra");
            }
        }
        public override string ToString()
        {
            return $"Il serbatoio ha {Serbatoio} litri di benzina\n" + 
                   $"La targa è {Targa}\n" +
                   $"La macchina consuma {Consumo} chilometri/litro\n" +
                   $"Il chilometraggio è {Chilometraggio} chilometri";
        }

        public string ToStringForList()
        {
            return $"Serbatoio: {Serbatoio}L" +
                   $"\tTarga: {Targa}" +
                   $"\tConsumo: {Consumo}km/L";
        }
    }
}
