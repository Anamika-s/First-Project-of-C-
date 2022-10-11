using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class SwitchProg
    {
        static void Main()
        {
            int choice;
            int x;
            int y;
            Console.WriteLine("Enter Value of x");
            x = Int16.Parse(Console.ReadLine()); // "4"
            Console.WriteLine("Enter Value of y");
            y = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Choice");
            choice = Byte.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1: Console.WriteLine("Sum is " + (x+y));
                    break;

                case 2:
                    Console.WriteLine("Difference is " + (x - y));
                    break;

                case 3:
                    Console.WriteLine("Product is " + (x * y));
                    break;

                case 4:
                    Console.WriteLine("Remainder is " + (x % y));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }
        }
    }
