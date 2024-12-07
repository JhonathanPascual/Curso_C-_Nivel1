using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
            //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan 
            //sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"


            char[] frase = new char[21];
            char p, q, letra;
            int posicion = 0;

            Console.WriteLine("Ingrese una frase, letra por letra y termine la frace con un punto: ");
            letra = char.Parse(Console.ReadLine());

            while(letra != '.' && posicion < 20){

                frase[posicion] = letra;
                posicion++;
                letra = char.Parse(Console.ReadLine());
            }

            frase[posicion] = '\0';

            // me quede tratando de mostrar el contenido del vector, a esta altura de juego ya yo 
            //capturo y lleno la cadena de caracteres, se me ocurrio que lo puedo mostrar con un ciclo while

            Console.WriteLine("has introducido la siguiente frase: ");

            posicion = 0;
            while(frase [posicion] != '\0'){
                Console.Write(frase[posicion]);
                posicion++;
            }
            
            Console.WriteLine(" ");

            Console.Write("Cual letra de la frase anterior desea sustituir?: ");
            p = char.Parse(Console.ReadLine());
            Console.Write("Por cual letra desea hacer la sustitucion: ");
            q = char.Parse(Console.ReadLine());

            posicion = 0;

            while(frase[posicion] != '\0'){
                if(frase[posicion] == p)
                    frase[posicion] = q;

                posicion++;
            }
            Console.Write("has generado la siguiente frase: ");

            posicion = 0;
            while(frase [posicion] != '\0'){
                Console.Write(frase[posicion]);
                posicion++;
            }


        }
    }
}
