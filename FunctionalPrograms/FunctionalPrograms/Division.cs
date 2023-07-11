using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Division
    {
        public void DivisionOfNumber()
        {
            Console.WriteLine("Enter Divident ");
            int dividend =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int divisor =Convert.ToInt32(Console.ReadLine());
            int Quotient = dividend / divisor;
            int Reminder = dividend % divisor;
            Console.WriteLine("The Quotient is " + Quotient);
            Console.WriteLine("The Reminder is " + Reminder);
        }
    }
}
