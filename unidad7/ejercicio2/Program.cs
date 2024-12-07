using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla 
            //los valores que son mayores al promedio.

            int[] numeros = new int [10];
            int n, acu = 0;
            float promedio;

            for (int x = 0; x < 10; x++)
            {
                 Console.Write("Ingrese un numero: ");
                 n = int.Parse(Console.ReadLine());
                 numeros[x] = n;
            }

            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }

            promedio = acu/10f;

            Console.WriteLine("Los siguientes valores son mayores al promedio:");

            for (int x = 0; x < 10; x++)
            {
                if(numeros[x] > promedio)
                    Console.WriteLine(numeros[x]);
            }
        }
    }
}
