﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectFDM
{
    public class Program
    {
        static void Main(string[] args)
        {
            DecathonGame decgame = new DecathonGame();
            List<int> lotto = decgame.Lottery();
            //foreach (var num in lotto)
            //{
            //    Console.WriteLine(num);
            //}
            List<int> userlotto = decgame.Userlottery(48, 35, 27, 11, 14, 8);
            if (decgame.Lotteryresult(lotto, userlotto) == true)
            {
                Console.WriteLine("You have won!");
            }
            else
            {
                Console.WriteLine("You have lost. Better Luck Next Time.");
            }
            Console.Read();
        }
    }
}
