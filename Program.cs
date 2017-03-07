using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// funktio aliohjelmat
//basics funktion

namespace CaBasictask
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            //
            int lap = 10;
            int total = 0;

            Console.WriteLine("Please give 10 numbers");

            for (int i = 1; i <= lap; i++)
            {
                
                Console.WriteLine("Give {0}. number", i);
                total += int.Parse(Console.ReadLine());

            }



            Console.WriteLine("Total for your input is" + " " + total);

            ////int[] numbers= new int[]{int.MaxValue};
            ////int maximumNumber= numbers.Max();
            ////Console.WriteLine("Highest number is" + " " + numbers.Max());
            ////Console.ReadLine();


            //int[] numbers = { 3, 9, 5 };
            //int biggestNumber = numbers.Max();
            //Console.WriteLine(biggestNumber);
            //Console.ReadLine();

        


        }
    }
}
