using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.IS
{
    public interface ICommons {
        void EntrarAReuniones();
        void Registro();

    }

    public interface IDevelop {
        void Desarrolla();
        void EjecutaTest();

    }

    public interface IGenerente {
        void Gerenciar();
    }

    public interface IFinanza {
        void AdministrarFacturas();
    }

    public class Developer : ICommons, IDevelop
    {
        public void Desarrolla()
        {
            throw new Exception("");
        }

        public void EjecutaTest()
        {
            throw new NotImplementedException();
        }

        public void EntrarAReuniones()
        {
            throw new NotImplementedException();
        }

        public void Registro()
        {
            throw new NotImplementedException();
        }
    }

    public class Venta : ICommons
    {
        public void EntrarAReuniones()
        {
            throw new NotImplementedException();
        }

        public void Registro()
        {
            throw new NotImplementedException();
        }
    }



    public class Empresa
    {

    }
}
