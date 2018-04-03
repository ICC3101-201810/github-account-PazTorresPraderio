using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Bienvenido");
            Console.WriteLine("1.Sucursal" + Environment.NewLine  + "2.Cliente");
            string op;
            string dir;
            op = Convert.ToString(Console.ReadLine());
            if (op == "1")
            {
                int i = 0;
                while (i == 0)
                {
                    Console.WriteLine("Ingrese Direccion del local");
                    dir = Console.ReadLine();
                    Sucursales s = new Sucursales(dir, null, null);
                    s.DarBievenida();
                    Console.ReadLine();
                    Console.WriteLine("1.AgregarVehiculo" + Environment.NewLine + "2.AgregarAccesorio" + Environment.NewLine + "3. Salir");
                    string op1;
                    op1 = Convert.ToString(Console.ReadLine());
                    if (op1 == "1")
                    {

                        String patente;
                        Console.WriteLine("Ingrese patente");
                        patente = Console.ReadLine();
                        Vehiculos v = new Vehiculos(patente);
                        Console.WriteLine("Que tipo de Vehiculo es" + Environment.NewLine + "1.Auto" + Environment.NewLine + "2.MotoAcutica");
                        string op3;
                        op3 = Convert.ToString(Console.ReadLine());
                        if (op3 == "1")
                        {
                            s.AgregarVehiculo(vehiculo: new Auto(patente));
                        }
                        else  if (op3 == "2")
                        {
                            s.AgregarVehiculo(vehiculo :new MotoAcuatica(patente));
                        }
                     
                        


                        
                    }
                    else if (op1 == "2")
                    {
                        string nombre;
                        int precio;
                        Console.WriteLine("Ingrese Nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Precio");
                        precio = Convert.ToInt32(Console.ReadLine());
                        Accesorios a = new Accesorios(nombre, precio);
                        s.AgregarAC(a);


                    }


                }
            } 
            else if (op == "2")
            {
                Console.WriteLine("Ingrese Nombre");
                string name;
                name = Console.ReadLine();
                Cliente c = new Cliente(name);

            }
                
        }
    }
}
