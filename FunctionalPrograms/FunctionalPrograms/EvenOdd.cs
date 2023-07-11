using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class EvenOdd
    {
        public void FindEvenOdd()
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());            
            if (num%2 == 0)
            {
                Console.WriteLine("It is an even number");
            }
            else
            {
                Console.WriteLine("It is an odd number");
            }
        }
    }
}
