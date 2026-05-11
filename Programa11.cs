using System;

class Program
{
    static void Main()
    {
        int cajones;

        cajones = 200;

        Console.WriteLine("Nombre: Jorge Fernandez");

        do
        {
            Console.WriteLine("Cajones disponibles: " + cajones);

            cajones--;
        }
        while (cajones > 0);

        Console.WriteLine("Ya no hay cajones libres");
    }
}