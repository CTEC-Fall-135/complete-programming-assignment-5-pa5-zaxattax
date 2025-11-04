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
        // create and initalize dictionary
        Dictionary<int, string> dict = new Dictionary<int, string>()
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" }
        };

        // add entry using add method
        dict.Add(99, "ninety-nine");

        // print dictionary
        Console.WriteLine("Dictionary entries (using KeyValuePair):");
        foreach (KeyValuePair<int, string> entry in dict)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // reassign value of 99 using indexing
        dict[99] = "99";

        // print value of 99 using indexing
        Console.WriteLine($"\nValue of key 99: {dict[99]}");

        // remove the 2 item
        dict.Remove(2);

        // print updated dictionary
        Console.WriteLine("\nUpdated dictionary:");
        foreach (var entry in dict)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
