﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = (a * b);

        Console.WriteLine($"PROD = {c}");
        Console.ReadLine();
    }
}