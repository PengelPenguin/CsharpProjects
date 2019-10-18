using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Spel
    {
        public Spelbord ganzebord;
        public Pion speler;

        //multiplayer
        public Pion speler_2;
        

        public Spel()
        {
            Console.WriteLine("Enter your name");
            speler = new Pion(Console.ReadLine());
            speler_2 = new Pion(Console.ReadLine());
            ganzebord = new Spelbord(speler);

            do
            {
                if (speler.hasPlayerWon == false)
                {
                    ganzebord.StartGame();
                }
                else
                    Console.WriteLine("Je hebt gewonnen!");


            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
