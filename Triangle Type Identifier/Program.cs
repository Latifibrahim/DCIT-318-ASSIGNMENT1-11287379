﻿using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter the length of the first side: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the second side: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the third side: ");
        double side3 = double.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }
    }
}

