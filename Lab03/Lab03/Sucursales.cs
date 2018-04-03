﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Sucursales
    {
        string direccion;
        List<Vehiculos> vehiculos;
        List<Accesorios> a;
    
        public Sucursales(string direccion, List<Vehiculos> vehiculos , List<Accesorios>a)
        {
            this.direccion = direccion;
            this.vehiculos = new List<Vehiculos>();
            this.a = new List<Accesorios>();
        }
        public void AgregarVehiculo (Vehiculos vehiculo)
        {
            vehiculos.Add(vehiculo);
        }
        public void AgregarAC(Accesorios aa)
        {
            a.Add(aa);
        }
        public void DarBievenida()
        {
            Console.WriteLine("Hola Sucursal De" + this.direccion);
        }
    }
}
