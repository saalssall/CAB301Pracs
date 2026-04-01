using System;


namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        { 
           
           //Stacks 
            Stacks stack = new Stacks();
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("pushing " + i);
                
                stack.push(i);
                Console.WriteLine("Top of stack holds " + stack.peek());
            }
            Console.WriteLine("Stack size = " + stack.size());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("popping " + stack.pop());
            }

            Console.WriteLine("Stack size = " + stack.size());

            if (stack.empty())
            {
                Console.WriteLine("The stack is now empty");
            }

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("pushing " + i);
                stack.push(i);
            }

            Console.WriteLine("Peeking at the top of the stack the element is "+stack.peek());
            
            Queues queue = new Queues();
            queue.suming(2, 3);
            Arrays newArr = new Arrays();
            
            LinkedLists linkedList = new LinkedLists();
            linkedList.Equals(newArr);
            

        }
    }
}
