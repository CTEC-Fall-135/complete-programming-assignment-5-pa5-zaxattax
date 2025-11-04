/*
Author: Zachery Alexander
Date: 10/5/2025
Assignment: Programming Assignment 5 (PA5)
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        #region Stack
        // declare and initalize a stack with numbers 1 to 5
        Stack<int> stack = new Stack<int>(new int[] { 1, 2, 3, 4, 5 });

        // print members of stack with foreach loop
        Console.WriteLine("Stack values:");
        foreach (int number in stack)
        {
            Console.WriteLine(number);
        }

        // print peek at top member
        Console.WriteLine($"\nPeek at top member in stack: {stack.Peek()}");

        // pop elements off and print
        Console.WriteLine("\nPopping elements from stack:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());

        }
        #endregion

        #region Queue
        // declare a queue
        Queue<int> queue = new Queue<int>();

        // initialize with numbers 1 to 5 using for loop
        for (int i = 1; i <= 5; i++)
        {
            queue.Enqueue(i);
        }

        // print members of queue with foreach loop
        Console.WriteLine("\nQueue members:");
        foreach (int number in queue)
        {
            Console.WriteLine(number);
        }

        // peek at the top member in stack
        Console.WriteLine($"\nPeek at front member in queue: {queue.Peek()}");

        // dequeue elements off and print
        Console.WriteLine("\nDequeing elements from queue:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        #endregion

    }
}