using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Spelbord
    {
        public Pion speler;
        
        public Spelbord(Pion speler)
        {
            this.speler = speler;
        }

        public void checkPositie()
        {
            switch (speler.spelerPositie)
            {
                case 10:
                    speler.DubbelLopen();
                    break;

                case 20:
                    speler.DubbelLopen();
                    break;

                case 23:
                    speler.GameOver();
                    break;
                case 25:
                    speler.GameOver();
                    break;

                case 30:
                    speler.DubbelLopen();
                    break;

                case 40:
                    speler.DubbelLopen();
                    break;

                case 45:
                    speler.GameOver();
                    break;

                case 50:
                    speler.DubbelLopen();
                    break;

                case 60:
                    speler.DubbelLopen();
                    break;

                default:
                    break;
            }
        }

        public void StartGame()
        {
            //game loop
            do
            {
                speler.SpelerInput();
                checkPositie();

            }
            while (speler.hasPlayerWon == false);

            if (speler.hasPlayerWon)
                Console.WriteLine("Je hebt gewonnen");

        }




    }
}
