using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    class Person : IComparable<Person>
    {
        public int age;
        public string name;
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public int CompareTo(Person other)
        {
            return this.name.CompareTo(other.name);
        }
    }
}
