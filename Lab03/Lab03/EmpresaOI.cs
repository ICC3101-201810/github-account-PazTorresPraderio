using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class EmpresaOI : Cliente
    {
        bool autorizacion;
        public EmpresaOI(string Nombre, bool autorizacion) : base(Nombre)
        {
            this.autorizacion = autorizacion;
        }
    }
}
