using ClassLibrary2;
using System;

namespace ClassLibrary1
{
    public class Class1
    {
        Person person;

        public Class1()
        {
            var age = Add(3, 5);
            person = new Person(age, "Steve");

        }
        public int Add(int a, int b) 
        {
            return a+b+1;
        }

        public string Something() 
        {
            
            return person.GetName();
        }
    }
}
