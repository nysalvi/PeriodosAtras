using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calendario calendario = new Calendario();
            string opcao;
            while (true)
            {                
                Console.WriteLine("Digite 1 - para escolher");
                Console.WriteLine("Digite s - para sair");
                opcao = Console.ReadLine();
                if (opcao == "s")
                    break;
                if (opcao == "1")
                {
                    calendario.ObterData();
                    calendario.CalculaTempo();
                }
                    
            }
        }
    }
}
