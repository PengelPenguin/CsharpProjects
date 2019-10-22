using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{

    class GameManager
    {
        private string [] symboolnamen = { "klaveren", "schoppen", "harten", "ruiten" };

        //Debug mode
        bool testMode = true;

        public static List<Kaart> Kaarten = new List<Kaart>();
        public Speler speler = new Speler(1);

        public GameManager()
        {
            VoegKaartenToe();
            Console.WriteLine(Kaarten.Count);
            do
            {
                if (Console.ReadKey().Key == ConsoleKey.K)
                {
                    speler.PakKaart(1);
                }
            } while (testMode);
        }

        public List<Kaart> ShuffleKaarten()
        {
            List<Kaart> randomkaarten = new List<Kaart>();
            Random rnd = new Random();
            while(Kaarten.Count > 0)
            {
                int index = rnd.Next(0, Kaarten.Count);
                randomkaarten.Add(Kaarten[index]);
                Kaarten.RemoveAt(index);
            }

            for (int i = 0; i < randomkaarten.Count; i++)
            {
                Console.WriteLine(randomkaarten[i].naam + " met waarde: " + randomkaarten[i].value);
            }

            return randomkaarten;
        }

        public void VoegKaartenToe()
        {
            for (int i = 0; i < symboolnamen.Length; i++)
            {
                SpecialeKaart aas = new SpecialeKaart(symboolnamen[i] + "-aas");
                SpecialeKaart koning = new SpecialeKaart(symboolnamen[i] + "-koning");
                SpecialeKaart koningin = new SpecialeKaart(symboolnamen[i] + "-koningin");
                SpecialeKaart boer = new SpecialeKaart(symboolnamen[i] + "-boer");
                Kaarten.Add(aas);
                Kaarten.Add(koning);
                Kaarten.Add(koningin);
                Kaarten.Add(boer);

            }

            for (int i = 2; i < 11; i++)
            {
                Kaart harten = new Kaart("harten " + i, i);
                Kaart klaveren = new Kaart("klaveren " + i, i);
                Kaart ruiten = new Kaart("ruiten " + i, i);
                Kaart schoppen = new Kaart("schoppen " + i, i);

                Kaarten.Add(harten);
                Kaarten.Add(klaveren);
                Kaarten.Add(ruiten);
                Kaarten.Add(schoppen);

            }


            
            Kaarten = ShuffleKaarten();
        }

        public Kaart bovensteKaart
        {
            get { return Kaarten.First<Kaart>(); }
        }

        
        
    }
}
