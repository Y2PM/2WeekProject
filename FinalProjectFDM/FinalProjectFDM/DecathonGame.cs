using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectFDM
{
    public class DecathonGame
    {
        List<int> lotterylist = new List<int>();
        int result;
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

        public List<int> lottery()
        {
            Random rand = new Random();
            //do
            //{
            //result = rand.Next(1, 50);
            //    lotterylist.Add(result);

            //} while (lotterylist.Contains(result) == false && lotterylist.Count < 6);
            while (lotterylist.Count < 6)
            {
                            result = rand.Next(1, 50);
                            if (lotterylist.Contains(result))
                            {
                                result ++;
                            }
                lotterylist.Add(result);
            }

            return lotterylist;
            
        }

    }
}
