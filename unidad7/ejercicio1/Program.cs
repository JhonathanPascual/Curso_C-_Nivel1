using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro
            //del vector.

            int[] numeros = new int [10];
            int n, mayor = 0, posision = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.Write("ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                numeros[x] = n;
            }

            for (int x = 0; x < 10; x++)
            {
                if(x == 0){
                    mayor = numeros[x];
                    posision = x +1;
                }else if( numeros[x] > mayor){
                    mayor = numeros[x];
                    posision = x +1;
                }
            }
            
            Console.WriteLine("El mayor es: "+ mayor + " y su posision es: " +posision);

        }
    }
}
