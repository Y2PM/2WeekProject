using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectFDM
{
    public class BetClass
    {
        public List<string> Bet(Int32 numberBid, double moneyGiven)
        {
            List<string> Result = new List<string>();
            Int32 maxRange = 100;
            Int32 minRange = 0;

            if (numberBid > maxRange || numberBid < minRange)
            {
                string Result0 = "invalid input";
                string Result1 = "0";
                Result.Add(Result0);
                Result.Add(Result1);
                return Result;
            }//Defensive coding, check number is in range.

            Random RandObject = new Random();
            Int32 RInt = RandObject.Next(0, 101);

            //Calculate odds
            Int32 Odds = Math.Abs(RInt - numberBid) / (maxRange - minRange);
            double WinReturn = Odds * moneyGiven + moneyGiven;

            if (numberBid >= RInt)
            {
                string Result0 = "win";
                string Result1 = WinReturn.ToString();
                Result.Add(Result0);
                Result.Add(Result1);
            }
            else
            {
                string Result0 = "Loose";
                string Result1 = "0";
                Result.Add(Result0);
                Result.Add(Result1);
            }

            return Result;
        }
    }
}
