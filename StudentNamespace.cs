using Modul10HW.PersonNamespace;
using static Modul10HW.StudentNamespace;
using System;
using static Modul10HW.TeacherNamespace;
namespace Modul10HW
{

    namespace StudentNamespace
    {
        public class Student : PersonNamespace.Person
        {
            public int StudentId { get; set; }
            public object Name { get; private set; }
            public object Age { get; private set; }

            public override void Print()
            {
                Console.WriteLine($"StudentID: {StudentId}, Name: {Name}, Age: {Age}");
            }
        }
    }
}
