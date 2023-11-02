using Modul10HW.PersonNamespace;
using static Modul10HW.StudentNamespace;
using System;
using System.Collections.Generic;
using static Modul10HW.TeacherNamespace;


namespace Modul10HW
{
    namespace TeacherNamespace
    {
        public class Teacher : PersonNamespace.Person
        {
            public List<StudentNamespace.Student> Students { get; set; }
            public object Name { get; private set; }
            public object Age { get; private set; }

            public override void Print()
            {
                Console.WriteLine($"Teacher: {Name}, Age: {Age}");
            }
        }
    }
}

