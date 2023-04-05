using Cafetera_TDD.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera_TDD.Classes
{
    public class Cups
    {
        string size;
        int amount;
        CupSizes cupSizes =  new CupSizes();

        public Cups(string size, int amount )
        {
            this.size = size;
            this.amount = amount;
        }

        public int GetSizeOnz()
        {
            if(cupSizes.Small == size)
            {
                return 10;
            } else if(cupSizes.Medium == size)
            {
                return 14;
            }else if(cupSizes.Large == size)
            {
                return 16;
            }

            return 0;
        }

        public int HasCups()
        {
            return amount;
        }

        public string GiveCup()
        {
            this.amount-= 1;
            return size + "cup";
        }
    }
}
