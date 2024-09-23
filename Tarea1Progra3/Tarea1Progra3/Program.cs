using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Progra3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            List<Estudiante> estudiantes = new List<Estudiante>();

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine($"Ingresar datos del estudiante {i + 1}: ");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Promedio: ");
                double promedio = double.Parse(Console.ReadLine());

                estudiantes.Add(new Estudiante(nombre, edad, promedio));
            }

            int j = 0;
            while (j < estudiantes.Count)
            {
                Estudiante estudiante = estudiantes[j];
                if (estudiante.Promedio >= 70)
                {
                    estudiante.MostrarInfo();
                    Console.WriteLine(estudiante.EsMayorDeEdad() ? "Mayor de edad" : "Menor de edad");

                }
                j++;
            }
        }
    }
}
