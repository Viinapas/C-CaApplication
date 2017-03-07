using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//tee ohjelma joka laskee N lukua yhteen, N pitää olla vähintään 1

namespace CaLoop2
{
    class Program
    {
        static void Main(string[] args)
        {


            int number = -1;

            // try catch metod
            while (number != 0)
            {
                try
                {
                    Console.WriteLine("Please give positive number. Program gave total result");
                    Console.WriteLine(" If you want to stop press 0 and Enter");

                    number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        Console.WriteLine(" Out of range, please give another number ");
                        continue;
                    }
                    if (number < 0)
                    {
                        Console.WriteLine("Out of range !!! Number is negative. Please give another number");
                        continue;
                    }

                   
                    //factorial math.

                    double total = 0;
                    int i = 1;
                    while (i <= number)
                    {
                        total = total+ i;
                        i++;
                    }
                    if (number != 0) // not equal // zero catch to loop and stop program

                        Console.WriteLine("Number:" + " " + number + " " + "total" + " " + total);

                }
                catch
                {
                    Console.WriteLine("Wrong input");
                }
            }



        }
    }
}
