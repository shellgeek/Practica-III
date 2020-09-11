/*Cree un método (función) que reciba un numero como parámetro de entrada y retorne
este número duplicado. Ejemplo: si ingresa 3, debe retornar 6
Autor: Rainier L. De Jesus Lopez */

using System;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, result;
             Console.WriteLine("***** DUPLICADO DE UN NUMERO *****\n");
             Console.Write("Ingrese un Numero...:");
             numero=Convert.ToInt32(Console.ReadLine());
             result = DoblarNum(numero);
             Console.Write("El resultado es...:{0}",result);

            
        }

       static int DoblarNum(int num)
        {
            return num*2;
        }
    }
}
