using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el 
            //producto de ambos. Luego hacer un programa que pida el precio de un artículo y 
            //la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

            int n1,n2, resultado;
            
            Console.Write("Ingrese el precio del articulo: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad vendida: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = producto(n1,n2);

            Console.WriteLine("el monto total a pagar es: " + resultado);


        }

        static int producto(int a, int b){
            int p;

            p = a * b;
            return p;
        }
    }
}
