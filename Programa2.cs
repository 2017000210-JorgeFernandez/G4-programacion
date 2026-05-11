using System;

class Program
{
    static void Main()
    {
        int monedas, ganadas;

        monedas = 0;

        Console.WriteLine("Nombre: Jorge Fernandez");

        while (monedas < 350)
        {
            Console.WriteLine("Ingrese las monedas ganadas:");
            ganadas = int.Parse(Console.ReadLine());

            monedas = monedas + ganadas;

            Console.WriteLine("Monedas acumuladas: " + monedas);
        }

        Console.WriteLine("Nivel 5 desbloqueado");
    }
}