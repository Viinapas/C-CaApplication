using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //PV
            // Write number. Input example 5 Output "Number 5 is positive"

            float num = 0;
            String keyword ;

            Console.WriteLine(" Give Number");
            keyword=Console.ReadLine();
            num = float.Parse(keyword);

            if (num >0)
            {
              Console.WriteLine( "Number"+" "+  num + " is positive");
                Console.ReadLine();
                return;

            
            }

            if (num >=0)
            {
                Console.WriteLine( " Number" +" "+num + " is ZERO and it is positive");
                Console.ReadLine();
                return;

            }



            if (num < 0)
            {
                Console.WriteLine("Number" + " " + num + " is negative");
                Console.ReadLine();
                return;


            }




        }
    }
}
