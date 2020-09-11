/*Hacer un programa que genere las tablas de multiplicar de los números múltiplos de 5
que hay entre 1 y 1000
Autor: Rainier L. De Jesus Lopez*/

using System;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
         
         for (int i=1; i<=1000; i++)
         {
             if (Multiplos(i)==true)
             {
                 Console.WriteLine("Mostrando la tabla del " + i+ " Multiplo de [5]\n");
                 for(int x =1; x<=10;x++)
                 {
                     Console.WriteLine(i + " X " + x + " = "+ i*x);
                 }
                  Console.Write("\nPresione [ENTER-INTRO] para mostrar la siguiente tabla!");
                 Console.ReadKey();
                 Console.Clear();
             }
         }

        }

        static bool Multiplos(int num)
        {
            if (num % 5==0){return true;}
                else {return false;}
        }
    }
}
