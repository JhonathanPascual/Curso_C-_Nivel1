using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
            //Se pide determinar e informar:

            //El número de grupo con mayor porcentaje de números impares respecto al total de números 
            //que forman el grupo. Informar cuántos grupos están formados por todos números ordenados 
            //de mayor a menor.


            int n, posision = 0, bImp = 0, maxImp = 0, contOrden = 0;

            for (int x = 0; x < 5; x++)
            {
                int  contNum = 0, contImp = 0, porImp = 0, mayor = 0;
                bool bOrdenados = true;
                Console.Write("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                while(n != 0){
                    
                    if(n%2 != 0){
                        contImp++;

                    }
                    
                    if(contNum == 0)
                        mayor = n;
                    else if(n < mayor){
                        mayor = n;
                    }else 
                        bOrdenados = false;

                    contNum++;
                Console.Write("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());  
                }

                if(bOrdenados)
                    contOrden = contOrden + 1;

                // acunum  -->   100%
                // contImp  -->    X
                porImp = (contImp * 100)/contNum;

                if(bImp == 0){
                    bImp+=1;
                    maxImp = porImp;
                    posision = x + 1;
                }else{
                    if(porImp > maxImp){
                        maxImp = porImp;
                        posision = x + 1;
                    }
                }


            }

            Console.WriteLine("El grupo con mas impares es el grupo #" + posision);
            Console.WriteLine(contOrden + " grupos estaban ordenados de mayor a menor");
        }
    }
}
