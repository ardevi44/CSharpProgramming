using System;

namespace OOP
{

  class UnderstandingDateTime
  {

    public static void PlayingWDateTime()
    {
      var internationalPizzaDay23 = new DateTime(2023, 2, 9, 12, 34, 11);

      Console.WriteLine($"-- International Pizza Day {internationalPizzaDay23.Year} --");
      Console.WriteLine($"Year is {internationalPizzaDay23.Year}");
      Console.WriteLine($"Month is {internationalPizzaDay23.Month}");
      Console.WriteLine($"Day is {internationalPizzaDay23.Day}");
      Console.WriteLine($"Day of the week is {internationalPizzaDay23.DayOfWeek}");

      var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

      Console.WriteLine($"-- International Pizza Day {internationalPizzaDay24.Year} --");
      Console.WriteLine($"Year is {internationalPizzaDay24.Year}");
      Console.WriteLine($"Month is {internationalPizzaDay24.Month}");
      Console.WriteLine($"Day is {internationalPizzaDay24.Day}");
      Console.WriteLine($"Day of the week is {internationalPizzaDay24.DayOfWeek}");
    }
  }
}
