using System;

namespace Fundamentals
{

  class ExplicitConversion
  {

    public static void Conversions()
    {
      string stringNumber = "23";
      Console.WriteLine(int.Parse(stringNumber));

      // int intNumber = int.Parse(Console.ReadLine());
      double doubleNumber = double.Parse("45.00");
      Console.WriteLine(doubleNumber);
      Console.WriteLine(doubleNumber.GetType());
      Console.WriteLine(doubleNumber.GetType() == typeof(Double));

      DateTime currentDate = DateTime.Now;
      Console.WriteLine(currentDate);
      int currentDay = currentDate.Day;
      if (currentDay >= 15)
      {
        Console.WriteLine("We are at month half!");
      }
    }
  }
}