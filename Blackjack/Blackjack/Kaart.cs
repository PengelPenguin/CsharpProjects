using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Kaart
    {
        public string naam;
        public int value;

        public Kaart(string naam,int value)
        {
            this.naam = naam;
            this.value = value;
        }
    }
}
