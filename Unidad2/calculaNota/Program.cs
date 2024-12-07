using System;

namespace calculaNota
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1,n2,n3,r;
            //double r;

            Console.Write("Ingrese la Primera nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la tersera nota: ");
            n3 = float.Parse(Console.ReadLine());
           // Console.WriteLine(" / 3");

            r = (n1+n2+n3) / 3;
            Console.Write("El promedio de las calificaciones es: "+ r.ToString("0.0"));
        }
    }
}
