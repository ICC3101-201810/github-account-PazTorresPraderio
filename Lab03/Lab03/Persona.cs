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
        public Persona(string Nombre, bool permiso) : base(Nombre)
        {
            
            this.permiso = permiso;
        }
    }
}
