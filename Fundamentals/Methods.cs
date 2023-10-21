using System;

namespace Fundamentals
{

  class Methods
  {

    public static void PlayCallingMethods()
    {
      /*
      // Call the PrintMessage method based on the input letter.

      Console.Write("Write an option: ");
      var userChoice = Console.ReadLine();

      if (userChoice == "s" || userChoice == "s".ToUpper())
      {
        PrintMessage("See all TODOs");
      }
      else if (userChoice == "a" || userChoice == "a".ToUpper())
      {
        PrintMessage("Add a TODO");
      }
      else if (userChoice == "r" || userChoice == "r".ToUpper())
      {
        PrintMessage("Remove a TODO");
      }
      else if (userChoice == "e" || userChoice == "e".ToUpper())
      {
        PrintMessage("Exit");
      }
      else
      {
        PrintMessage("Option not allowed");
      }
       */
      int methodCall = 0;
      Console.Write($"Result: {Add(23, 45)}");
      Console.Write($"Result: {Add(1, 2)}");
      Console.Write($"Result: {Add(23, 30)}");
      Console.Write($"Result: {Add(4, 5)}");
      Console.Write($"Result: {Add(11, 4)}");


      // This Methods is in the local context of "PlayCallingMethods"

      // Prints the option or the error message.

      static void PrintMessage(string selectedOption)
      {
        string errorMessage = "Option not allowed";
        string fPMessage = "\n-> ";
        // If is a wrong choice ...just put it into the console and ends the execution.
        if (selectedOption == errorMessage)
        {
          Console.WriteLine($"\n{selectedOption}");
          return;
        }
        Console.WriteLine($"{fPMessage} {selectedOption}");
      }

      int Add(int a, int b)
      {
        ++methodCall;
        int[] numbers;
        if (a >= 10 && b >= 10)
        {
          Console.Write($"\n\n{methodCall}. -> {a} + {b} Sum success, ");
          return a + b;
        }
        else
        {
          Console.WriteLine($"\n\n{methodCall}. -> We can't do {a} + {b}");
          numbers = new[] { a, b };
          foreach (var item in numbers)
          {
            if (item < 10)
            {
              Console.WriteLine($"{item} most be greater or iqual than 10");
            }
          }
          return 0;
        }
      }
    }


  }
}