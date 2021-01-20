using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() { 12.9, 2.5, 10.9, 7.9};
            grades.Add(10.8);
            
            double result = 0.0;

            foreach(double number in grades) {
                result += number;
            }

            double average = result / grades.Count;
            Console.WriteLine(average);
        }
    }
}
