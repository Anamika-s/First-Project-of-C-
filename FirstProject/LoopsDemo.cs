using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class LoopsDemo
    {
       static void Main()
        {
            // Loop contains 3 statements 1> initialization , 2> condition 3> Ince / Decre
            // do while loop
            Console.WriteLine("Using do while loop");
            int x = 11;  // Ini
            do
            {
                Console.WriteLine(x);
                x++;   // Incre
            } while (x <= 10); // cond
            Console.WriteLine("Using while Loop");
            int y = 11;  // Ini
            while(y<=10)  // cond
            {
                Console.WriteLine(y);
                y++;   // Incre
            }

            Console.WriteLine("Using for loop");
            for(int num = 1; num <=10; num++)
                Console.WriteLine(num);
        }


    }
}
