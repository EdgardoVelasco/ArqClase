using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Encapsulation
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Client { protected get; set; }

        public string Email { get; set; }

        protected string Information() {
            return $"{Client} {Number}";
        }

    }
}
