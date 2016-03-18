using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectFDM
{
    public class DecathonGame
    {
        public int GetOneTen()
        {
            Random rand = new Random();
            int result = rand.Next(1, 10);
            return result;
        }

        public void DecWin()
        {
            if (GetOneTen() > 5)
            {
                //add from the context the game payout value to the user account value
            }
        }

    }
}
