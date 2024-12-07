using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero 
            //si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int n, contPar = 0;
            
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if(par(n) == 1)
                    contPar++;
            }

            Console.WriteLine("la cantidad de pares es: "+ contPar);
        }

        static int par(int a){

            int r;
            if(a % 2 == 0)
                r = 1;
            else
                r = 0;

            return r;
        }
    }
}
