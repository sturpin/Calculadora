using System;

namespace Calculadora
{
    class Program
    {

        static void Main(string[] args)
        {
            int valor1 = 0, valor2 = 0, resultado = 0, opcion = 0;
            string respuesta;


            do
            {

                do
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("¿Qué operación desea realizar?:\n");
                        Console.WriteLine("1. Sumar");
                        Console.WriteLine("2. Restar");
                        Console.WriteLine("3. Multiplicar");
                        Console.WriteLine("4. Dividir");
                        Console.Write("\nOpción: ");
                        opcion = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.FormatException ex) { }

                } while (opcion < 1 || opcion > 4);


                Console.WriteLine("\nIntroduzca los números\n");
                Console.Write("Valor1: ");
                valor1 = int.Parse(Console.ReadLine());
                Console.Write("Valor2: ");
                valor2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("-- SUMA --");
                        resultado = valor1 + valor2;
                        Console.WriteLine("{0} + {1} = {2}\n", valor1, valor2, resultado);
                        break;
                    case 2:
                        Console.WriteLine("-- RESTA --");
                        resultado = valor1 - valor2;
                        Console.WriteLine("{0} - {1} = {2}\n", valor1, valor2, resultado);
                        break;
                    case 3:
                        Console.WriteLine("-- MULTIPLICACION --");
                        resultado = valor1 * valor2;
                        Console.WriteLine("{0} * {1} = {2}\n", valor1, valor2, resultado);
                        break;
                    case 4:
                        Console.WriteLine("-- DIVISION --");
                        resultado = valor1 / valor2;
                        Console.WriteLine("{0} / {1} = {2}\n", valor1, valor2, resultado);
                        break;
                }

                Console.Write("Desea realizar otra operación (s/n): ");
                respuesta = Console.ReadLine();

            } while (respuesta == "s" || respuesta == "S");

            Console.WriteLine("Aplicación finalizada! :)");

        }
    }
}

