using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla 
           //cuántos de esos números son primos.

           int n, acuPrimos = 0, acuDivisible = 0;

           for (int x = 0; x < 10; x++)
           {
                Console.Write("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                
                acuDivisible = 0;
                for (int y = 1; y <= n; y++)
                {
                    if(n%y == 0)
                        acuDivisible++;
                        
                }
                
                if(acuDivisible == 2)
                    acuPrimos++;
           }

           Console.WriteLine("De los 10 datos ingresados "+ acuPrimos + " son primos");
        }
    }
}
