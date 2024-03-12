using System;

class Program
{
    static void Main(string[] args)
    //ejercicio 1
    {
        int numero;
        int numeroMayor = int.MinValue;
        int numeroMenor = int.MaxValue;

        do
        {
            Console.Write("Ingrese un número positivo (0 para terminar): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                if (numero > numeroMayor)
                {
                    numeroMayor = numero;
                }

                if (numero < numeroMenor)
                {
                    numeroMenor = numero;
                }
            }
            else if (numero < 0)
            {
                Console.WriteLine("Por favor, ingrese un número positivo.");
            }

        } while (numero != 0);

        if (numeroMayor != int.MinValue)
        {
            Console.WriteLine("El número mayor ingresado es: " + numeroMayor);
        }
        else
        {
            Console.WriteLine("No se ingresaron números positivos.");
        }

        if (numeroMenor != int.MaxValue)
        {
            Console.WriteLine("El número menor ingresado es: " + numeroMenor);
        }
        else
        {
            Console.WriteLine("No se ingresaron números positivos.");
        }

        Console.WriteLine("---------------------------------------------------------------------");


    }
}



//ejercicio 2

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Piensa en un número y sigue las instrucciones.");


        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int paso2 = numero * 2;
        int paso3 = paso2 + 8;
        int paso4 = paso3 * 5;

        Console.WriteLine("resultado final (después de multiplicar por 5): ");
        int resultadoFinal = Convert.ToInt32(Console.ReadLine());

        string resultadoCadena = resultadoFinal.ToString();


        string resultadoAnulado = resultadoCadena.Substring(0, resultadoCadena.Length - 1);

        int paso7 = Convert.ToInt32(resultadoAnulado) - 4;


        Console.WriteLine("El número que pensaste es: " + paso7);

        Console.WriteLine("--------------------------------------------------------------------------------------");
    }
}

//ejercicio 3
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();

        bool esPalindromo = true;


        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - 1 - i])
            {
                esPalindromo = false;
                break;
            }
        }

        if (esPalindromo)
        {
            Console.WriteLine("La palabra ingresada es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra ingresada no es un palíndromo.");
        }
    }
}