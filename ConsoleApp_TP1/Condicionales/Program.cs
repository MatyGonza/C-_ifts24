// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography;

namespace Condicionales
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int Var1 = 10;
            int Var2 = 20;
            int Var3 = 3;
            
            Console.WriteLine("Condicionales");
            Console.WriteLine();
            
            Console.WriteLine("Var1 = {0}",Var1);
            Console.WriteLine("Var2 = {0}",Var2);
            Console.WriteLine("Var3 = {0}",Var3);
            Console.WriteLine();
            
            //if simple
            if (Var1 == Var2)
            {
                Console.WriteLine("El valor de ambas variables el mismo");
            }
            
            //if con else
            if (Var1 == Var2)
            {
                Console.WriteLine("El valor de ambas variables el mismo");
            }
            else
            {
                Console.WriteLine("El valor de ambas variables es distinto");
            }
            Console.WriteLine();
            
            //if anidado
            if (Var1 == Var2)
            {
                Console.WriteLine("El valor de ambas variables el mismo");
                Console.WriteLine();
            }
            else
            {
                if (Var1 > Var2)
                {
                    Console.WriteLine("Var1 > Var2");
                }
                else
                {
                    Console.WriteLine("Var1 < Var2");
                }
                Console.WriteLine();
            }
            
            //switch

            switch (Var3)
            {
                case 1 :
                    Console.WriteLine("var3 = primavera");
                    break;
                
                case 2:
                    Console.WriteLine("var3 = verano");
                    break;
                
                case 3:
                    Console.WriteLine("var3 = otoño");
                    break;
                
                case 4:
                    Console.WriteLine("var3 = invierno");
                    break;
                default: //si no es nungun de los indicado arriba
                    Console.WriteLine("var3 fuera de rango");
                    break;
            }
            Console.WriteLine();
            
            //switch con rangos
            switch (Var3)
            {
                case 1:
                    
                case 2:
                    
                case 3:
                    Console.WriteLine("var3 1,2 o 3");
                    break;
                case 4 : 
                    Console.WriteLine("var3 4");
                    break;
                default:
                    Console.WriteLine("var3 Fuera de rango");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para continuar....");
            Console.ReadKey();
            


        }
    }
}
