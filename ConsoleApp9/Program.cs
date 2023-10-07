using CalculatorLibrary;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lab 1
            #region lab1
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
            #region lab2
            //CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();
            //double result;
            //result = calculator.DoOperation(4, 5, "a");
            //Console.WriteLine(result);
            #endregion

            //lab 3 #8
            #region lab3
            //Console.WriteLine("8. Вычислить площадь равностороннего треугольника, если известна длина его стороны.");
            //Console.WriteLine("Введите длину стороны:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double h = (Math.Pow(a, 2) - Math.Pow((a / 2), 2));
            //double square = a * Math.Sqrt(h) / 2;
            //Console.WriteLine($"Площадь: {square}");
            #endregion

            //lab 4
            #region lab4
            //Human hm = new Human("John", "Johnson", false);
            //hm.Print();

            //// 2. Использование экземпляра класса Citizen
            //Citizen ct = new Citizen("Petr", "Petrenko", false, "A101ksdl233", "New City");
            //Console.WriteLine("------------------------");
            //ct.Print(); // вывести значение полей класса

            //// 3. Использование экземпляра класса ForeignCitizen
            //ForeignCitizen fc = new ForeignCitizen("Ivanov", "Ivan", false,
            //    "0230902ADK", "London", "023329032JJK",
            //    Convert.ToDateTime("02.02.2020"), Convert.ToDateTime("03.03.2085"));
            //Console.WriteLine("------------------");
            //fc.Print();


            #endregion

            //lab 5
            #region lab5
            //сделано отдельно
            #endregion
        }
    }
}