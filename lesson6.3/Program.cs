using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lesson6._3
{
    /// <summary>
    /// Переделать программу Пример использования коллекций для решения следующих задач:
    /// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    /// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
    /// в) отсортировать список по возрасту студента;
    /// г) * отсортировать список по курсу и возрасту студента;
    ///
    /// Наумов Илья
    /// 
    /// </summary>
    class Program
    {
        class Student
        {
            public string LastName { set;  get; }
            public string FirstName { set; get; }
            public int Course { set; get; }
            public int Age { set; get; }

            internal static Student FromCsv(string csv)
            {
                string[] values = csv.Split(',');
                Student student = new Student();
                student.LastName = values[0];
                student.FirstName = values[1];
                student.Age = Convert.ToInt32(values[2]);
                student.Course = Convert.ToInt32(values[3]);
                return student;
            }
        }

        static void Main(string[] args)
        {
            List<Student> students = File.ReadAllLines("students.csv")
                                            .Skip(1)
                                            .Select(s => Student.FromCsv(s))
                                            .ToList();
            Console.WriteLine(students[0].LastName);
            //A 
            var a = students.Where(s => s.Course == 4 || s.Course == 5).Count();//я сгенерил до 5 курса, буду выбирать 4 и 5 курс 
            Console.WriteLine($"Студентов которые учатся на 4 и 5 курсе {a}");
            
            //B
            var grouped = from student in students
                    where student.Age >= 18 && student.Age <= 20
                    group student by student.Course into c
                    select new
                    {
                        Course = c.Key,
                        Age = from s in c group s by s.Age
                    };
            foreach(var c in grouped)
            {
                Console.WriteLine($"Курс № {c.Course}");
                foreach(var stud in c.Age)
                {
                    Console.WriteLine($"{stud.Key} - {stud.Count()}");
                }
            }

            //C
            var sortedByAge = students.OrderBy(s => s.Age).ToList();

            foreach(var s in sortedByAge)
            {
                Console.WriteLine($"{s.Age} {s.LastName} {s.FirstName} {s.Course}");
            }
        }
    }
}
