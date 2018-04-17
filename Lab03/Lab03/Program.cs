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
            Auto a = new Auto("KJHJ55", 50000, "Auto");
            MotoAcuatica ma = new MotoAcuatica("LKJS11", 180000, "MotoAcuatica" );
            Accesorios aa = new Accesorios("WIFI", 35000);
            Sucursales s1 = new Sucursales("Grecia 34", "PE01", null, null);
            s1.AgregarVehiculo(a);
            s1.AgregarVehiculo(ma);
            s1.AgregarAC(aa);

            RegistroClientes RC = new RegistroClientes(null, null);
            RC.AS(s1);
            Console.WriteLine("Hola Bienvenido");
            Console.WriteLine("1.Sucursal" + Environment.NewLine  + "2.Arrendar");
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
                    Console.WriteLine("Ingrese CodigoVerificador");
                     string cv = Console.ReadLine();
                    Sucursales s = new Sucursales(dir,cv ,null, null);
                    s.DarBievenida();
                    RC.AS(s);
                    Console.ReadLine();
                    Console.WriteLine("1.AgregarVehiculo" + Environment.NewLine + "2.AgregarAccesorio" + Environment.NewLine + "3. Salir");
                    string op1;
                    op1 = Convert.ToString(Console.ReadLine());
                    if (op1 == "1")
                    {

                        int precio;
                        String patente;
                        Console.WriteLine("Ingrese patente");
                        patente = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio del auto");
                        precio = Convert.ToInt32(Console.ReadLine());
                       
                        Console.WriteLine("Que tipo de Vehiculo es" + Environment.NewLine + "1.Auto" + Environment.NewLine + "2.MotoAcutica");
                        string op3;
                        op3 = Convert.ToString(Console.ReadLine());
                        if (op3 == "1")
                        {
                            Vehiculos v = new Vehiculos(patente, precio,"Auto");
                            s.AgregarVehiculo(vehiculo: new Auto(patente, precio,"Auto"));
                        }
                        else  if (op3 == "2")
                        {
                            Vehiculos v = new Vehiculos(patente, precio, "Moto Acuatica");
                            s.AgregarVehiculo(vehiculo :new MotoAcuatica(patente, precio, "Moto Acuatica"));
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
                        Accesorios ab = new Accesorios(nombre, precio);
                        s.AgregarAC(ab);


                    }


                }
            } 
            else if (op == "2")
            {
                Console.WriteLine("1.Nuevo Cliente" + Environment.NewLine + "2.Login");
                string opp;
                opp = Convert.ToString(Console.ReadLine());
                if (opp == "1")
                {
                    Console.WriteLine("Ingrese Nombre");
                    string name;
                    name = Console.ReadLine();
                    Console.WriteLine("Ingrese Rut");
                    int rut;
                    rut = Convert.ToInt32(Console.ReadLine());
                    bool permiso;
                    Console.WriteLine("Tiene persimo de conducir 1. Si 2.No");
                    string opp1;
                    opp1 = Convert.ToString(Console.ReadLine());
                    if (opp1 == "1")
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        permiso = true;
                        RC.Recorrer();
                        Console.ReadKey();
                        Console.WriteLine("Que direccion Desea");
                        string namedir;
                        namedir = Console.ReadLine();
                        s1.Recorrervehiculos();
                        Console.ReadKey();
                        Console.WriteLine("Que vehiculo desea");
                        string e;
                        e = Console.ReadLine();
                        if (e == "Auto")
                        {
                            a.GetPrecio();
                            int total = a.GetPrecio();
                            Arriendos arriendo = new Arriendos(total, "Auto", name, namedir);
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            arriendo.Dardatos();
                            Console.Beep();
                            Console.ReadLine();
                        }








                    }


                }
                

                


            }
            

                
        }
    }
}
