// Created by: Jaejun Lee
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userInteger;
        Console.WriteLine("Put your age:");
        userInteger = int.Parse(Console.ReadLine());
        if (userInteger >= 17)
        {
            userInteger = Convert.ToInt32(Console.Read());
            Console.WriteLine("You can see an R movie alone.");
        }
        else if (userInteger >= 13)
        {
            userInteger = Convert.ToInt32(Console.Read());
            Console.WriteLine("You can see a PG-13 movie alone.");
        }
        else if (userInteger >= 5)
        {
            userInteger = Convert.ToInt32(Console.Read());
            Console.WriteLine("You can see a G or PG movie alone.");
        }
        else
        {
            Console.WriteLine("Uh, you're too young for most things..");
        }
    }
}