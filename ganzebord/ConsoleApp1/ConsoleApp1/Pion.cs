using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pion
    {
        public string naam;
        public int spelerPositie;
        public int stappenVooruit;
        
        public Pion(string naam)
        {
            this.naam = naam;
            spelerPositie = 0;
            Console.WriteLine("Welkom: " + naam);
        }

        public void SpelerInput()
        {
            if (Console.ReadKey().Key == ConsoleKey.G && hasPlayerWon == false )
            {
                Lopen();
            }
        }

        public void Lopen ()
        {
            stappenVooruit = Dobbelsteen.GooiDobbelSteen(naam);
            if (!outOfBounds)
            {
                spelerPositie += stappenVooruit;
                Console.WriteLine("Je staat op positie: " + spelerPositie);
            }
                
            else
            {
                spelerPositie = (spelerPositie - stappenVooruit);
                Console.WriteLine("Out of bounds, je gaat terug. Je staat op positie: " + spelerPositie);
            }
                
            
        }

        public void DubbelLopen()
        {
            stappenVooruit = Dobbelsteen.GooiDobbelSteen(naam);
            spelerPositie += (stappenVooruit * 2);
            Console.WriteLine("Bonus stappen!! Je staat op positie: " + spelerPositie);
        }

        public void GameOver()
        {
            spelerPositie = 0;
            Console.WriteLine("Game Over..");
        }

        //win conditie
        public bool hasPlayerWon
        {
            get { return spelerPositie == 63; }
        }

        public bool outOfBounds
        {
            get { return spelerPositie > 63; }
        }


    }
}
