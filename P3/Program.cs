/* Cree un método que reciba como parámetro un nombre de usuario y una clave, y
retorne verdadero solo cuando el usuario sea ‘admin’ y la clave ‘1234’. El programa
debe pedir los datos hasta que sean verdaderos o haya realizado 3 intentos.
Autor: Rainier L. De Jesus Lopez */

using System;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {     
        Console.WriteLine("***** LOGIN DE USUARIO *****\n");
        string user, password;var cont=0;
        bool resp;
        do
        {
            Console.Write("Ingrese su Usuario...:");
            user=Console.ReadLine();
            Console.Write("Ingrese su Password...:");
            password=Console.ReadLine();
            resp=ValidarUsuario(user,password);
            cont +=1;
            
        } while (cont<3 && resp!=true);
    }
    
        static bool ValidarUsuario(string Usuario, string Password)
        {
            if (Usuario=="admin" && Password=="1234")
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}
