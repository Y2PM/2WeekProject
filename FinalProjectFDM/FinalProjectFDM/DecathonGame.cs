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
            //generates a random number between 1 and 10
            return result;
        }

        public void DecWin()
        {
            if (GetOneTen() > 5)
            {
                //if the result is greater than 5
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
            // this makes sure the list contains 6 unique, random numbers between 1 and 50
            lotterylist = unsortedlotterylist.OrderBy(v => v).ToList();
            //this sorts the list in ascending order
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
            //the user's six numbers are added to a list


            userlotterylist = unsorteduserlotterylist.OrderBy(v => v).ToList();
            //the list is sorted so it can be compared
            return userlotterylist;
        }

        public bool Lotteryresult(List<int> game, List<int> user)
        {
            if (game == user)
            {
                //if the generated numbers are the same as the users return true
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
                //when the generated numbers and the user numbers match
                //add from the context the game payout value to the user account value
            }
        }



    }
}
