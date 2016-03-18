using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectFDM
{
    public class DecathonGame
    {
        List<int> lotterylist;
        List<int> userlotterylist;
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

        public List<int> Lottery()
        {
            Random rand = new Random();

            List<int> unsortedlotterylist = new List<int>();
            while (unsortedlotterylist.Count < 6)
            {
                            result = rand.Next(1, 50);
                            if (unsortedlotterylist.Contains(result))
                            {
                                result ++;
                            }
                            unsortedlotterylist.Add(result);
            }
            lotterylist = unsortedlotterylist.OrderBy(v => v).ToList();
            return lotterylist;
            
        }

        public List<int> Userlottery(int one, int two, int three, int four, int five, int six)
        {
            List<int> unsorteduserlotterylist = new List<int>();
            unsorteduserlotterylist.Add(one);
            unsorteduserlotterylist.Add(two);
            unsorteduserlotterylist.Add(three);
            unsorteduserlotterylist.Add(four);
            unsorteduserlotterylist.Add(five);
            unsorteduserlotterylist.Add(six);

            userlotterylist = unsorteduserlotterylist.OrderBy(v => v).ToList();
            return userlotterylist;
        }

        public bool Lotteryresult(List<int> game, List<int> user)
        {
            if (game == user)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LottoWin()
        {
            if (Lotteryresult(lotterylist, userlotterylist) == true)
            {
                //add from the context the game payout value to the user account value
            }
        }



    }
}
