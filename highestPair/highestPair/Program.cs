using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestPair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            highestPairClass highestPairClass = new highestPairClass();

            highestPairClass.highestPair(new string[] { "A", "A", "Q", "Q", "6" });

            highestPairClass.highestPair(new string[] { "J", "6", "3", "10", "8" });

            highestPairClass.highestPair(new string[] { "K", "7", "3", "9", "3" });

            highestPairClass.highestPair(new string[] { "K", "9", "10", "J", "Q" });

            highestPairClass.highestPair(new string[] { "3", "5", "5", "5", "5" });

            Console.ReadLine();
        }
    }
}
