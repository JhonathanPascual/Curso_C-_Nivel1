using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí 
            //por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos 
            //números tiene cada lista.

            int n;

            Console.Write("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while(n >= 0){
               int contNum = 0;

                while(n > 0){
                    contNum++;
                    Console.Write("Ingrese un numero: ");
                    n = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Esta lista tiene "+ contNum + " numeros");
                Console.Write("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            }


        }
    }
}
