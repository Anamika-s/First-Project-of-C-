using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class StringFunctions
    {
        static void Main()
        {
            var name = "deepak kumar";
            Console.WriteLine("hello".ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Length);
            Console.WriteLine(name.Remove(1));
                Console.WriteLine( new DateTime(2002, 10, 18));
            //DateTime dob = DateTime.Now;
            //Console.WriteLine("Day:{0}", dob.Day);
            //Console.WriteLine("Month:{0}", dob.Month);
            //Console.WriteLine("Year:{0}", dob.Year);
            //Console.WriteLine("Hour:{0}", dob.Hour);
            //Console.WriteLine("Minute:{0}", dob.Minute);
            //Console.WriteLine("Second:{0}", dob.Second);
            //Console.WriteLine("Millisecond:{0}", dob.Millisecond);
            //Console.WriteLine("Day of Week:{0}", dob.DayOfWeek);
            //Console.WriteLine("Day of Year: {0}", dob.DayOfYear);
            //Console.WriteLine("Time of Day:{0}", dob.TimeOfDay);
            //Console.WriteLine("Tick:{0}", dob.Ticks);
            //Console.WriteLine("Kind:{0}", dob.Kind);

            DateTime dob = DateTime.Now;
            Console.WriteLine(dob.ToString("d"));
            Console.WriteLine(dob.ToString("d"));
            Console.WriteLine(dob.ToString("D"));

                
                
                

        }
    }
}
