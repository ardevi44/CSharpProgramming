using System;

namespace Fundamentals
{

  class Variables
  {
    public enum Days
    {
      Monday = 1,
      Tuesday = 2,
      Wednesday = 3,
    }
    public static void PlayingVariables()
    {

      string userInput = "A";
      Console.WriteLine(userInput);

      userInput = "ABC";
      Console.WriteLine(userInput);

      // int number = 2;
      // number = 3;

      // Naming variables ...

      // Put a keyword as a name of variables "@"
      int @int = 23;
      Console.WriteLine(@int);

      // Implicitly typed variables ...

      // We have tu initialize when use var, and also we can't change the type later in the code.
      var name = "Arbey";
      Console.WriteLine(name);
      // name = 34; // Error

      var number1 = 23;
      Console.WriteLine(number1);
      number1 = 98; // Right

      // Inputs
      Console.Write("Write something here: ");
      var userChoice = Console.ReadLine();
      Console.WriteLine($"User input: {userChoice}");
    }


    // Try to parse a string variable into number, handling an error.
    public static void ParcingValues()
    {
      Console.WriteLine("Provide a number");
      string userInput = Console.ReadLine();
      int number;
      try
      {
        number = int.Parse(userInput);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        Console.WriteLine("The function doesn't works because the input is not a number");
        Console.WriteLine("Your number now is 0");
        number = 0;
      }
    }

    public static void UsingEnums()
    {
      Console.Write($"Today is {Days.Tuesday} as a numeric vaue it will be {(int)Days.Tuesday}");
    }
  }

}