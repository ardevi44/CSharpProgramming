using System;

namespace Fundamentals.Assignments
{

  class SimpleCalculator
  {
    public static void ExecuteCalculator()
    {
      Console.Write("\nHello!\n\nInput the first number -> ");
      double a = double.Parse(Console.ReadLine());
      Console.Write("\nInput the second number -> ");
      double b = double.Parse(Console.ReadLine());
      Console.Write("\nWhat do you want to do with those numbers?" +
      "\n\n[A]dd" +
      "\n[S]ubtract" +
      "\n[M]ultiply" +
      "\n-> ");
      string? option = Console.ReadLine();
      SolveTheOption(option, a, b);
      Console.ForegroundColor = ConsoleColor.Gray;
      Console.WriteLine("\n\nPress any key to close...");
      Console.ReadKey();

      void SolveTheOption(string option, double a, double b)
      {
        string message = "Result: ";
        bool isInvalid = false;
        if (option == "A" || option == "a")
        {
          message += $"{a} + {b} = {(a + b)}";
        }
        else if (option == "S" || option == "s")
        {
          message += $"{a} - {b} = {(a - b)}";
        }
        else if (option == "M" || option == "m")
        {
          message += $"{a} * {b} = {(a * b)}";
        }
        else
        {
          message = "Invalid Choice";
          isInvalid = true;
        }

        if (isInvalid)
        {
          Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Green;
        }
        Console.WriteLine($"\n{message}");
      }
    }
  }
}