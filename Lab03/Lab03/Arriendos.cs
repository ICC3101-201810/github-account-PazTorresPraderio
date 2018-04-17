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
        
        int PrecioTotal;
        string tipodeAuto;
        string NombreCliente;
        string dir;

        public Arriendos( int PrecioTotal,  string tipodeAuto , string NombreCliente,string dir )
        {
          
            this.PrecioTotal = PrecioTotal;
            this.tipodeAuto = tipodeAuto;
            this.NombreCliente = NombreCliente;
            this.dir = dir;

          

        }
        public void Dardatos()
        {
            Console.WriteLine("Este auto" + Environment.NewLine + this.tipodeAuto + Environment.NewLine + this.dir + Environment.NewLine+ this.PrecioTotal);
        }

        
    }
}
