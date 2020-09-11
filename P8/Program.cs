/* Realizar un programa que reciba por teclado el sueldo de un empleado y le aplique los
cálculos de ISR (ver tabla DGII), ARS, y AFP (investigar porcentajes)
Autor: Rainier L. De Jesus Lopez
*/
using System;

namespace P8
{
    class Program
    {
        static void Main(string[] args)
        {   double sueldo;
            Console.Clear();
            Console.WriteLine("-----> CALCULO DE DESCUENTOSA EMPLEADO <-----\n");
            Console.Write("Ingrese el sueldo del empleado....:");
            sueldo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n-------> RESULTADO DEL CALCULO  <-------\n");
            Console.WriteLine("Descuento a la ARS...:{0}",string.Format("{0:C2}", CalculoArs(sueldo)));
            Console.WriteLine("Descuento a la AFP...:{0}",string.Format("{0:C2}",  CalculoAfp(sueldo)));
            Console.WriteLine("Descuento ISR...:{0}", string.Format("{0:C2}", CalculoIsr(sueldo)));
      
      
        static double CalculoArs(double sueldo)
        {
            return sueldo * 0.0304;
        }

        static double CalculoAfp(double sueldo)
        {
            return sueldo * 0.0287;
        }

        static double CalculoIsr(double sueldo)
        {
            double isr=0, exedente=0;
            double sueldoAnual = sueldo * 12;

            if (sueldoAnual>=416220.01 && sueldoAnual<=624329.00)
                {
                    exedente = sueldoAnual - 416220.01;   
                    exedente *= 0.15;
                    isr=exedente/=12;
                }
                    else if (sueldoAnual >= 624329.01 && sueldoAnual <= 867123.00)
                    { 
                        exedente = sueldoAnual - 624329.01; 
                        exedente*=0.20;
                        isr=(exedente + 31216) / 12;
                    }
                        else if(sueldoAnual>=867123.01)
                        {
                            exedente = sueldoAnual - 867123.01;
                            exedente *= 0.25;
                            isr=(exedente + 79776) / 12;
                        }
            return isr;
            }

        }
    }

}