using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Vehiculos
    {
        string patente;
        int precio;
        string Nombre;
        public Vehiculos(string patente, int precio, string Nombre)

        {
            this.patente = patente;
            this.precio = precio;
            this.Nombre = Nombre;
        }
        public string GetPatente()
        {
            return this.patente;
        }
        public int GetPrecio()
        {
            return this.precio;
        }
        public string GetName()
        {
            return this.Nombre;
        }




    }
}
