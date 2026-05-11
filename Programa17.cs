using System;

class Program
{
    static void Main()
    {
        int billete, i;
        int cantidad100 = 0;
        int total = 0;

        Console.WriteLine("Nombre: Jorge Fernandez");

        for (i = 1; i <= 1000; i++)
        {
            Console.WriteLine("Ingrese el valor del billete:");
            billete = int.Parse(Console.ReadLine());

            total = total + billete;

            if (billete == 100)
            {
                cantidad100++;
            }
        }

        Console.WriteLine("Cantidad de billetes de 100: " + cantidad100);
        Console.WriteLine("Dinero total: $" + total);
    }
}