using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LS
{
   
    public interface IVolar {
        void Volar();
    }

    public interface ICorrer {
        void Correr();
    }

    public interface INadar {
        void Nadar();
    }

    

    public class Pinguino : ICorrer, INadar
    {
        public void Correr()
        {
            Console.WriteLine("corre chistoso!!!");
        }

        public void Nadar()
        {
            Console.WriteLine("si nada muy rapido!!!");
        }


    }

    public class Paloma : IVolar, ICorrer
    {
        public void Correr()
        {
            Console.WriteLine("si corre");
        }

        public void Volar()
        {
            Console.WriteLine(" si vuela");
        }
    }



    public class Eagle : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("si vuela!!!");
        }
    }



    public class AdminAve
    {
        private List<IVolar> voladores = new List<IVolar>();

        public bool InsertVolador(IVolar ave) {
                voladores.Add(ave);
                return true;
        }
        

    }
}
