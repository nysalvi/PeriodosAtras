using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        enum PeriodoTempo { dias, semanas, meses, anos};
        static void Main(string[] args)
        {            
            Calendario calendario = new Calendario();
            string opcao;
            int[] periodo;
            (int dias,int semanas) = ((int) PeriodoTempo.dias, (int) PeriodoTempo.semanas);
            (int meses,int anos) = ((int)PeriodoTempo.meses, (int) PeriodoTempo.anos);
            while (true)
            {                
                Console.WriteLine("Digite 1 - para escolher");
                Console.WriteLine("Digite s - para sair");
                opcao = Console.ReadLine();
                if (opcao == "s")
                    break;
                if (opcao == "1")
                {
                    bool valido = calendario.ObterData();
                    periodo = calendario.CalculaTempo();
                    bool periodoValido = periodo != null;
                    if (periodoValido)
                    {
                        Console.WriteLine("Anos : {0}\nMeses : {1}\nSemanas : {2}\nDias : {3}",
                            periodo[anos], periodo[meses], periodo[semanas], periodo[dias]);
                    }
                    
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
