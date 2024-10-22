using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    public interface IFuncion
    {
        void Insertar();
        void Saludar(string mensaje);

    }

    public class Impl1 : IFuncion
    {
        public void Insertar()
        {
            Console.WriteLine("implementación 1");
        }

        public void Insertar(int dato) { 
        
        }

        public void Saludar(string mensaje)
        {
            Console.WriteLine("implementación 1");
        }
    }

}
