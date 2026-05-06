namespace MyNamespace;

public class Insertion
{
    // Insertion takes O(log N) + 1 steps.
    //if we insert sorted data into a tree, it can become imbalanced and less efficient.

    public void Insert(int value, TreeNode? node)
    {
        if (value < node.Value)
        {
            // If the left child does not exist, we want to insert
            // the value as the left child:
            if (node.Left == null)
            {
                node.Left = new TreeNode(value);
            }
            else
            {
                Insert(value, node.Left);
            }
        }
        else if (value > node.Value)
        {
            // If the right child does not exist, we want to insert
            // the value as the right child:
            if (node.Right == null)
            {
                node.Right = new TreeNode(value);
            }
            else
            {
                Insert(value, node.Right);
            }
        }
    }

    public void Run()
    {
        TreeNode root = new TreeNode(50);

        Insert(10, root);
        Insert(34, root);
        Insert(10, root);
        Insert(33, root);
        Insert(56, root);
        Insert(89, root);

        Console.WriteLine($"Root: {root.Value}");
        Console.WriteLine($"Left: {root.Left?.Value}");
        Console.WriteLine($"Right: {root.Right?.Value}");
    }
}