﻿using System;
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
                Console.WriteLine("3- Power of two");
                Console.WriteLine("4-Harmonic number");
                Console.WriteLine("5- Factors of Number");
                Console.WriteLine("6-Questient and Reminder");
                Console.WriteLine("7-Swap two number");
                Console.WriteLine("8-Even or Odd");
                Console.WriteLine("9- Check Alphabet");
                Console.WriteLine("10- Find largest Number");
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
                    case 3:
                        Power power = new Power();
                        power.PowerOftwo();
                        break;
                    case 4:
                        Harmonic harmonic = new Harmonic();
                        harmonic.Series();
                        break;
                    case 5:
                            Factors factors = new Factors();
                        factors.FactorsOfnumber();
                        break;
                    case 6:
                        Division division = new Division();
                        division.DivisionOfNumber();
                        break;
                    case 7:
                        Swap swap = new Swap();
                        swap.SwapTwoNumbers();
                        break;
                    case 8:
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.FindEvenOdd();
                        break;
                    case 9:
                        Alphabets alphabets = new Alphabets();
                        alphabets.Consonanat_Vowel();
                        break;
                    case 10:
                        LargestNumber largestNumber = new LargestNumber();
                        largestNumber.Numbers();
                        break;
                    default:
                        Console.WriteLine("Invalide option");
                        break;
                }
            }
        }
    }
}
