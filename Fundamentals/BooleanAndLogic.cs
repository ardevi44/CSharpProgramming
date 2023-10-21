using System;

namespace Fundamentals
{

  class BooleanAndLogic
  {
    public static void TrySomeLogic()
    {
      bool someBoolean = true;
      var someOtherBool = false;

      // Console.WriteLine(someBoolean);
      // Console.WriteLine(someOtherBool);

      var userChoice = "ABC";
      bool isUserInputAbc = userChoice == "ABC";
      bool isUserInputNotAbc = userChoice != "ABC";
      bool isUserInputNotAbc2 = !(userChoice == "ABC");

      // Console.WriteLine($"{isUserInputAbc}, {isUserInputNotAbc}, {isUserInputNotAbc2}");

      var number = 5;
      Console.WriteLine(number > 5);
      Console.WriteLine(number < 10);
      Console.WriteLine(number >= 10);
      Console.WriteLine(number <= 6);

      var moduloResult = 10 % 3 == 1;
      Console.WriteLine(moduloResult);

      // And and Or Logical Operators
      number = 10;
      string message = "";
      var boolValue = number > 4 && number < 9; // False
      message = $"{number} > 4 && {number} < 9: {boolValue}";
      Console.WriteLine(message);

      boolValue = number == 2 || number > 6; // True
      message = $"{number} == 2 || {number} > 6: {boolValue}";
      Console.WriteLine(message);

      boolValue = number == 123 || (number % 2 == 0 && number < 20); // True
      message = $"{number} == 123 || ({number} % 2 == 0 && {number} < 20): {boolValue}";
      Console.WriteLine(message);

      // If / Else statement

      /*When we use "else if" we are evaluating just one option at a time
      When just use "if" we evaluate all the posibilities*/
      var input = "Hello World";
      if (input.Length <= 3)
      {
        Console.WriteLine("Short answer.");
      }
      else if (input.Length < 10)
      {
        Console.WriteLine("Medium answer.");
      }
      else
      {
        Console.WriteLine("Large answer");
      }
    }

    public static string DescribeDay(int dayNumber)
    {
      switch (dayNumber)
      {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
          return "Working day";
        case 6:
        case 7:
          return "Weekend";
        default:
          return "Invalid day number";
      }
    }
  }
}