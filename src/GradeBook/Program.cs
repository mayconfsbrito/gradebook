using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Maycon Brito");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.GetStatistics();

            // Console.WriteLine($"The lowest grade is {result.Low:N3}");
            // Console.WriteLine($"The highest grade is {result.High:N3}");
            // Console.WriteLine($"The average grade is {result:N3}");
        }
    }
}