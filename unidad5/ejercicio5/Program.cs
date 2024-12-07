using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números 
            //pares y el mínimo de los números impares.

            int n, max = 0, min = 0, bPar = 0, bImp = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.Write("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if(n%2 == 0){
                    if(bPar == 0){
                        max = n;
                        bPar++;
                    }else{
                        if(n > max)
                            max = n;
                    }
                }else{
                    if(bImp == 0){
                        min = n;
                        bImp++;
                    }else{
                        if(n < min)
                        min = n;
                    }

                }
            }

            Console.WriteLine("El mayor de los pares es: "+ max +" y el menor de los impares es: "+ min);
        }
    }
}
