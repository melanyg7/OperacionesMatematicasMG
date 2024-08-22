using System;

class Operaciones
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("//Bienvenido al sistema de Calculadora LISETH//");
            Console.WriteLine("");
            Console.WriteLine("//Estas son Las del Sistema");
            Console.WriteLine("1. dividir");
            Console.WriteLine("2. multiplicar");
            Console.WriteLine("3. sumar");
            Console.WriteLine("4. restar");
            Console.WriteLine("5. salir");


            Console.Write("Selecciona una operación : ");
            string opcion = Console.ReadLine();

            if (opcion == "5")
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }

            Console.Write("Ingresa un numero: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Error: Por favor ingresa un numero válido.");
                continue;
            }

            Console.Write("Ingresa el segundo numero: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Error: Por favor ingresa un número valido");
                continue;
            }

            double resultado = 0;
            bool operacionValida = true;

            if (opcion == "1")
            {
                resultado = num1 + num2;
            }
            else if (opcion == "2")
            {
                resultado = num1 - num2;
            }
            else if (opcion == "3")
            {
                resultado = num1 * num2;
            }
            else if (opcion == "4")
            {
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: División por cero no permitida");
                    operacionValida = false;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida, intenta de nuevo");
                operacionValida = false;
            }

            if (operacionValida)
            {
                Console.WriteLine($"Resultado: {resultado}");
            }

        }
    }
}