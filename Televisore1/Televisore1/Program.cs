using System;

namespace Televisione1
{
    public class Televisore
    {
        public string Marca;
        public string Modello;
        public int Risoluzione ;
        public bool Stato;
        public int Canale;
        public int Volume;

        public Televisore(string marca, string modello, int risoluzione)
        {
            Marca = marca;
            Modello = modello;
            Risoluzione = risoluzione;
            Stato = false;
            Canale = 1;
            Volume = 0;
        }

        public void Accendi()
        {
            Stato = true;
        }

        public void Spegni()
        {
            Stato = false;
        }

        public void CambiaCanale(int nuovoCanale)
        {
            if (Stato==true)
            {
                Canale = nuovoCanale;
            }
        }

        public void AlzaAbbassaCanale(int incremento)
        {
            if (Stato==true)
            {
                Canale += incremento;
            }
        }

        public void AlzaAbbassaVolume(int incremento)
        {
            if (Stato == true)
            {
                Volume += incremento;
            }
        }

        public void CambiaVolume(int nuovoVolume)
        {
            if (Stato == true)
            {
                Volume = nuovoVolume;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Televisore s1 = new Televisore("Samsung", "A411", 50);
            Televisore s2 = new Televisore("LG", "ALFA2", 50);

            s1.Accendi();
            s1.CambiaCanale(5);
            s1.CambiaVolume(3);

            s2.Accendi();
            s2.CambiaCanale(10);
            s2.CambiaVolume(10);

            Console.WriteLine("canale TV 1: " + s1.Canale);
            Console.WriteLine("volume TV 1: " + s1.Volume);
            Console.WriteLine("canale TV 2: " + s2.Canale);
            Console.WriteLine("volume TV 2: " + s2.Volume);

        }
    }
}
