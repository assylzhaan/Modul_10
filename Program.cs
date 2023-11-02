using Modul10HW.PersonNamespace;
using PersonNamespace;
using StudentNamespace;
using System;
using TeacherNamespace;

namespace PersonNamespace
{
    class Program
    {
        static void Main()
        {
            Person[] people = new Person[6];
            people[0] = new Person { Name = "John", Age = 30 };
            people[1] = new Student { Name = "Alice", Age = 20, StudentId = 101 };
            people[2] = new Student { Name = "Bob", Age = 22, StudentId = 102 };
            people[3] = new Teacher { Name = "Dr. Smith", Age = 45 };
            people[4] = new Teacher { Name = "Prof. Johnson", Age = 50 };
            people[5] = new Teacher { Name = "Mrs. Davis", Age = 38 };

            int personCount = 0;
            int studentCount = 0;
            int teacherCount = 0;

            foreach (var person in people)
            {
                person.Print();

                if (person is Student)
                {
                    studentCount++;
                }
                else if (person is Teacher)
                {
                    teacherCount++;
                }
                else
                {
                    personCount++;
                }
            }

            Console.WriteLine($"People: {personCount}, Students: {studentCount}, Teachers: {teacherCount}");
        }
    }

}
