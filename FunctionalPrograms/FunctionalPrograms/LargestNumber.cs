using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class LargestNumber
    {
        public void Numbers()
        {


            Console.WriteLine("Enter first number");
            int FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  second number");
            int SecondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int ThirdNum = int.Parse(Console.ReadLine());
            if (FirstNum > SecondNum)
            {
                if (FirstNum > ThirdNum)
                {
                    Console.WriteLine("First is largest = " + FirstNum);
                }
                else
                {
                    Console.WriteLine("Third is largest = " + ThirdNum);
                }

            }
            else if (SecondNum > ThirdNum)
            {
                Console.WriteLine("Second is largest = " + SecondNum);

            }
            else
            {
                Console.WriteLine("Third is largest = " + ThirdNum);
            }

        }
    }
}
