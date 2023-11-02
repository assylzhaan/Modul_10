using System;

namespace Person
{
    public class Person
    {
        public string Name { get; internal set; }
        public int Age { get; internal set; }

        internal void Print()
        {
            throw new NotImplementedException();
        }
    }
}