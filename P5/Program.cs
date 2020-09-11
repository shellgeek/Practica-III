/*Hacer una función que reciba un numero de mes y retorne el nombre del mes
correspondiente a ese número. Ejemplo, si ingresa 4, debe retornar ABRIL
*/
using System;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMes;
            Console.WriteLine("***** MESES DEL AÑO *****\n");
            Console.Write("Ingrese un Numero  de Mes...:");
            numMes=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El mes introducido es...:{0}", numtomes(numMes));
        }

        static string numtomes(int numMes)
        {
            string mes="";
            switch (numMes)
            {
                case 1:
                    mes= "Enero";
                    break;
                case 2:
                    mes= "Febrero";
                    break;
                case 3:
                    mes= "Marzo";
                    break;
                case 4:
                    mes= "Abril";
                    break;
                case 5:
                    mes= "Mayo";
                    break;
                case 6:
                    mes= "Junio";
                    break;
                case 7:
                    mes= "Julio";
                    break;
                case 8:
                    mes= "Agosto";
                    break;
                case 9:
                    mes= "Septiembre";
                    break;
                case 10:
                    mes= "Octubre";
                    break;
                case 11:
                    mes= "Noviembre";
                    break;
                case 12:
                    mes= "Diciembre";
                    break;
                default:
                    Console.WriteLine("Ingrese un numero de mes valido!");
                    break;
                
            }
            return mes; 
        }
    }
}
