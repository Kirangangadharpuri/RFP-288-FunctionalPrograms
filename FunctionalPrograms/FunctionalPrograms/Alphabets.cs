using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Alphabets
    {
        public void Consonanat_Vowel()
        {
            Console.WriteLine("Enter a Letter");
            char alphabet= Convert.ToChar(Console.ReadLine());
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u' ||
            alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U')
            {
                Console.WriteLine("{0} is a Vowel", alphabet);

            }
            else
            {
                Console.WriteLine("{0} is a Consonant", alphabet);
            }
        }
    }
}
