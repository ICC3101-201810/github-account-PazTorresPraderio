using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class RegistroClientes
    {
        List<Persona> p;
        List<Sucursales> ss;
        public RegistroClientes(List<Persona> p, List<Sucursales> ss)
        {
            this.p = new List<Persona>();
            this.ss = new List<Sucursales>();
        }
        public void Agregar(Persona pp)
        {
            p.Add(pp);
        }
        public void AS(Sucursales su)
        {
            ss.Add(su);
        }
        public void Recorrer()
        {
            foreach (Sucursales SU in ss)
            {
                Console.WriteLine(SU.DarDireccion());
            }
        }
    }
}
