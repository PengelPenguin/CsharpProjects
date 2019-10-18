using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dobbelsteen
    {
        static Random rand;
        static int dobbelsteenOgen;


        public static int GooiDobbelSteen(string SpelerNaam)
        {
            rand = new Random();
            dobbelsteenOgen = rand.Next(0, 6);
            Console.WriteLine(SpelerNaam + " heeft: " + dobbelsteenOgen + "gegooid!");
            return dobbelsteenOgen;
        }

    }
}
