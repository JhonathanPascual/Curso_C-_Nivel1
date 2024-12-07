using System;

namespace CuboDeUnNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,r;

            Console.Write("Inserte un numero: ");
            n = int.Parse(Console.ReadLine());
            r = n * n * n;

            Console.WriteLine("El Resultado es: "+ r); 
        }
    }
}
