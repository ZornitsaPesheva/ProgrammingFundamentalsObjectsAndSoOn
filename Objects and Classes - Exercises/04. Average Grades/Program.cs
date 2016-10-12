using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Student st = new Student();
                string[] data = Console.ReadLine()
                    .Split().ToArray();
                st.Name = data[0];
                List<double> grades = new List<double>();
                for (int j = 1; j < data.Length; j++)
                {
                    double grade = double.Parse(data[j]);
                    grades.Add(grade);
                }
                st.Grades = grades;
                students.Add(st);
            }
            var result = students
                .Where(s => s.AvarageGrade >= 5)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AvarageGrade);
            

            foreach (var s in result)
            {
                Console.WriteLine($"{s.Name} -> {s.AvarageGrade:f2}");
            }
        }
    }
    
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AvarageGrade
        {
            get
            {
                if (Grades.Count > 0)
                {
                    return Grades.Average();
                }
                else
                {
                    return 0;
                }
            }
        }
        

    }
}
