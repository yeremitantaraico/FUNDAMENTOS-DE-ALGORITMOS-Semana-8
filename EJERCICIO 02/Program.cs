using System;

class Program
{
    // Variable estática: representa una regla general del programa
    static double notaAprobatoria = 11;

    static void Main(string[] args)
    {
        Console.Write("Ingrese la nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la nota 3: ");
        double nota3 = double.Parse(Console.ReadLine());

        // Llamada a función con retorno
        double promedio = CalcularPromedio(nota1, nota2, nota3);

        // Llamada a función con retorno que clasifica usando la nota aprobatoria
        string estado = ClasificarEstudiante(promedio);

        // Llamada a función void: muestra información, no retorna valor
        MostrarReporte(promedio, estado);
    }

    // Función con retorno: calcula y devuelve el promedio
    static double CalcularPromedio(double n1, double n2, double n3)
    {
        double promedio = (n1 + n2 + n3) / 3;
        return promedio;
    }

    // Función con retorno: devuelve "Aprobado" o "Desaprobado"
    static string ClasificarEstudiante(double promedio)
    {
        if (promedio >= notaAprobatoria)
        {
            return "Aprobado";
        }
        else
        {
            return "Desaprobado";
        }
    }

    // Función void: solo imprime el reporte final
    static void MostrarReporte(double promedio, string estado)
    {
        Console.WriteLine("\n=== REPORTE DE NOTAS ===");
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Estado: {estado}");
    }
}