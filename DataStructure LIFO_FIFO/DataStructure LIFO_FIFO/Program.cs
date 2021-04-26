using System;
using System.Collections.Generic;

namespace DataStructure_LIFO_FIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            //fill the queue
            foreach(int number in new int[8] { 15, 47, 38, 89, 2, 61, 53, 24 })
            {
                numbers.Enqueue(number);
                Console.WriteLine("{0} has joined the queue", number);
            }

            //interate through the queue
            Console.WriteLine("\nThe queue contains the following items:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //Dequeue remove it
            Console.WriteLine("Removing items:");
            while (numbers.Count > 0)
            {
                int number = numbers.Dequeue();
                Console.WriteLine("{0} has left the queue", number);
            }

            //stack

            Stack<int> number1 = new Stack<int>();

            //fill the sstack
            Console.WriteLine("Pushing items to the stack:");
            foreach(int number12 in new int[8] { 15, 47, 38, 89, 2, 61, 53, 24 })
            {
                number1.Push(number12);
                Console.WriteLine("{0} has been pushed on the stack", number12);
            }

            //iterate through the stack
            Console.WriteLine("\n The stack now contain:");
            foreach(int number12 in number1)
            {
                Console.WriteLine(number12);
            }

            //empty the stack
            while(number1.Count>0)
            {
                int number12 = number1.Pop();
                Console.WriteLine("{0} has been popped", number12);
            }
        }
    }
}
