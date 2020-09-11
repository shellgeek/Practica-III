/*Realizar un programa que presente un menú con las siguientes opciones (usar
funciones)
1-Convertir grados a Celsius a Fahrenheit
2-Convertir dólar a pesos
3-Convertir metros a pies
4-Salir
Autor: Rainier L. De Jesus Lopez 
*/
using System;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {   int opt=0;
            do {
            Console.Clear();
            Console.WriteLine("-------------- SISTEMA DE CONVERSION --------------\n");
            Console.WriteLine("[1] - Convertir grados a Celsius a Fahrenheit");
            Console.WriteLine("[2] - Convertir dólar a pesos");
            Console.WriteLine("[3] - Convertir metros a pies");
            Console.WriteLine("[4] - Salir\n");
            Console.Write("SELECCIONE UNA OPERACION A REALIZAR [1],[2],[3],[4]...:");
            opt=int.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1:
                CelsiusToFahrenheit();
                break;
                case 2:
                DollarToPeso();
                break;
                case 3:
                MetrosToPies();
                break;
                case 4:
                Environment.Exit(0);
                break;
                default:
                Console.WriteLine("Ingrese una opcion valida!");
                break;
    
            }
            } while(opt!=4);
        }
      
        static void CelsiusToFahrenheit()
        {
            double Celsius, Fahrenheit;
            Console.Clear();
            Console.WriteLine("-------------- Convertir grados a Celsius a Fahrenheit --------------\n");
            Console.Write("Ingrese un valor en Grados Celsius...:");
            Celsius=Convert.ToDouble(Console.ReadLine());
            Fahrenheit=(Celsius * 9) / 5 +32;
            Console.WriteLine("\n-------------- CELSIUS A FAHRENHEIT ---------------");
            Console.Write( "\n"+Celsius+" Grados Celsius es igual a "+Fahrenheit + " Grados Fahrenheit");
            Console.ReadLine();
        }

        static void DollarToPeso()
        {
           double dolares, tasa=58.58, pesos;
           Console.Clear();
           Console.WriteLine("--------------CALCULO DOLARES (US$) A PESOS (RD$) --------------\n");
           Console.Write("Ingrese una Cantidad en Dolares (US$)...:");
           dolares = Convert.ToDouble(Console.ReadLine());
           pesos = dolares*tasa;
           Console.WriteLine("-------------- DOLARES A PESOS ---------------\n");
           Console.WriteLine("Monto en Dolares --> {0}",dolares);
           Console.WriteLine("Tasa de Cambio --> {0}",tasa); 
           Console.WriteLine("Total en Pesos --> {0}", pesos);
           Console.ReadKey();
        }

        static void MetrosToPies()
        {
            double pies, metros;
            Console.Clear();
            Console.WriteLine("-------------- Convirtiendo Metros a Pies --------------\n ");
            Console.Write("Ingresa la Distancia en Metros (m)...:");
            metros=Convert.ToDouble(Console.ReadLine());
            pies = metros * 3.2808;
            Console.WriteLine("\n"+ metros + " Metros equivale  a " + pies + " Pies");
            Console.ReadKey();
        }

    }
}
