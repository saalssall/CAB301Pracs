namespace MyNamespace;

public class TreeNode
{
    public int Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }

    public TreeNode(int val, TreeNode? left = null, TreeNode? right = null)
    {
        Value = val;
        Left = left;
        Right = right;
    }

    public void Run()
    {
        TreeNode node1 = new TreeNode(25);
        TreeNode node2 = new TreeNode(75);
        TreeNode root = new TreeNode(50, node1, node2);
           
        Console.WriteLine($"Root: {root.Value}");
        Console.WriteLine($"Left: {root.Left?.Value}");
        Console.WriteLine($"Right: {root.Right?.Value}");
    }
    
}