using System;
using System.Collections.Generic;
using System.IO;

var numbers = new List<int>();
foreach (string line in File.ReadLines("input.txt"))
{
    if (int.TryParse(line, out int number))
    {
        numbers.Add(number);
    }
}

foreach (int number1 in numbers)
{
    foreach (int number2 in numbers)
    {
        if (number1 + number2 == 2020)
        {
            Console.WriteLine("The two numbers are: " + number1 + " and " + number2);
            Console.WriteLine("Their product is: " + (number1 * number2));
            return;
        }
    }
}

Console.WriteLine("No two numbers were found that sum to 2020.");
