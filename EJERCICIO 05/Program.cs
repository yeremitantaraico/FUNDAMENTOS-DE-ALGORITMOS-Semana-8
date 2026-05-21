using System;

class Program
{
    static void Main(string[] args)
    {
        // LEER nota
        Console.Write("Ingrese la nota del estudiante: ");
        double nota = double.Parse(Console.ReadLine());

        // SI EsNotaValida(nota) ENTONCES
        if (EsNotaValida(nota))
        {
            string clasificacion = ClasificarNota(nota);
            MostrarReporte(nota, clasificacion);
        }
        // SINO
        else
        {
            Console.WriteLine("Error: la nota debe estar entre 0 y 20.");
        }
    }

    // FUNCION EsNotaValida(nota) -> Retorna bool (true/false)
    static bool EsNotaValida(double nota)
    {
        return nota >= 0 && nota <= 20;
    }

    // FUNCION ClasificarNota(nota) -> Retorna string
    static string ClasificarNota(double nota)
    {
        if (nota >= 18)
        {
            return "Excelente";
        }
        else if (nota >= 14)
        {
            return "Bueno";
        }
        else if (nota >= 11)
        {
            return "Regular";
        }
        else
        {
            return "Desaprobado";
        }
    }

    // PROCEDIMIENTO MostrarReporte(nota, clasificacion) -> Función void
    static void MostrarReporte(double nota, string clasificacion)
    {
        Console.WriteLine($"Nota ingresada: {nota:F2}");
        Console.WriteLine($"Clasificación: {clasificacion}");
    }
}