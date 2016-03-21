﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectFDM
{
    public class BetClass : IBet
    {
        public List<string> Bet(Int32 numberBid, double moneyGiven)
        {
            List<string> Result = new List<string>();
            Int32 maxRange = 100;
            Int32 minRange = 0;
            string Result0;
            string Result1;

            if (numberBid > maxRange || numberBid < minRange)
            {
                Result0 = "+++invalid input+++";
                Result1 = "0.00";
                Result.Add(Result0);
                Result.Add(Result1);
                return Result;
            }//Defensive coding, check number is in range.

            Random RandObject = new Random();
            Int32 RInt = RandObject.Next(minRange, maxRange + 1);

            //Calculate odds
            double Odds = ((maxRange - (double)numberBid) / (maxRange - minRange)) * 100;
            double WinReturn = Odds * moneyGiven + moneyGiven;

            if (numberBid >= RInt)
            {
                Result0 = "win";
                Result1 = WinReturn.ToString("f2");
                Result.Add(Result0);
                Result.Add(Result1);
            }
            else
            {
                Result0 = "loose";
                Result1 = "0.00";
                Result.Add(Result0);
                Result.Add(Result1);
            }

            return Result;
        }
    }
}
