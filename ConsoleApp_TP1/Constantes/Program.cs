namespace Constantes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Constantes");
            Console.WriteLine();

            const string Empresa = "Acme";//define y asigna el valor de la constante
            const byte HorasLaborales = 40;
            
            Console.WriteLine("Empresa:{0}. Horas laborales:{1}",Empresa,HorasLaborales);
            Console.WriteLine();
            
            Console.Write("Pulse una tecla para continuar ...");
            Console.ReadKey();
        }
    }
}