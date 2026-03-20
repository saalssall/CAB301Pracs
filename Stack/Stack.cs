//CAB301-Workshop 3
//Maolin Tang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {

        static int CAPACITY = 10;
        private int capacity;
        private int numElements;
        private int[] data;


        /// constructor initializes stack
        public Stack() {
            capacity = CAPACITY;
            numElements = 0;
            data = new int[CAPACITY];
        }


        /// returns number of elements in the stack
        public int size()
        {
            return numElements;
        }

        /// return true if the stack is empty
        public bool empty()
        {
            if (data.Length == 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("The stack is now empty");
            }
            return false;
        }

        /// adds an element to the top of the stack
        public void push(int value)
        { 
            //ensure to check if stack is full
            data[numElements] = value;
            numElements++;
            if (numElements == capacity)
            {
                Console.WriteLine("Cannot push to the stack because it's full.");
            }
        }

        /// returns the element from the top of the stack and removes it
        public int pop()
        {
            if (numElements > 0)
            {
                numElements--;
            }
            return data[numElements];
        }

        /// returns the element from the top of the stack
        public int peek()
        {
            return numElements;
        }

    }
}
