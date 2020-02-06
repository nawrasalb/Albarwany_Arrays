// Author : Nawras Albarwany
// Date : 2/6/2020
// Demonstrates the use of an Array 
using System;

namespace Albarwany_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // produces an  array with 25 elements
            int[] elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };


            // for loop to create iteration 
            for(int i =0 ;i < elements.Length; i++)
            {
               // displays message " element value 
                Console.WriteLine(" Element value = " + elements[i]);
            }

        }
    }
}
