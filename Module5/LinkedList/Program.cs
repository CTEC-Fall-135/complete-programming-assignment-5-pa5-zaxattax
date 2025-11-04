/*
Author: Zachery Alexander
Date: 10/5/2025
Assignment: Programming Assignment 5 (PA5)
*/

using System;

class Program
{
    static void Main()
    {
        // create string array with nursery rhyme words - about 5-10
        string[] rhymeWords = { "Twinkle", "twinkle", "little", "star", "how", "I", "wonder", "what", "you", "are" };

        // create linked list using the array
        LinkedList<string> rhyme = new LinkedList<string>(rhymeWords);

        // print using foreach
        Console.WriteLine("Rhyme using enumerator:");
        foreach (string word in rhyme)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();

        // walk the list using nodes (traditional way)
        Console.WriteLine("\nRhyme walking nodes:");
        LinkedListNode<string> currentNode = rhyme.First;
        while (currentNode != null)
        {
            Console.Write(currentNode.Value + " ");
            currentNode = currentNode.Next;
        }
        Console.WriteLine();

        // remove a word from the middle
        rhyme.Remove("how");
        Console.WriteLine("\nAfter removing 'how':");
        foreach (string word in rhyme)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();

        // add the word back in, then print again
        LinkedListNode<string> starNode = rhyme.Find("star");
        rhyme.AddAfter(starNode, "how");

        Console.WriteLine("\nAfter adding 'how' back:");
        foreach (string word in rhyme)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}