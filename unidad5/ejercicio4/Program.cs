using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio 
            //si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente 
            //por 1 y por sí mismo.

            int n, cont = 0;

            Console.Write("Ingrese un numero: ");
            n =int.Parse(Console.ReadLine());

            for (int x = 1; x <= n; x++)
            {
                if(n % x == 0)
                    cont++;
            }

            if(cont == 2)
                Console.WriteLine("El numero " + n + " es un numero primo");
            else
                Console.WriteLine("El numero " + n + " NO es un numero primo");    


        }
    }
}
