/*Realizar un programa que solicite al usuario un número indeterminado de números
(mientras se tecleen números que no sean cero). Al salir el programa debe dar en
pantalla el total de números dados y la suma de ellos.
Autor: Rainier L. De Jesus Lopez*/
 
using System;
 
namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
        int num, sum=0, cont=0;
        Console.Clear();
          Console.Write("***** [PARA TERNINAR INGRESE 0] ****\n\n");
          do
          {
              Console.Write("Ingrese un Numero...:");
              num=Convert.ToInt32(Console.ReadLine());
              cont+=1;
              sum +=num;
          } while (num>0);
        Console.Write("Cantidades introducidas...:{0}\n", cont-1);
        Console.Write("La Sumatoria de los numeros ingresados es...:{0}",sum );
        }
    }
}
