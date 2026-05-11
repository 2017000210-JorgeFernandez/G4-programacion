using System;

class Program
{
    static void Main()
    {
        double peso, total;

        total = 0;

        Console.WriteLine("Nombre: Jorge Fernandez");

        while (total < 1)
        {
            Console.WriteLine("Ingrese el peso de la manzana en kilos:");
            peso = double.Parse(Console.ReadLine());

            total = total + peso;

            Console.WriteLine("Peso acumulado: " + total + " kilos");
        }

        Console.WriteLine("Ya tienes 1 kilo o mas de manzanas");
    }
}