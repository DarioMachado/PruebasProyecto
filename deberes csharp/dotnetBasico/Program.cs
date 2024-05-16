using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Del 1 al 20, ¿cuántos números de la secuencia de Fibonacci te gustaría saber?");

        int cantidad = Convert.ToInt32(Console.ReadLine());

        if (cantidad <= 0 || cantidad > 20) {
            Console.WriteLine("Ese número no está entre 1 y 20...");
            return;
        }

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }


    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}