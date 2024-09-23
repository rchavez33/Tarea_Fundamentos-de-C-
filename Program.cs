using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_C_
{
    internal class Program
    {
        static void Main()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            Console.Write("Ingrese la cantidad de estudiantes a registrar: ");
            int cantidad = int.Parse(Console.ReadLine());

            // Ciclo for para ingresar los datos de cada estudiante
            for (int i = 0; i < cantidad; i++)
            {
                Estudiante estudiante = new Estudiante();

                Console.Write("Ingrese el nombre del estudiante: ");
                estudiante.Nombre = Console.ReadLine();

                Console.Write("Ingrese la edad del estudiante: ");
                estudiante.SetEdad(int.Parse(Console.ReadLine()));

                Console.Write("Ingrese el promedio del estudiante: ");
                estudiante.Promedio = double.Parse(Console.ReadLine());

                estudiantes.Add(estudiante);
            }

            // Ciclo while para mostrar la información de estudiantes con promedio mayor o igual a 70
            Console.WriteLine("Estudiantes con promedio mayor o igual a 70:");
            int index = 0;
            while (index < estudiantes.Count)
            {
                if (estudiantes[index].Promedio >= 70)
                {
                    estudiantes[index].MostrarInfo();

                    // Verificación si el estudiante es mayor de edad
                    if (estudiantes[index].EsMayorDeEdad())
                    {
                        Console.WriteLine($"{estudiantes[index].Nombre} es mayor de edad.");
                    }
                    else
                    {
                        Console.WriteLine($"{estudiantes[index].Nombre} no es mayor de edad.");
                    }
                }
                index++;
            }
        }
    }
}

