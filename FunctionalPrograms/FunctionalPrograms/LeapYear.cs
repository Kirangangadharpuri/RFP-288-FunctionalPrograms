using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("Enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400==0))
            {
                Console.WriteLine("It is leap year");
            }
            else
            {
                Console.WriteLine("It is not a leap year");
            }
        }
    }
}
