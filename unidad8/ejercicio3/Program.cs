using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo 
            //o cero si no lo es. Hacer un programa para ingresar números. 
            //El lote corta cuando se ingresa un número cero. 
            //Informar el promedio teniendo en cuenta sólo los números primos.

            int n, acu = 0, cont = 0, promedio;

            Console.Write("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while( n != 0){

                if(primo(n) == 1){
                    acu += n;
                    cont++;
                }

                Console.Write("Ingrese otro: ");
                n = int.Parse(Console.ReadLine());


            }


            promedio = acu / cont;

            Console.WriteLine("El promedio de los numeros primos es: "+ promedio);

        }

        static int primo(int a){
            int banPrimo = 0,cont = 0;

            for (int x = 1; x <= a; x++)
            {
                if(a % x == 0)
                    cont++;
                                
            }

                if(cont == 2)
                    banPrimo = 1;
                else
                    banPrimo = 0;


            return banPrimo;
        }

    }
}
