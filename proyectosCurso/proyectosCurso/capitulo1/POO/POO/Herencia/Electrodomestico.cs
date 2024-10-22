using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Herencia
{
    public abstract class Electrodomestico
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }

    }

    public class Lavadora:Electrodomestico {
        public Lavadora() : base() { }
    }
    

}
