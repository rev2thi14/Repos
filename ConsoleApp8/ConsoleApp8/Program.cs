using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
 // Nullable Type 
           //int? i = null;
           /* int? x = 4;
            int y = 3;
            int z = x * y;        //Cannot implicitly convert type 'int?' to 'int'.//
            Console.WriteLine(z.ToString());
            Console.ReadLine();*/

 // Here x is nullable while y is not nullable. So The above Program will generate the following compile time Error*/

            //To avoid Error
             
             /*int? x = 4;
            int? y = 3;
            int? z = x * y;
            Console.WriteLine(z.ToString());
            Console.ReadLine();*/ 

            //Compare a Nullable Type with a Not Nullable type.//

            int? x = 3;
            int y = 3;
            bool check = false;
            if (x == y)
            {
                check = true;
                Console.WriteLine(check.ToString());
                Console.ReadLine();
            }
        }
    }
}


