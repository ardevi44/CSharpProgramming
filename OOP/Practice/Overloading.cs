using System;

namespace OOP.Practice
{

  class Overloading
  {

    public static void PlayingMethodOverload()
    {

      // Overloading Subject

      // This will give an error cause the methods have the same name and the
      // same type of parameters.
      // The compiler will not understand what method is called.
      /*
      medicalAppointment.Reschedule(5, 1);
      medicalAppointment.Reschedule(1, 2);
      */

      var medicalAppointment = new MedicalAppointment("Ardevi", DateTime.Now);
      medicalAppointment.Reschedule(DateTime.Now);
      Console.WriteLine("---");
      medicalAppointment.Reschedule(DateTime.Now.AddDays(5));
    }


  }

  public class MedicalAppointment
  {
    private string patientName;
    private DateTime _date;

    public DateTime GetDate() => _date;
    public MedicalAppointment(string patientName, DateTime date)
    {
      this.patientName = patientName;
      _date = date;
    }

    // Calling a constructor from another.
    public MedicalAppointment(string patientName) :
    this(patientName, 7)
    {
    }

    public MedicalAppointment(string patientName, int daysFromNow)
    {
      this.patientName = patientName;
      _date = DateTime.Now.AddDays(daysFromNow);
    }

    // Simple Reschedule
    public void Reschedule(DateTime date)
    {
      var printer = new MedicalAppointmentPrinter();
      _date = date;
      printer.Print(this);
    }

    /*
    // Same name width same types of paramethers
    public void Reschedule(int month, int day)
    {
      _date = new DateTime(_date.Year, month, day);
    }

    // Same name width same types of paramethers
    public void Reschedule(int monthsToAdd, int daysToAdd)
    {
      _date = new DateTime(
        _date.Year,
        _date.Month + monthsToAdd,
        _date.Day + daysToAdd
      );
    }

    This is a case in to change the name of the methods is a good solution
    but in other cases is good just diference them by the order and the type
    of the parameters
    */

    public void OverwriteMonthAndDay(int month, int day)
    {
      _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
      _date = new DateTime(
        _date.Year,
        _date.Month + monthsToAdd,
        _date.Day + daysToAdd
      );
    }
  }

  public class MedicalAppointmentPrinter
  {
    public void Print(MedicalAppointment medicalAppointment)
    {
      Console.WriteLine("Appointment will take place on " + medicalAppointment.GetDate());
    }
  }

}