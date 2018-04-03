using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Compañia
    {
        string Nombre;
        List<Sucursales> sucursal;
        public Compañia(string Nombre, List<Sucursales>sucursal)
        {
            this.Nombre = Nombre;
            this.sucursal = new List<Sucursales>();
        }

    }
}
