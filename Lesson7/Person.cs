using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Person
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public string surname { get; private set; }
        public Person(string surname, string name, int age )
        {
            this.name=name;
            this.age = age;
            this.surname = surname;
        }
        
    }
}
