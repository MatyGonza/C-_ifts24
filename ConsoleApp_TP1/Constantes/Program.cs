namespace Operadores
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Var1 = 10;
            int Var2 = 100;
            bool Var3 = true;
            bool Var4 = false;
            int varResultado = 0;
            
            Console.WriteLine("Operadores aritmeticos"); 
            Console.WriteLine();
            
            Console.WriteLine("var1 = {0}",Var1);
            Console.WriteLine("var2 = {0}",Var2);
            Console.WriteLine();
            
            Console.WriteLine("var1 + var2 = {0}", Var1 + Var2 );
            Console.WriteLine("var1 - var2 = {0}", Var1 - Var2 );
            Console.WriteLine("var1 / var2 = {0}", Var1 / Var2 );
            Console.WriteLine("var1 % var2 = {0}", Var1 % Var2 );
        }
    }
}