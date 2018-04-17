using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Persona : Cliente
    {
        bool permiso;
        int rut;
        public Persona(string Nombre, bool permiso , int rut) : base(Nombre)
        {
            
            this.permiso = permiso;
            this.rut = rut;

        }
    }
}
