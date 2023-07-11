using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class FlipCoin
    {
        public void Display()
        {
            Random random = new Random();
            int flip = random.Next(3);
            Console.WriteLine(flip);
            if (flip == 0)
            {
                Console.WriteLine("It's Head");
            }
            else
            {
                Console.WriteLine("It's Tail");
            }

        }
    }
}
