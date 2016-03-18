using System;
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
            List<int> lotto = decgame.lottery();
            foreach (var num in lotto)
            {
                Console.WriteLine(num);
            }

            Console.Read();
        }
    }
}
