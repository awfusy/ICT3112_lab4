﻿class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        Calculator _calculator = new Calculator();
        // Display title as the C# console calculator app.
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");
        while (!endApp)
        {
            // Declare variables and set to empty.
            string numInput1 = "";
            string numInput2 = "";
            string numInput3 = "";
            double result = 0;
            // Ask the user to type the first number.
            Console.Write("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();
            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numInput1 = Console.ReadLine();
            }
            // Ask the user to type the second number.
            Console.Write("Type another number, and then press Enter: ");
            numInput2 = Console.ReadLine();
            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numInput2 = Console.ReadLine();
            }
            Console.Write("Type another number, and then press Enter: ");
            numInput3 = Console.ReadLine();
            double cleanNum3= 0;
            while (!double.TryParse(numInput3, out cleanNum3))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numInput3 = Console.ReadLine();
            }
            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tf - Factorial for first number");
            Console.WriteLine("\tt - triangle");
            Console.WriteLine("\tc - Cricle");
            Console.WriteLine("\tFI - Failure Intensity");
            Console.WriteLine("\tAFI - Average Failure Intensity");
            Console.WriteLine("\tALFI - Average Log Failure Intensity");
            Console.WriteLine("\tSRDD - Second Release Defect Density");
            Console.WriteLine("\tx - Magic number");
            Console.Write("Your option? ");
            string op = Console.ReadLine();
            try
            {
                result = _calculator.DoOperation(cleanNum1, cleanNum2,cleanNum3, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error.\n");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying math.\n - Details: " + e.Message);
            }
            Console.WriteLine("------------------------\n");
            // Wait for the user to respond before closing.
            Console.Write("Press 'q' and Enter to quit the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "q") endApp = true;
            Console.WriteLine("\n"); // Friendly linespacing.
        }
        return;
    }
}
