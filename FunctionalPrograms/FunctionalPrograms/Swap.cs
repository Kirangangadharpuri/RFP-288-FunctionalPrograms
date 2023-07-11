using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Swap
    {
        public void SwapTwoNumbers()
        {
            Console.WriteLine("Enter a number ");
            int num_one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Number");
            int num_two = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("value before swaping a = " + num_one + " b = " + num_two);
            int n = num_one * num_two;
            num_one = n / num_one;
            num_two = n / num_two;

            Console.WriteLine("value after swaping a = " + num_one + " b = " + num_two);


        }
    }
}
