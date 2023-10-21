using System;
using System.Collections.Generic;

namespace Fundamentals
{

  class OutKeyword
  {

    public static void FirstSampleWithOutKeyWord()
    {
      // The parameter of Array of numbers.
      var numbers = new[] { 10, -8, 2, 12, -17 };
      // The out parameter
      int nonPositiveCount;

      // Calling the out method with its out parameter.
      var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);
      /*It doesn't work as we think cause we're not passing a simple argument
      whithout the "out" keyword we are just passing a copy of the */

      // Iterate over the onlyPositive returned value.
      foreach (var positiveNumber in onlyPositive)
      {
        Console.WriteLine(positiveNumber);
      }
      Console.WriteLine("Count of non positive: " + nonPositiveCount);
    }

    public static List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
    {
      countOfNonPositive = 0;
      var result = new List<int>();
      foreach (int number in numbers)
      {
        if (number > 0)
        {
          result.Add(number);
        }
        else if (number < 0)
        {
          countOfNonPositive++;
        }
      }

      return result;
    }
  }
}