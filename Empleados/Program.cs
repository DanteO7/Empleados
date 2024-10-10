namespace Empleados.Modelos
{
    public class Program
    {
        static void Main()
        {
            SysEmpleados.CargarDatos();

            int opcion;

            do
            {
                Console.WriteLine("======== Menú =========");
                Console.WriteLine("1. Agregar Empleado");
                Console.WriteLine("2. Eliminar Empleado");
                Console.WriteLine("3. Modificar Empleado");
                Console.WriteLine("4. Mostrar Empleado");
                Console.WriteLine("5. Salir\n");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        SysEmpleados.AgregarEmpleado();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        SysEmpleados.EliminarEmpleado();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        SysEmpleados.ActualizarEmpleado();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        SysEmpleados.MostrarEmpleados();
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion válida");
                        break;
                }

            } while (opcion != 5);
        }
    }
}