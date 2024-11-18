using System;

    class Program 
    {

        static void Main(string[] args)
        { 

            Console.WriteLine("Calculadora Basica");
            Console.WriteLine();


            double valor1, valor2, valor3, suma, resta, multiplica, divide;


            Console.Write("Introduzca el primer valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca el segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca el segundo valor: ");
            valor3 = Convert.ToDouble(Console.ReadLine());


            suma = valor1 + valor2 + valor3;
            resta = valor1 - valor2 - valor3;
            multiplica = valor1 * valor2 * valor3;
            divide = valor1 / valor2 / valor3;

 
            Console.WriteLine("El resultado de la suma es {0}", suma);
            Console.WriteLine("El resultado de la resta es " + resta);
            Console.WriteLine($"El resultado de la multiplicación es {multiplica} ");
            Console.WriteLine("El resultado de la division es " + divide.ToString());


        }
    }

