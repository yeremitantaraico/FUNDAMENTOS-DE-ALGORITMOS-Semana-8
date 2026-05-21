using System;

class Program
{
    static void Main(string[] args)
    {
        // INICIO
        // LEER m3
        Console.Write("Ingrese el consumo de agua en m³: ");
        double m3 = double.Parse(Console.ReadLine());

        // costo = calcularCostoAgua(m3)
        double costo = CalcularCostoAgua(m3);

        // mostrarRecibo(m3, costo)
        MostrarRecibo(m3, costo);
        // FIN
    }

    // FUNCION calcularCostoAgua(m3)
    static double CalcularCostoAgua(double m3)
    {
        double costo;

        // SI m3 <= 20 ENTONCES
        if (m3 <= 20)
        {
            costo = m3 * 1.80;
        }
        // SINO
        else
        {
            costo = (20 * 1.80) + ((m3 - 20) * 2.50);
        }

        // RETORNAR costo
        return costo;
    }

    // PROCEDIMIENTO mostrarRecibo(m3, costo)
    static void MostrarRecibo(double m3, double costo)
    {
        // MOSTRAR "Consumo: ", m3, " m3"
        Console.WriteLine($"Consumo: {m3} m³");
        // MOSTRAR "Costo total: S/", costo
        Console.WriteLine($"Costo total: S/{costo:F2}");
    }
}