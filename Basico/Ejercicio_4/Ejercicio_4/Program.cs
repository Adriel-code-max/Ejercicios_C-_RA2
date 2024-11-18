using System;

class Program
{
    static void Main(string[] args)
    {
        
        double num1, num2, num3, num4, num5;
        double suma;
        double promedio;

        
        Console.Write("Número 1: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Número 2: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Número 3: ");
        num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Número 4: ");
        num4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Número 5: ");
        num5 = Convert.ToDouble(Console.ReadLine());

       
        suma = num1 + num2 + num3 + num4 + num5;

        
        promedio = suma / 5;

        
        Console.WriteLine("El promedio es: " + promedio);
        Console.ReadLine();
    }
}