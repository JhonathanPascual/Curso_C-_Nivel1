using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y 
            //luego mostrar por pantalla el menor de ellos.

            int n1,n2,n3,n4, min;

            Console.Write("Ingrese el primer valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer valor: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto valor: ");
            n4 = int.Parse(Console.ReadLine());

            if(n1 < n2)
                min = n1;
            else
                min = n2;
            if(n3 < min)
                min = n3;
            if(n4 < min)
                min = n4;

            Console.WriteLine(min +" es el menor");


           /* if(n1 < n2){
                if(n1 < n3){
                    if(n1 < n4){
                        Console.Write(n1 +" es el menor");
                    }else{
                        Console.Write(n4 +" es el menor");
                    }
                }else{
                    if(n3 < n4){
                        Console.Write(n3 +" es el menor");
                    }else{
                        Console.Write(n4 +" es el menor");
                    }
                }
            }else{
                if(n2 < n3){
                    if(n2 < n4){
                        Console.Write(n2 +" es el menor");
                    }else{
                        Console.Write(n4 +" es el menor");
                    }
                }else{
                    if(n3 < n4){
                        Console.Write(n3 +" es el menor");
                    }else{
                        Console.Write(n4 +" es el menor");
                    }
                }
            }*/
        }
    }
}
