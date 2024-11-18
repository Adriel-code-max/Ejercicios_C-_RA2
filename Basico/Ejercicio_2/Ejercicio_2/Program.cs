using System;

class Program
{
    static void Main(string[] args)
    {
        string Nombre = "";
        int tiempo;
        double sueldo;
        double descuentoAFP;
        double descuentoSFS;
        double totalDescuento;
        double sueldoFinal;

        Console.WriteLine("Nombre:");
        Nombre = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Sueldo:");
        sueldo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Tiempo:");
        tiempo = Convert.ToInt32(Console.ReadLine());

        double totalSueldo = sueldo * tiempo;

        descuentoAFP = totalSueldo * 0.0287;
        descuentoSFS = totalSueldo * 0.0304;
        totalDescuento = descuentoAFP + descuentoSFS;

        sueldoFinal = totalSueldo - totalDescuento;

        Console.WriteLine($"Sueldo final del empleado {Nombre} es de {sueldoFinal}");
        Console.ReadLine();
    }
}
  