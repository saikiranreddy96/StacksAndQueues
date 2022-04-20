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
            Console.WriteLine("Welcome To The Stacks And Queues Program\n");

            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            Console.WriteLine("----------------");
            //Display Queue
            linkedListQueue.Display();

            //Dequeue from queue
            linkedListQueue.Dequeue();

            //Empty Dequeue
            linkedListQueue.IsEmpty();

            //Display Queue
            linkedListQueue.Display();
            Console.WriteLine("----------------");


            Console.ReadLine();
        }
    }
}
