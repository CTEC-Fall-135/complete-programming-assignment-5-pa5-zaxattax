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
        #region Simple Array
        // Create an array of int of size 5
        int[] array = new int[5];

        // for loop to initalize 
        for (int i = 0; i <array.Length; i++)
        {
            array[i] = 11 + i;
            array[i] = 11 + i;
        }

        // foreach loop to print
        Console.WriteLine("Array values:");
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
        #endregion

        #region List<T>
        // create a list of int
        List<int> list = new List<int>();

        // for loop to initalize
        for (int i = 0; i < 5; i++)
        {
            list.Add(21 + i);
        }

        // print using foreach
        Console.WriteLine("\nList values:");
        foreach (int value in list)
        {
            Console.WriteLine(value);
        }

        // update values using for loop
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = 31 + i;
        }

        // print updated values using for and index
        Console.WriteLine("\nUpdated List values:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        #endregion
    }
}