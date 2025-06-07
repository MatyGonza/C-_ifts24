// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Bucles");
        Console.WriteLine();
        
        //while
        int contador = 0; //probar incializando contador en 10
        Console.WriteLine("while");
        Console.WriteLine();
        while (contador < 10)
        {
            Console.WriteLine("contador = {0}",contador);
            contador = contador + 1;
        }
        Console.WriteLine();
        Console.WriteLine("Valor final: {0}",contador);
        
        Console.WriteLine();
        Console.Write("Pulse una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        //do while
        Console.WriteLine("do while");
        Console.WriteLine();
        contador = 0; //probar incializando contador en 10
        do
        {
            Console.WriteLine("contador = {0}",contador);
            contador = contador + 1;

        } while (contador < 10);
        Console.WriteLine();
        Console.WriteLine("Valor final: {0}",contador);

        Console.WriteLine();
        Console.Write("Pulse una tecla para continuar....");
        Console.ReadKey();
        Console.Clear();
        
        //for
        Console.WriteLine("for");
        Console.WriteLine();
        for (int Var = 1; Var <= 10;Var++)
        {
            Console.WriteLine("Var = {0}",Var);
        }
        //otro ejemplo
        for (int Var = 100; Var >= 10; Var = Var - 10)
        {
            Console.WriteLine("Var = {0}",Var);
        }

        
        
        Console.WriteLine();
        Console.Write("Pulse una tecla para continuar....");
        Console.ReadKey();
        Console.Clear();



    }
}