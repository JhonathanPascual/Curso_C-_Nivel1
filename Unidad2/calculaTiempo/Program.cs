using System;

namespace calculaTiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            float v,d,t;

            Console.Write("Ingrese la velocidad: ");
            v = float.Parse(Console.ReadLine());
            
             Console.Write("Ingrese la distacia: ");
             d = float.Parse(Console.ReadLine());

             t = d/v;

              Console.Write("El tiempo estimado es: "+ t.ToString("0.00") + "h");
           
        }
    }
}
