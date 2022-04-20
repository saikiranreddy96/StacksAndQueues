using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Stacks And Queues Program");

            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);

            //Peek Value from Stack
            linkedListStack.Peek();
            Console.WriteLine("----------------------------");
            linkedListStack.Pop();

            //Pop value till Stack will empty
            linkedListStack.IsEmpty();

            //Display
            linkedListStack.Display();

            Console.ReadLine();
        }
    }
}
