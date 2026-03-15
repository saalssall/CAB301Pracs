using System;

namespace Algorithm_Practice
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*** Practicing for week1 content
            1. Checking whether a number in an array is even or odd
            2. Finding the lowest value in an array

            Input: Array of A[0...n-1] numbers
            Output: for each number, print whether it is even or odd
            
            Steps:
            for an Array of size n 
                if number is even:
                    print(number is even)
                else if number is odd:
                    print(number is odd) 
                    
            Pseudocode:
            
            for i <- 0 to n-1 do
                if A[0] mod 2 = 0 then
                    print A[i], "is even"
                else 
                    print A[i], "is odd"
                end if
            end for
                
            ***/
                    
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
        //Checking the output
        checkNum(100);
        checkNum(205);
        checkNum(234);
        checkNum(633);
        checkNum(237);
        checkNum(546);
        checkNum(135); 
        
        Console.WriteLine("------------");    
        //A second method
        void checkNumber(int num1)
        {
            Console.WriteLine($"{num1} is {(num1 % 2 == 0 ? "an even number." : "an odd number.")}");
        }
        //Checking the output of the algorithm
        checkNumber(13);
        checkNumber(102);
        checkNumber(112);
        checkNumber(2445);
        checkNumber(53221);
        
        /*** 2. Find the lowest value in an array
        Input: a few numbers from the array
        Output: the lowest value in the array
        
        Steps: 
        1. Go through the elements in the array one by one
        2. Check if the value is the lowest so far
            //If yes, save it
            //else move on
        3. Print the lowest value 
        
        Pseudocode: 
        
       min <- A[0]
       for i <- 0 to n-1 do
           if A[0] < min then
               min > A[i]
           end if
       end for
       return min

        ***/

        int[] numbers = { 123, 34, 54, 23, 52, 155, 84, 78 };
        int minValue = numbers[0];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }
        Console.WriteLine($"The minimum value is: {minValue}!");

        }
    }
}



