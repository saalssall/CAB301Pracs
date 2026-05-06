using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TreeNode node1 = new TreeNode(25);
            TreeNode node2 = new TreeNode(75);
            TreeNode root = new TreeNode(50, node1, node2);
       
            Console.WriteLine($"Root: {root.Value}");
            Console.WriteLine($"Left: {root.Left?.Value}");
            Console.WriteLine($"Right: {root.Right?.Value}");
            
            Searching search = new Searching();
            search.Run();
            
            Console.WriteLine("---------------");
            
            Insertion insertion = new Insertion();
            insertion.Run();
            
        }
    }
};

