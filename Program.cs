using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            //PV
            // Write number. Input example 5 Output "Number 5 is uneven"

            float num = 0;
            string keyword= string.Empty ;

            Console.WriteLine(" Please give type number. ");
            Console.WriteLine("Program check it is positive or nergative and even or unven");
           
            bool result =float.TryParse(Console.ReadLine(), out num);



            if (!result) 
            {
                keyword = ("It is not a number");
              
            }


            if (num > 0)
            {
                Console.WriteLine("Number" + " " + num + " is positive");
                Console.ReadLine();
               
            }

            else if( num % 2 ==0)
            {
                keyword = "Number is" + num.ToString() +"even number";
               
            }

            if (num < 0)
            {
                Console.WriteLine("Number" + " " + num + " is negative");
                Console.ReadLine();
                
            }


            if (num % 2 == 1) 
            {
                keyword = "Number is" + num.ToString() + "uneven number";
               
            }

            Console.WriteLine(keyword);
            Console.ReadKey();


         }
    }
}
