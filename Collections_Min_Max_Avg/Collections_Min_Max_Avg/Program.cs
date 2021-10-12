using System;
using System.Collections.Generic;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();
            string answer;
            do
            {
                Console.WriteLine("Please enter an exam grade.");
                double grade = Convert.ToDouble(Console.ReadLine());

                examGrades.Add(grade);

                Console.WriteLine("Do you want to enter another exam grade? Yes or No? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            double max = 0;
            double average = 0;
            double min = 100;

            foreach (double grade in examGrades)
            {
                double sum =+ grade;
                average = sum / examGrades.Count;
                if (grade <= min)
                {
                    min = grade; 
                }
                if (grade >= max)
                {
                    max = grade;
                }
            }

            Console.WriteLine($"Minimum Grade: {min}");
            Console.WriteLine($"Maximum Grade: {max}");
            Console.WriteLine($"Average Grade: {average.ToString("N2")}");

        }
    }
}
