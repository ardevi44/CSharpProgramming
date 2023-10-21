using System;
using System.Linq;

namespace Fundamentals
{
  class Arrays
  {
    public static void PlayingWithArrays()
    {
      // One way to create arrays.
      /* int[] numbers = new int[5]; */

      // Another way to creates arrays
      int[] numbers = new int[] { 1, 45, 89, 23, 67, 82 };

      // When we use var we don't need to specify
      var letters = new string[] { "Helo", "world", "how", "are", "you", "?" };

      /*
      // Accessing to each element.
      numbers[0] = 34;
      numbers[1] = 23;
      numbers[2] = 2;
      numbers[3] = 17;
      numbers[4] = 23;
       */

      IterateIntArray(numbers);

      var firstFromEnd = numbers[^1];
      var secondFromEnd = numbers[^2];

      Console.WriteLine($"First from end: {firstFromEnd}");
      Console.WriteLine($"Second from end: {secondFromEnd}");
      /*
      foreach (int value in numbers)
      {
        Console.WriteLine(value);
      }
      */
    }

    public static void IterateIntArray(int[] arr)
    {
      foreach (var (item, index) in arr.Select((value, i) => (value, i)))
      {
        Console.WriteLine($"{index + 1}: {item}");
      }
    }

    // Working with multi-dimensional array.
    public static void WorkingWithMultiDimensionalArrays()
    {
      // char[,] letters = new char[2, 3];

      /*
      letters[0, 0] = 'A';
      letters[0, 1] = 'B';
      letters[0, 2] = 'C';
      letters[1, 0] = 'D';
      letters[1, 1] = 'E';
      letters[1, 2] = 'F';
       */


      char[,] letters = new char[,] {
        {'a','b','c'},
        {'d','e','f'}
      };


      // Iterate with a traditional for loop.

      int width = letters.GetLength(0);
      int height = letters.GetLength(1);
      for (int i = 0; i < width; i++)
      {
        for (int j = 0; j < height; j++)
        {
          Console.WriteLine($"Position [{i},{j}]: {letters[i, j]}");
        }
      }

      // Iterate with a foreach loop

      // foreach (char letter in letters)
      // {
      //   Console.WriteLine(letter);
      // }
    }
  }
}