using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas 
            //mayores a 18 años.

            int edad, acu = 0, contador = 0;
            float promedio;

            for (int x = 0; x < 20; x++)
            {   
                Console.Write("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad > 18){
                    acu += edad;
                    contador++;
                }
         
            }

            promedio = acu / contador;
            Console.WriteLine("La edad promedio de personas mayores de 18 es: "+ promedio);

        }   
    }
}
