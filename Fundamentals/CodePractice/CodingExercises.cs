using System;

namespace Fundamentals.CodePractice
{
  class CodingExercises
  {

    public static int CalculateSumOfNumbersBetween(int firstNumber, int secondNumber)
    {
      var sum = 0;

      if (firstNumber > secondNumber)
      {
        return 0;
      }

      while (firstNumber <= secondNumber)
      {
        sum += firstNumber;
        firstNumber++;
      }

      return sum;
    }


    public static string RepeatCharacter(char character, int targetLength)
    {
      //your code goes here
      var result = "";
      do
      {
        result += character;
        targetLength--;
      } while (targetLength >= 1);
      Console.WriteLine(result.Length);
      return result;
    }

    public static int Factorial(int number)
    {
      //your code goes here
      int count;
      int factorial = 1;
      if (number == 0)
      {
        return factorial;
      }
      for (count = 1; count <= number; count++)
      {
        factorial *= count;
      }
      return factorial;
    }

    public static int FindMax(int[,] numbers)
    {
      if (numbers.GetLength(0) == 0 || numbers.GetLength(1) == 0)
      {
        return -1;
      }

      int maximumVal = numbers[0, 0];

      for (int i = 0; i < numbers.GetLength(0); i++)
      {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
          if (numbers[i, j] > maximumVal)
          {
            maximumVal = numbers[i, j];
          }
        }
      }

      return maximumVal;
    }
  }
}