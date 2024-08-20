using System;


class OperacionesMatematica4

{
    private static int num2;
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Operaciones Matematicas ");
            Console.WriteLine("1 sumar");
            Console.WriteLine("2 restar");
            Console.WriteLine("3 multiplicar");
            Console.WriteLine("4 dividir");
            Console.WriteLine("5 salir..");

            Console.Write("Seleccione una operacion matematica 1,2,3,4,5: ");
            string opcion = Console.ReadLine();

            if (opcion == "5")
            {
                Console.WriteLine("Saliendo del programa de OM.....");
                break;
            }

            Console.Write("Ingrese el primer numero: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Error, favor ingrese un numero valido");
                continue;
            }

            Console.Write("Ingrese el segundo nemero: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Error, favor ingrese un numero valido");
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
                    Console.WriteLine("Error en la Division ");
                    operacionValida = false;
                }
            }
            else
            {
                Console.WriteLine("Opcion no ejecutada, intente mas tarde ");
                operacionValida = false;
            }

            if (operacionValida)
            {
                Console.WriteLine("Resultado:");
            }
        }
    }
}
