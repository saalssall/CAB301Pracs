using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Status_Code_Meaning(404);
            Console.WriteLine("-----------------");
            Console.WriteLine("Status code: " + HashTable[200]);
            Console.WriteLine("Status code: " + HashTable[404]);
            Console.WriteLine("-----------------");
            Console.WriteLine("Subset 1: " + isSubset(new int[] {1, 2, 3, 4}, new int[] {5, 6, 7, 8}));
            Console.WriteLine("Subset 2: " + isSubset(new int[] {1, 2, 3, 4, 5, 6, 7, 8}, new int[] {5, 6, 7, 8}));
            Console.WriteLine("-----------------");
            Console.WriteLine("Intersection: " + isIntersection(new int [] {12, 34, 45, 34}, new []{34, 44, 22, 11}));
            
            Console.WriteLine("Duplicate: " + isDuplicate("this is a string"));
        }

        public static void Status_Code_Meaning(int statusCode)
        {
            if (statusCode == 404)
            {
                Console.WriteLine("Not Found");
            }
            else if (statusCode == 200)
            {
                Console.WriteLine("OK");
            }
            else if (statusCode == 401)
            {
                Console.WriteLine("Unauthorized");
            }
            else if (statusCode == 403)
            {
                Console.WriteLine("Forbidden");
            }
        }
        
        //Using hash tables instead of the if else statements to get the value for each key
        //The time complexity of lookup in hash table is O(1) 
        static Dictionary<int, string> HashTable = new Dictionary<int, string>
        {
            {200, "OK"},
            {401, "Unauthorized"},
            {403, "Forbidden"},
            {404, "Not Found"},
            {405, "Method Not Allowed"},
            {406, "Not Acceptable"},
        };
        
        //Another example to demonstrate using a hash table to compare
        //two arrays and see if one is a subset of the other
        
        static bool isSubset(int[] array1, int[] array2)
        {
            int [] smallerArray;
            int [] largerArray;
            Dictionary<int, bool> hashTable = new Dictionary<int, bool>();
            
            if (array1.Length > array2.Length)
            {
                smallerArray = array2;
                largerArray = array1;
            }
            else
            {
                smallerArray = array1;
                largerArray = array2;
            }
            
            foreach (var value in largerArray)
            {
                hashTable[value] = true;
            }

            foreach (var value in smallerArray)
            {
                if (!hashTable.ContainsKey(value))
                {
                    return false;
                }
            }
            return true;
        }
        
        //Writing a function for getting the intersection of two arrays
        static bool isIntersection(int[] array1, int[] array2)
        {
            Dictionary<int, bool> hashTable = new Dictionary<int, bool>();
            
            foreach (var value in array1)
            {
                hashTable[value] = true;
            }
            
            foreach (var value in array2)
            {
                if (hashTable.ContainsKey(value))
                {
                    return true;
                }
            }
            return true;
        }
        
        //Checking the first found duplicate

        public static string isDuplicate(string text)
        {
            HashSet<char> seen = new HashSet<char>();

            foreach (char c in text)
            {
                if (seen.Contains(c))
                    return c.ToString();

                seen.Add(c);
            }

            return "No duplicate found";
        }
        
        // TO DO: 
        // 3,4
    }
}