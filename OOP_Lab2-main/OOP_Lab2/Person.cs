using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}
