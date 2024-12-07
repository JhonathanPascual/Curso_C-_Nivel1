using System;

namespace calculaNomina
{
    class Program
    {
        static void Main(string[] args)
        {
            double sb, tf, st;
            sb = 15000;

            Console.Write("Ingrese el total facturado: ");
            tf = int.Parse(Console.ReadLine());

            st = (tf* 0.05) + sb;

            Console.WriteLine("El sueldo total es: "+ st);

        }
    }
}
