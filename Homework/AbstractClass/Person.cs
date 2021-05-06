using System;

namespace AbstractClass
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public int Age { get; set; }

        public void Introduse()
        {
            Console.WriteLine("This is {0} he/she is {1} year old", Name, Age);
        }
        public abstract void GetAJob(string company, double salary);

    }
}