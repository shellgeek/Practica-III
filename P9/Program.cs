/*
Cree una aplicación de cajero automático para el banco ABC. El cajero tendrá un límite
de billetes descrito a continuación: 9 de 1000, 19 de 500, 99 de 100
El cajero debe solicitar Banco y monto a retirar. Si el banco es ABC el limite de retiro son
10,000 y 2000 pesos por transacción en caso contrario. El cajero debe informar si el
monto solicitado no puede ser dispensado o si excede el límite de transacción. Y debe
hacer la distribución de los billetes de acuerdo al monto. Por ejemplo, si el usuario
solicita 3,900 y hay disponibilidad en todos los billetes, el cajero debe dispensar 3
billetes de mil, 1 de quinientos y 4 de cien.
Autor: Rainier L. De Jesus Lopez*/


using System;
using System.Collections.Generic;
using System.Text;

namespace  P1
{
    class Program
    {
        static void Main(string[] args)
        {       
                
            int CantidadDinero;
            int Billetes1000;
            int Billetes500;
            int Billetes100;
            int Residuo;

            Console.Clear();
            Console.WriteLine("\t\t********* RETIRO DE EFECTIVO **********\n");
            Console.Write("\nESTE CAJERO SOLO DISPENSA BILLETES DE [1000] [500] [100]\n");
            Console.WriteLine("Ingrese la Cantidad de Dinero que desea retirar");
            CantidadDinero = int.Parse(Console.ReadLine());
            // Procesamineto
           
           
            Billetes1000 = CantidadDinero / 1000;
            Residuo = CantidadDinero % 1000;

            Billetes500 = Residuo / 500;
            Residuo=Residuo % 500;

            Billetes100 = Residuo / 100;
            Residuo = Residuo % 100;

            //Mostrar resultados
            Console.Clear();
            Console.WriteLine("Dinero Solicitado  : {0}", CantidadDinero);
            Console.WriteLine("Billetes de 1000    : {0}", Billetes1000 );
            Console.WriteLine("Billetes de 500    : {0}", Billetes500);
            Console.WriteLine("Billetes de 100     : {0}", Billetes100);

            Console.ReadLine();
        }
    }
}
