using System;

namespace Algorithm_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Practicing for week1 content

            //1. Checking whether a number in an array is even or odd

            //Input: Array of A[0...n-1] numbers
            //Output: odd or even number

            // for an Array of size n 
                //if number is even:
                    //print(number is even)
                //else if number is odd:
                    //print(number is odd)
                    
        void checkNum(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number."); 
            }
            else if (num % 2 != 0)
            {
                Console.WriteLine($"{num} is an odd number.");
            }
        }
        
        checkNum(100);
        checkNum(205);
        checkNum(234);
        checkNum(633);
        checkNum(237);
        checkNum(546);
        checkNum(135);
        }
    }
}



