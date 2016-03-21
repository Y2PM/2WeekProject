using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectFDM
{
    public class BetClass
    {
        public string Bet(double numberBid, double moneyGiven)
        {
            if (numberBid > 1 || numberBid < 0)
            {
                return "invalid input";
            }



            return "0";
        }
    }
}
