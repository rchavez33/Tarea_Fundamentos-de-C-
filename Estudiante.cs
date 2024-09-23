using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_C_
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        private int Edad;
        public double Promedio { get; set; }

        //verificar si el estudiante es mayor de edad
        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }

        // Método para mostrar la información del estudiante
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Promedio: {Promedio}");
        }

        // asignar la edad (ya que Edad es privada)
        public void SetEdad(int edad)
        {
            Edad = edad;
        }
    }
}

