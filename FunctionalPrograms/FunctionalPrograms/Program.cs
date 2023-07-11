using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1- Flip Coin");
                Console.WriteLine("2- Leap Year");
                Console.WriteLine("Choose above option");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Display();
                        break;
                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.Year();
                        break;
                    default:
                        Console.WriteLine("Invalide option");
                        break;
                }
            }
        }
    }
}
