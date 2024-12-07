using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla 
           //si los mismos se encuentran ordenados de forma decreciente .

           int n1,n2,n3,n4;

           Console.Write("Ingrese el primer numero: ");
           n1 = int.Parse(Console.ReadLine());

           Console.Write("Ingrese el segundo numero: ");
           n2 = int.Parse(Console.ReadLine());

           Console.Write("Ingrese el tercer numero: ");
           n3 = int.Parse(Console.ReadLine());

           Console.Write("Ingrese el cuarto numero: ");
           n4 = int.Parse(Console.ReadLine());

           if(n1 > n2 && n2 > n3 && n3 > n4)
                Console.WriteLine("Estan ordenados de mayor a menor");
            else
                Console.WriteLine("No estan ordenados de mayor a menor");

        }
    }
}
