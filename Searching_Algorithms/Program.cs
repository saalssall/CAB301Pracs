using System;

namespace Searching_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Binary_Search bi_search = new Binary_Search();
            //Binary Search
            
            int [] array4Binary = new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int searching_Value = 3;
            
            //Binary Search
            int res = bi_search.binary_search(array4Binary, searching_Value);
            string message = res != -1
                ? $"Found at index {res}"
                : "Value not found.";
            Console.WriteLine(message);
             
            Console.WriteLine("------------");
            
        }
    }
}

