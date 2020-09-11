/*Escriba un programa que imprima en pantalla los números enteros que existan entre los
números cuales quiera que ingrese el usuario como inicio y fin.
Autor: Rainier L. De Jesus Lopez */
using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStart, numEnd;
            Console.Write("----> NUMEROS ENTEROS ENTRE DOS CANTIDADES <----\n");
            Console.Write("Ingrese un numero inicial...:");
            numStart=Convert.ToInt16(Console.ReadLine());
            Console.Write("Ingrese un numero inicial...:");
            numEnd=Convert.ToInt16(Console.ReadLine());

            for(int i=numStart + 1; i<numEnd; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
