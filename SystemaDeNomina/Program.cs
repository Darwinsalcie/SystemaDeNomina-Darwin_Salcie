using System;
using System.Xml;
using SystemaDeNomina;


bool exit = false;


List<Empleado> empleados = new List<Empleado>();


//Bucle para ingresa los empleados

while (exit == false) {


    Console.WriteLine("\n\nSistema de Nómina utilizando polimorfismo ");
    Console.WriteLine("Favor ingrese el tipo de empleado que desea ingresar:\n\tEmpleado Asalariado \t\t\t(1)\n\tEmpleado Por Comisión\t\t\t(2) \n\tEmplaedo por horas\t\t\t(3)\n\tEmpleado con sueldo base + Comisión\t(4)\n\tPara imprimir y salir del programa\t(0)");

    string input = Console.ReadLine();

    if (int.TryParse(input, out int val)) //validación de la entrada
    {
        switch (val)

        {

            case 1:
                EmpleadoAsalariado empleadosalariado = new();
                empleadosalariado.getDatos();
                empleados.Add(empleadosalariado);
                break;


            case 2:
                EmpleadoPorComision empleadoPorComision = new EmpleadoPorComision();
                empleadoPorComision.getDatos();
                empleados.Add(empleadoPorComision);
                break;

            case 3:
                EmpleadoPorHoras empleadoPorHoras = new EmpleadoPorHoras();
                empleadoPorHoras.getDatos();
                empleados.Add(empleadoPorHoras);
                break;

            case 4:
                EmpleadoBaseMasComision empleadoBaseMasComision = new EmpleadoBaseMasComision();
                empleadoBaseMasComision.getDatos();
                empleados.Add(empleadoBaseMasComision);
                break;

            case 0:
                exit = true;
                break;

            default:
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                break;

        }
    }


    else
    {
        Console.WriteLine("\nEntrada inválida. Intente nuevamente");
    }

}


Console.Clear();  //limpiar la pantalla

//Imprimir los empleados

foreach (Empleado empleado in empleados)
{
    Console.WriteLine($"{empleado.ToString()}\nIngreso: {empleado.CalcularIngreso():C}");
    Console.WriteLine();
}


Console.WriteLine("Presiona cualquier tecla para terminar..");
Console.ReadKey(); // Espera a que el usuario presione una tecla




