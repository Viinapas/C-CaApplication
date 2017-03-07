using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Loops practise

namespace CaLoop1
{
    class Program
    {
        static void Main(string[] args)
        {

            //N! Program loops task 5!

            int number = -1;

            // try catch metod
            while (number != 0) 
            {
                try
                {
                    Console.Write("Please give positive number exp. 1-150");
                    Console.WriteLine(" If you want to stop press 0");

                    number = int.Parse(Console.ReadLine());

                    if (number > 150)
                    {
                        Console.WriteLine(" Out of range, please give another number ");
                        continue;
                    }
                    if (number < 0)
                    {
                        Console.WriteLine("Out of range !!! Number is negative. Please give another number");
                        continue;
                    }

                    if (number == -5)
                    {
                        Console.WriteLine("ZERO HERO");
                        continue;
                    }

                    //factorial math.

                    double factorial = 1;
                    int i = 1;
                    while (i <= number)
                    {
                        factorial = factorial * i;
                        i++;
                    }
                    if (number != 0) // not equal

                        Console.WriteLine("Number:" +" "+ number +"!"+ "factorial is" +" "+ factorial);

                }
                catch 
                {
                    Console.WriteLine("Wrong input");
                }
            }

            
        }
    }
}
