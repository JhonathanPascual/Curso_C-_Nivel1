using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de dos números y luego calcular:

            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.

            int n1,n2,r;

            Console.Write("Ingrese el primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                r = n1-n2;
            }else if(n1 == n2){
                r = n1 + n2;
            }else{
                r = n1 * n2;
            }

            Console.WriteLine("El resultado es: "+ r);
        }
    }
}
