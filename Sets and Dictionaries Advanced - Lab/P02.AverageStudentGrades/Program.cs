using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();
            int gradesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < gradesCount; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                string name = line[0];
                decimal grade = decimal.Parse(line[1]);
                if(!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<decimal>());
                }
                studentsGrades[name].Add(grade);
            }
            foreach (var name in studentsGrades.Keys)
            {
                List<decimal> grades = studentsGrades[name];
                string gradesStr = string.Join(" ", grades.Select(g => g.ToString("f2")));
                decimal avg = studentsGrades[name].Average();
                Console.WriteLine($"{name} -> {gradesStr} (avg: {avg :f2})");
            }  
        }
    }
}
