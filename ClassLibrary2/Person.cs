using System;

namespace ClassLibrary2
{
    public class Person
    {
        private int Age { get; set; }
        private string Name { get; set; }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public string GetName() 
        {
            return Name;
        }

    }
}
