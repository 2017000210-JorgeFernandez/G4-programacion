using System;

class Program
{
    static void Main()
    {
        int num1, num2, menor, mayor, i;

        Console.WriteLine("Nombre: Jorge Fernandez");

        Console.WriteLine("Ingrese el primer numero:");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        num2 = int.Parse(Console.ReadLine());

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else
        {
            menor = num2;
            mayor = num1;
        }

        for (i = menor; i <= mayor; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}