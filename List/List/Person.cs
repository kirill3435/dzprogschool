using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqhw
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public int Balance { get; set; }
        public List<string> Persons { get; set; }
        public Person()
        {
            Persons = new List<string>();
        }
    }
}
