using System;

namespace Fundamentals
{

  class TryParseMethod
  {

    public static void FirstSample()
    {
      // Console.Write("Enter a number -> ");
      // var input = Console.ReadLine();

      string input = "34";

      bool isParsingSuccessful = int.TryParse(input, out int number);
      Console.WriteLine(isParsingSuccessful);

      var message = isParsingSuccessful ? $"The given input: \"{input}\" is the number {number}" : $"The Given input \"{input}\" is not a number";

      Console.WriteLine(message);

      var isInteger = false;
      int number2;
      do
      {
        Console.Write("\nIntroduce some integer value: ");
        var input2 = Console.ReadLine();

        isInteger = int.TryParse(input2, out number2);

      } while (!isInteger);

      Console.WriteLine(number2);
    }
  }
}