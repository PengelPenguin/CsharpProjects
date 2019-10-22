using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class SpecialeKaart : Kaart
    {
        public SpecialeKaart(string naam,int value = 10)
            :base(naam,value)
        {
            this.naam = naam;
            
        }
    }
}
