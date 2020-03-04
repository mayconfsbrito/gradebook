using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Maycon Brito");
            var done = false;

            while (!done)
            {
                Console.Write("Please, insert a grade for this book or 'q' to quit:");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    done = true;
                    continue;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }

            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low:N3}");
            Console.WriteLine($"The highest grade is {stats.High:N3}");
            Console.WriteLine($"The average grade is {stats.Average:N3}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}