using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Cliente
    {
        string Nombre;
        
        
        public Cliente (string Nombre)
        {
            this.Nombre = Nombre;
           

        }
        public string GetName()
        {
            return this.Nombre;
        }
      

    }
}
