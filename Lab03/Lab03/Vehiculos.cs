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
        public Vehiculos(string patente)

        {
            this.patente = patente;
        }
        public string GetPatente()
        {
            return this.patente;
        }
           
        
    }
}
