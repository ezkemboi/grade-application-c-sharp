using System;
namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      Book book = new Book("Class Four");
      book.AddGrade(89.1);
      book.AddGrade(90.5);
      book.AddGrade(77.3);
      // statistics 
      var stats = book.GetStatistics();
      Console.WriteLine($"The average grade is {stats.Average:N4}");
      Console.WriteLine($"Highest grade is {stats.High}");
      Console.WriteLine($"Lowest grade is {stats.Low}");
    }
  }
}
