using System;
using System.Collections.Generic;

namespace OOP.Practice
{

  class UsingClasses
  {

    public static void CallingObjects()
    {
      Console.Clear();
      var rectangle1 = new Rectangle(5, 10);
      var rectangle2 = new Rectangle(17, 12);

      List<Rectangle> rectangleList = new List<Rectangle>() {
        rectangle1,
        rectangle2
      };


      // foreach (var rectangle in rectangleList)
      // {
      //   Console.WriteLine($"-- Rectangle {rectangleList.IndexOf(rectangle) + 1} --");
      //   Console.WriteLine($"Width {rectangle.Width}");
      //   Console.WriteLine($"Height {rectangle.Height}");
      // }

      var booking1 = new HotelBooking("Jose Arbey", DateTime.Now, 5);
      booking1.PrintBookingInfo();
    }

  }

  class Rectangle
  {
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
      Width = width;
      Height = height;
    }
  }

  public class HotelBooking
  {
    public string GuestName;
    public DateTime StartDate;
    public DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
      GuestName = guestName;
      StartDate = startDate;
      EndDate = StartDate.AddDays(lengthOfStayInDays);
    }

    public void PrintBookingInfo()
    {
      Console.WriteLine($"Guest Name: {GuestName}");
      Console.WriteLine($"Start Date: {StartDate.ToString("D")}");
      Console.WriteLine($"End Date: {EndDate.ToString("D")}");
    }
  }
}