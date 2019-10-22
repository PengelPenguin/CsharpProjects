using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Speler
    {
        public int spelerIndex;
        public bool aanDeBeurt;
        public int score;

        public List<Kaart> kaartenInHand = new List<Kaart>();

        
        public string naam;
        

        public Speler(int spelerIndex)
        {
            aanDeBeurt = false;
            this.spelerIndex = spelerIndex;
            Console.WriteLine("speler" + spelerIndex + " Naam:");
            this.naam = Console.ReadLine();
            Console.WriteLine("welkom " + naam);
        }


        public void PassBeurt()
        {
            //todo
        }

        public void StopMetSpelen()
        {
            //todo
        }

        public void PakKaart(int spelerIndex)
        {
            Console.WriteLine("\n");
            Kaart getrokkenKaart = GameManager.Kaarten.First<Kaart>();
            kaartenInHand.Add(getrokkenKaart);
            score += getrokkenKaart.value;

            Console.WriteLine(naam + " heeft " + getrokkenKaart.naam + " score: " + score);
            GameManager.Kaarten.Remove(getrokkenKaart);
        }
    }
}
