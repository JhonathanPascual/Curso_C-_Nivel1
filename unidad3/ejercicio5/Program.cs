﻿using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles 
            //son mayores a 100.
            
            int n1,n2,n3,n4;

            Console.Write("Ingrese el primer valor: ");
            n1 = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer valor: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto valor: ");
            n4 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Los siguientes valores son mayores a 100");

            if(n1 > 100)
                Console.WriteLine(n1);

            if(n2 > 100)
                Console.WriteLine(n2);    
            
            if(n3 > 100)
                Console.WriteLine(n3);

            if(n4 > 100)
                Console.WriteLine(n4);
        }
    }
}
