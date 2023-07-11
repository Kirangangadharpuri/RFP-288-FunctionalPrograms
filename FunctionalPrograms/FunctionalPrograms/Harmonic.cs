using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Harmonic
    {
        public void Series()
        {
            
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int num = 1; num <= number; num++)
            {
                Console.Write("1/{0} + ", num);
            }
        }
    }
}
