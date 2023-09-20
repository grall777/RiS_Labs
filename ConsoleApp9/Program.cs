﻿using CalculatorLibrary;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lab 1
            #region
            //int exit = 0;
            //while (exit == 0)
            //{


            //    // Declare variables and then initialize to zero.
            //    int num1 = 0; int num2 = 0;

            //    // Display title as the C# console calculator app.
            //    Console.WriteLine("Console Calculator in C#\r");
            //    Console.WriteLine("------------------------\n");

            //    // Ask the user to type the first number.
            //    Console.WriteLine("Type a number, and then press Enter");
            //    num1 = Convert.ToInt32(Console.ReadLine());

            //    // Ask the user to type the second number.
            //    Console.WriteLine("Type another number, and then press Enter");
            //    num2 = Convert.ToInt32(Console.ReadLine());

            //    // Ask the user to choose an option.
            //    Console.WriteLine("Choose an option from the following list:");
            //    Console.WriteLine("\ta - Add");
            //    Console.WriteLine("\ts - Subtract");
            //    Console.WriteLine("\tm - Multiply");
            //    Console.WriteLine("\td - Divide");
            //    Console.WriteLine("\te - Exit");

            //    Console.Write("Your option? ");

            //    // Use a switch statement to do the math.
            //    switch (Console.ReadLine())
            //    {
            //        case "a":
            //            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            //            break;
            //        case "s":
            //            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            //            break;
            //        case "m":
            //            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            //            break;
            //        case "d":
            //            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            //            break;
            //        case "e":
            //            exit = 1;
            //            break;
            //    }
            //    // Wait for the user to respond before closing.
            //    Console.Write("Press any key to close the Calculator console app...");
            //    Console.ReadKey();
            //}
            #endregion // lab 1

            //lab 2

            CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();
            double result;
            result = calculator.DoOperation(4, 5, "a");

            Console.WriteLine(result);
        }
    }
}