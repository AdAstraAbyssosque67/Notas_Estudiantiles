using System;

namespace FlujodeControl_2
{
    class Estudiante
    {
        public string ?Nombre { get; set; }
        public double[] Notas { get; set; } = new double[4];
        public double Promedio { get; set; }
        public string ?Estatus { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la Cantidad de Estudiantes: ");
            if (!int.TryParse(Console.ReadLine(), out int Clase)) return;

            Estudiante[] alumnos = new Estudiante[Clase];

            for (int i = 0; i < Clase; i++)
            {
                alumnos[i] = new Estudiante();
                Console.WriteLine($"\n--- Datos del Estudiante {i + 1} ---");
                Console.Write("Nombre: ");
                alumnos[i].Nombre = Console.ReadLine();

                double sumaNotas = 0;
                for (int a = 0; a < 4; a++)
                {
                    Console.Write($"Ingrese la Nota {a + 1}: ");
                    alumnos[i].Notas[a] = double.Parse(Console.ReadLine()!);
                    sumaNotas += alumnos[i].Notas[a];
                }

                alumnos[i].Promedio = sumaNotas / 4;
                alumnos[i].Estatus = alumnos[i].Promedio >= 70 ? "Aprobado" : "Reprobado";
            }

            ImprimirDatos(alumnos);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        public static void ImprimirDatos(Estudiante[] lista)
        {
            Console.WriteLine("\nEstudiante\t\tNota 1\tNota 2\tNota 3\tNota 4\tpromedio\tEstatus");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            foreach (Estudiante est in lista)
            {
                Console.WriteLine($"{est.Nombre,-20}\t{est.Notas[0]}\t{est.Notas[1]}\t{est.Notas[2]}\t{est.Notas[3]}\t{est.Promedio:F2}\t\t{est.Estatus}");
            }
        }
    }
}