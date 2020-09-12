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

namespace P9
{
    class Program
    {
        static void Main(string[] args)
        {
         int Bill1000 = 9, Bill500 = 19, Bill100 = 99,  cant=0;
            Console.WriteLine("digite el monto a separar:");
            cant = Convert.ToInt16(Console.ReadLine());
            Bill1000 = cant / 1000;
            cant = cant - (Bill1000 * 1000);
            Bill500 = cant / 500;
            cant = cant - (Bill500 * 500);
            Bill100 = cant / 100;
            cant = cant - (Bill100 * 100);
           
            Console.WriteLine("billetes de 1000:" + Bill1000);
            Console.WriteLine("billetes de 500:" + Bill500);
            Console.WriteLine("billetes de 100:" + Bill100);
            Console.ReadKey();

        }
    }
}
