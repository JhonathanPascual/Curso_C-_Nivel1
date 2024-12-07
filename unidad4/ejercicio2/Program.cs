using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo 
            //de la cantidad de litros vendidos según la siguiente escala:

            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            //Hacer un programa que solicite el ingreso del importe total de la venta 
            //y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
  
            int importe, litros;
            float tp, des1 = 0.9f, des2 = 0.85f, des3 = 0.75f;


            Console.Write("Ingrese el importe: ");
            importe = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de litros: ");
            litros = int.Parse(Console.ReadLine());

            if(litros > 500){
                tp = importe * des3;
                Console.WriteLine("25% de descuento aplicado");
            }else if(litros > 300){
                tp = importe * des2;
                Console.WriteLine("15% de descuento aplicado");
            }else if(litros > 100){
                tp = importe * des1;
                Console.WriteLine("10% de descuento aplicado");
            } else{
                tp = importe
                Console.WriteLine("Ningun descuento aplicado");
            }

            Console.WriteLine("Total a pagar: "+ tp);

        }
    }
}
