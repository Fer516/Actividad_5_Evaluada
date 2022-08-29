using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitud de datos by Luisa

            int Id;
            String Código;
            String Nombre;
            int Edad;
            Console.WriteLine("Cuantos registros desea realizar:");
            int registros = int.Parse(Console.ReadLine());
            Estudiantes[] arregloestudiantes = new Estudiantes[registros];

            for (int i = 0; i < registros; i++)
            {
                Id = i + 1;
                Console.WriteLine("Ingrese los siguientes datos:");
                Console.WriteLine("Ingrese el Código:");
                Código = Console.ReadLine();
                Console.WriteLine("Ingrese el Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad:");
                Edad = int.Parse(Console.ReadLine());

                arregloestudiantes[i] = new Estudiantes(Id, Código, Nombre, Edad);
            }

            // consulta by Darlin y Eduardo
            int con = 1;
            while (con == 1)
            {
                int datoint, op;
                string dato;
                Console.WriteLine("Si desea hacer consulta de edad precione 1, Si desea consultar la edad precione 2 y se desea consultar el nombre precione 3.");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Digite el rango de edad: ");
                    datoint = int.Parse(Console.ReadLine());
                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Edad >= datoint
                                                                   select estudiante;
                    Console.WriteLine("El resultado de la consulta es: ");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());
                    }
                }

                else if (op == 2)
                {
                    Console.WriteLine("Digite el ID: ");
                    datoint = int.Parse(Console.ReadLine());

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Id == datoint
                                                                   select estudiante;
                    Console.WriteLine("El resultado de la consulta es:");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());
                    }
                }
                else if (op == 3)
                {
                    Console.WriteLine("Digite el rando de edad que desea: ");
                    dato = Console.ReadLine();

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Nombre == dato
                                                                   select estudiante;
                    Console.WriteLine("El resultado de la consulta es: ");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());
                    }
                }
                Console.WriteLine("Digite 1 si desea consultar nuevamente, si no precione cualquier tecla para salir.");
                con = int.Parse(Console.ReadLine());
            }
            Console.Read();
        }

    }

}
