//
// A simple program that will calculate 
// the minimum and maximum values 
// inside an initialized integer array.
// 
// Made by Mekrou on 01/29/2021
//


using System;

namespace MinValueArray
{
    class Program
    {
        static void Main(String[] args)
        {
            // I use Min and Max Value properties to ensure that we are starting from the lowest and highest possible integers.
            int maximum = int.MinValue;
            int minimum = int.MaxValue;
            
            // Counter essentially gets the number of elements we passed through, could use array.Length instead.
            int counter = 0;
            int sum = 0;

            // Average could be a float.
            double average = 0;
            
            int[] array = new [] {400, 24, 562, 902, 375, 120, 5671, 3163, 172, 23, 239};
            
            foreach (int number in array)
            {
                // These are used to calculate the average.
                counter++;
                sum += number;
                
                // Logic for calculating max and mins.
                if (number > maximum)
                {
                    maximum = number;
                } else if (number < minimum)
                {
                    minimum = number;
                }    
            }

            // Must cast to double to retain accuracy.
            average = (double) sum / counter;

            Console.WriteLine(average);
            Console.WriteLine(maximum);
            Console.WriteLine(minimum);
        }
    }
}
