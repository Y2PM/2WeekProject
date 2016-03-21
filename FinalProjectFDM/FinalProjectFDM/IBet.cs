using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectFDM
{
    interface IBet
    {
        public List<string> Bet(Int32 numberBid, double moneyGiven);
    }
}
