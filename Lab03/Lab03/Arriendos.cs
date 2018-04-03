using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab03
{
    class Arriendos
    {
        DateTime horaF;
        DateTime horaI;
        int PrecioTotal;
        
        public Arriendos(DateTime horaF ,DateTime horaI, int PrecioTotal, Cliente c , Vehiculos v , Accesorios a , Sucursales s )
        {
            this.horaF = horaF;
            this.horaI = horaI;
            this.PrecioTotal = PrecioTotal;
          

        }

        
    }
}
