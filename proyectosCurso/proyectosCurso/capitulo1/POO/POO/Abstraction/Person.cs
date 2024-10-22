using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Abstraction
{
    internal class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public override string ToString() =>
            $"Person [{Name}, {Email}, {Address}]";
    }
}
