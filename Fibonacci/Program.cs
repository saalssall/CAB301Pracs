using System;
// // Fibonacci number using a for loop
int old_value = 0;
int older_value = 1;
int n = 10;

for (int i = 2; i <= n; i++)
{
    int newValue = old_value + older_value;
    Console.WriteLine("F" + i + ": " + newValue);
    old_value = older_value;
    older_value = newValue;
}

Console.WriteLine("--------------------");
// Fibonacci number using recursion
void fibonacci(int prev, int prev1, int count)
{
    if (count <= 19)
    {
        int new_value = prev + prev1;
        Console.WriteLine("F" + count + ": " + new_value);
        fibonacci(prev1, new_value, count + 1);
    }
}

fibonacci(0, 1, 2);
Console.WriteLine("--------------------");

//Another method
int Fibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

Console.WriteLine(Fibonacci(2));
Console.WriteLine(Fibonacci(3));
Console.WriteLine(Fibonacci(4));
Console.WriteLine(Fibonacci(5));

