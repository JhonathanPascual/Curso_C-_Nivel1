using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada 
            //según los siguientes valores:

            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            
            int importe;
            float desc2 = 0.82f, desc1 = 0.90f, pf;

            Console.WriteLine("Ingrese el importe: ");
            importe = int.Parse(Console.ReadLine());

            if(importe >= 5000){
                Console.WriteLine("Descuento del 18% aplicado");
                pf = importe * desc2;
            }else if (importe >= 1000){
                Console.WriteLine("Descuento del 10% aplicado");
                pf = importe * desc1;
            }else{
                pf = importe;
                Console.WriteLine("No aplica para descuentos");
            }

            Console.WriteLine("El total a pagar es: " + pf);

        }
    }
}
