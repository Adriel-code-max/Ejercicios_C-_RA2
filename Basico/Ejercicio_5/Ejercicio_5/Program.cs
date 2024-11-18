using System;

class Program
{
    static void Main(string[] args)
    {
        
        int cantidad;
        double precio;
        double importe;

       
        Console.Write("Ingrese la cantidad del artículo: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

       
        Console.Write("Ingrese el precio del artículo: ");
        precio = Convert.ToDouble(Console.ReadLine());

        
        importe = cantidad * precio;

       
        Console.WriteLine("El importe del artículo es: " + importe);
        Console.ReadLine();
    }
}
