namespace Stack;

public class HashTable
{
    static int CAPACITY = 10;
    private int capacity;
    private int numElements;
    
    private int[] myArray;

    public HashTable()
    {
        this.capacity = CAPACITY;
    }

    public void hashFunction(int key)
    {
        key = key % capacity;
    }

    public void insert(int key)
    {
        if  (capacity < key)
        {
            capacity = key;
        }
        else
        {
            Console.WriteLine("The key is " + key);
        }
    }

    public void display()
    {
        Console.WriteLine(numElements);
    }
    
    
    
}