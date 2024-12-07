using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro 
            //con los siguientes datos:
            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 

            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo
            // igual a 0.

            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.

            int [] ventas = new int[15];
            int numeroDeArticulo, cantidadVendida, maximo = 0, posicionMaximo = 0;

            Console.Write("Ingrese el numero de articulo: ");
            numeroDeArticulo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            while(numeroDeArticulo != 0){
                ventas[numeroDeArticulo - 1] += cantidadVendida;

                Console.Write("Ingrese el numero de articulo: ");
                numeroDeArticulo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad vendida: ");
                cantidadVendida = int.Parse(Console.ReadLine());
            }

            //Punto A

            for (int x = 0; x < 15; x++)
            {
                if(ventas[x] > maximo){
                    maximo = ventas[x];
                    posicionMaximo = x + 1;

                }
            }
            Console.WriteLine("El articulo mas vendido fue el numero: " + posicionMaximo);

            //Punto B

            Console.WriteLine("Los siguientes articulos no registraron ventas: ");

            for (int x = 0; x < 15; x++)
            {
                if(ventas[x] == 0)
                    Console.Write(x + 1 +" ,");
            }

            //Punto C

            Console.WriteLine(" El articulo numero 10 registro "+ ventas[9] + " articulos vendidos");
 

                
        }
    }
}
