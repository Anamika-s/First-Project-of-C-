using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Variables
    {
        static void Main()
        {
            // Ctrl + KC > Comment Statements 
            // Ctrl + KU > Uncomment Statements 

            //int x = 100;
            //int y = 20;
            //Console.WriteLine("Sum of x and y is " + (x+y));
            //Console.WriteLine("Sum of " + x + " and " + y + " is " + (x+y));
            ////%d %s
            ////{ } > As positional parameters
            //Console.WriteLine("Sum of {0} and {1} is {2}", x, y , (x+y));
            //Console.WriteLine($"Sum of {x} and {y} is {x+y}");
            //Console.WriteLine($"Difference of {x} and {y} is {x - y}");
            //Console.WriteLine($"Product of {x} and {y} is {x * y}");
            //Console.WriteLine($"Quotient of {x} and {y} is {x / y}");
            //Console.WriteLine($"Remainder of {x} and {y} is {x % y}");
            int x;
            int y;
            Console.WriteLine("Enter Value of x");
            x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Value of y");
            y = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Sum of x and y is " + (x + y));
            Console.WriteLine("Sum of " + x + " and " + y + " is " + (x + y));
            //%d %s
            //{ } > As positional parameters
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
            Console.WriteLine($"Sum of {x} and {y} is {x + y}");
            Console.WriteLine($"Difference of {x} and {y} is {x - y}");
            Console.WriteLine($"Product of {x} and {y} is {x * y}");
            Console.WriteLine($"Quotient of {x} and {y} is {x / y}");
            Console.WriteLine($"Remainder of {x} and {y} is {x % y}");

        }
    }
}
