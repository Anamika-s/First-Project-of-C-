using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class ConditionalProg
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
             if(choice==1)    
            Console.WriteLine($"Sum of {x} and {y} is {x + y}");
            else  if (choice == 2)
             Console.WriteLine($"Difference of {x} and {y} is {x - y}");

            else  if (choice == 3) 
                Console.WriteLine($"Product of {x} and {y} is {x * y}");
            else if (choice == 4)
                Console.WriteLine($"Quotient of {x} and {y} is {x / y}");
            else if (choice == 5)
                Console.WriteLine($"Remainder of {x} and {y} is {x % y}");
             else
                Console.WriteLine("Invalid choice");
        }
    }
}
