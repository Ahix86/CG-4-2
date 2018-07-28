using System;

namespace CG_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // set the array. Here we will use numbers and have 6 in the array
            // array is like a list of items and you chose the items
            // we're doing numbers as the items
            int[] numbers = new int[] { 1, 1, 2, 3, 5, 8 };

            // setting the loop to output all items from array
            // the i++ adds one to it. so when i = 1 it will pull the 2nd 1 fro the list
            // the list starts at absolute zero
           for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();

            



            
        }
    }
}
