using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera_TDD.Classes
{
    internal class Sugar
    {
        int Amount;

        public Sugar(int amount)
        {
            this.Amount = amount;
        }

        public int HowMuchSuggar()
        {
            return this.Amount;
        }

        public bool HasEnoughSuggar(int sugarQuantity)
        {
            return Amount >= sugarQuantity;
        }

        public void GiveSuggar(int sugarQuantity)
        {
            Amount -= sugarQuantity;
        }

    }
}
