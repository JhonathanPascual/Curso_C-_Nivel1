using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
            //Para ello existe la siguiente escala de precios:

                        //i5 (1)	i7 (2)	  i9 (3)
            //08 RAM (1) USD 800	USD 900   USD 1200
            //16 RAM (2) USD 900	USD 1000  USD 1400
            //32 RAM (3) USD 1000	USD 1400  USD 2000

            //Además, el equipo viene con un disco que permite almacenar 500 GB de información 
            //y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
            //Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, 
            //y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) 
            //y calcule y emita por pantalla el monto de la máquina seleccionada.

            int cpu, ram, precioParcial, disc, tp;
            

           Console.Write("Que procesador prefiere?: ");
           cpu = int.Parse(Console.ReadLine());

           Console.Write("Cuanto de RAM prefiere?: ");
           ram = int.Parse(Console.ReadLine());

           Console.Write("Desea extender su almacenamiento?: ");
           disc = int.Parse(Console.ReadLine());

           switch(cpu){
                case 1 :
                    switch(ram){
                        case 1 :
                            precioParcial = 800;
                            if(disc == 1)
                                precioParcial += 300;
                        break;
                        case 2 :
                            precioParcial = 900;
                            if(disc == 1)
                                precioParcial += 300;
                        break;
                        case 3 :
                            precioParcial = 1000;
                            if(disc == 1)
                                precioParcial += 300;
                        break;
                        default:
                            precioParcial = 0;
                            Console.WriteLine("Eliga una de las opciones RAM correctas");
                        break;
                            
                    }
                break;
                case 2 :
                    switch(ram){
                        case 1:
                            precioParcial = 900;
                            if(disc == 1)
                                precioParcial += 300;
                        break;
                        case 2:
                            precioParcial = 1000;
                            if(disc == 1)
                                precioParcial += 300;
                        break;
                        case 3:
                            precioParcial = 1400;
                            if(disc == 1)
                                precioParcial += 300;
                        break;
                        default:
                            precioParcial = 0;
                            Console.WriteLine("Eliga una de las opciones RAM correctas");
                        break;
                    }
                break;
                case 3 :
                    switch(ram){
                        case 1 :
                            precioParcial = 1200;
                            if(disc == 1)
                                precioParcial += 300;
                        break;
                        case 2 :
                            precioParcial = 1400;
                            if(disc == 1)
                                precioParcial += 300;
                        break;
                        case 3 :
                            precioParcial = 2000;
                            if(disc == 1)
                                precioParcial += 300;
                        break;
                        default:
                            precioParcial = 0;
                            Console.WriteLine("Eliga una de las opciones RAM correctas");
                        break;
                    }

                break;
                default:
                    precioParcial = 0;
                    Console.WriteLine("Eliga una de las opciones de procesador correctas");
                break;

           }

            tp = precioParcial; 

            Console.WriteLine("El precio de la pc es: "+ tp);

        }
    }
}
