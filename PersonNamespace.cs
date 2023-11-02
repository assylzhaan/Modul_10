using Modul10HW.PersonNamespace;
using static Modul10HW.StudentNamespace;
using System;
using System.Collections.Generic;
using static Modul10HW.TeacherNamespace;


namespace Modul10HW
{
    
        namespace PersonNamespace
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public virtual void Print()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }

            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}";
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Person other = (Person)obj;
                return this.Name == other.Name && this.Age == other.Age;
            }

            public override int GetHashCode()
            {
                return Name.GetHashCode() ^ Age;
            }

            public static bool operator ==(Person person1, Person person2)
            {
                if (ReferenceEquals(person1, person2))
                    return true;

                if (person1 is null || person2 is null)
                    return false;

                return person1.Equals(person2);
            }

            public static bool operator !=(Person person1, Person person2)
            {
                return !(person1 == person2);
            }
        }
    }

}
