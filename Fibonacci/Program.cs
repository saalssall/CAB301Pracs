using System;


// Fibonacci number using a for loop
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

