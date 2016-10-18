using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            var input = "";

            while (input != "end of dates")
            {
                input = Console.ReadLine();
                if (input != "end of dates")
                {
                    string[] student = input.Split().ToArray();
                    var name = student[0];
                    var dates = student[1];
                    List<DateTime> listOfDates = new List<DateTime>();
                    listOfDates = dates
                        .Split(',')
                        .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy",
                                  CultureInfo.InvariantCulture)).ToList();
                    var st = new Student();
                    st.Name = name;
                    st.Dates = listOfDates;
                    if (!students.Contains(new Student { Name = name }))
                    {
                        students.Add(st);
                    }
                    else
                    {
                        var index = students.FindIndex(c => c.Name == name);
                        students[index].Dates.Concat(st.Dates);
                    }
                    
                }
             }

            var comment = "";

            SortedDictionary<string, List<string>> comments = 
                new SortedDictionary<string, List<string>>();
            while (comment != "end of comments")
            {
                comment = Console.ReadLine();
                if (comment != "end of comments")
                {
                    string[] studentComm = comment.Split('-').ToArray();
                    var name = studentComm[0];
                    var comm = studentComm[1];

                    if (students.Contains( new Student {Name = name }))
                    {
                        comments[name].Add(comm);
                    }
                }
            }

            
            foreach (var comm in comments)
            {
                Console.WriteLine(comm.Key);
                Console.WriteLine("Comments:");
                Console.WriteLine(string.Join(Environment.NewLine, comm.Value));
                Console.WriteLine("Dates attended:");
                var d = students.Select(s => s.Name == comm.Key).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, d));
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}
