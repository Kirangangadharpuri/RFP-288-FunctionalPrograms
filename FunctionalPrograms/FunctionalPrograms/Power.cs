using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Power
    {
        public void PowerOftwo()
        {
            Console.WriteLine("Enter a value:");
            int n = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(p);
                p = p * 2;
            }
        }
    }
}
