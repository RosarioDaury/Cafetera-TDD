using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera_TDD.Classes
{
    public class Coffe
    {
        int Amount;

        public Coffe(int amount) 
        { 
            this.Amount = amount;
        }

        public int HowMuchCoffe()
        {
            return this.Amount;
        }

        public bool HasEnoughCoffe(int cupSize)
        {
            return Amount >= cupSize;
        }

        public void GiveCoffe(int cupSize)
        {
            Amount -= cupSize;
        }
    }
}
