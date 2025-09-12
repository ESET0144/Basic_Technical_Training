using System;
using System.Collections.Generic;

namespace StudentGradeEvaluator
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeEvaluator evaluator = new GradeEvaluator();
            evaluator.Run();
        }
    }

    public class GradeEvaluator
    {
        private const int TotalSubjects = 5;
        private const int PassingMark = 60;

        public void Run()
        {
            double[] marks = GetMarksFromUser();
            DisplayGradeReport(marks);
        }

        private double[] GetMarksFromUser()
        {
            double[] marks = new double[TotalSubjects];

            for (int i = 0; i < TotalSubjects; i++)
            {
                marks[i] = GetValidMark($"Enter marks for Subject {i + 1}: ");
            }

            return marks;
        }

        private double GetValidMark(string prompt)
        {
            double mark;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out mark) && mark >= 0 && mark <= 100)
                {
                    return mark;
                }
                Console.WriteLine("Please enter a valid mark between 0 and 100.");
            }
        }

        private double CalculateAverage(double[] marks)
        {
            double sum = 0;
            foreach (double mark in marks)
            {
                sum += mark;
            }
            return sum / TotalSubjects;
        }

        private string DetermineGrade(double average)
        {
            if (average >= 90) return "A";
            if (average >= 80) return "B";
            if (average >= 70) return "C";
            if (average >= 60) return "D";
            return "F";
        }

        private List<string> GetFailedSubjects(double[] marks)
        {
            List<string> failedSubjects = new List<string>();

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < PassingMark)
                {
                    failedSubjects.Add($"Subject {i + 1}");
                }
            }

            return failedSubjects;
        }

        private void DisplayGradeReport(double[] marks)
        {
            double average = CalculateAverage(marks);
            string grade = DetermineGrade(average);
            List<string> failedSubjects = GetFailedSubjects(marks);

            Console.WriteLine("\nStudent Grade Report");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
            }

            Console.WriteLine($"\nAverage Marks: {Math.Round(average)}");
            Console.WriteLine($"Grade: {grade}");

            if (failedSubjects.Count == 0)
            {
                Console.WriteLine("All subjects passed.");
            }
            else
            {
                Console.WriteLine($"Failed subjects: {string.Join(", ", failedSubjects)}");
            }
        }
    }
}
