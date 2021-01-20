using System;
using System.Collections.Generic;

namespace GradeBook 
{
  class Book {
    // constructor -> have same name as class name
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }
    public void AddGrade(double grade) 
    {
      grades.Add(grade);
    }

    public void showStatistics()
    {
      double result = 0.0;
      double highGrade = double.MinValue;
      double lowGrade = double.MaxValue;
      foreach(double number in grades) {
        highGrade = Math.Max(number, highGrade);
        lowGrade = Math.Min(number, lowGrade);
        result += number;
      }

      double average = result / grades.Count;
      Console.WriteLine($"The average grade is {average:N4}");
      Console.WriteLine($"Highest grade is {highGrade}");
      Console.WriteLine($"Lowest grade is {lowGrade}");
    }

    // Add a field
    private List<double> grades;
    private string name;
  }
}