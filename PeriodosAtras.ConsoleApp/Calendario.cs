using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    internal class Calendario
    {
        DateTime? data2, data1;
        int dia, mes, ano;        
        TimeSpan? intervalo;
        public DateTime?[] ObterData()
        {
            Console.WriteLine("Digite a data inicial : ");
            string primeiraData = Console.ReadLine();
            Console.WriteLine("Digite a data final : ");
            string segundaData = Console.ReadLine();

            DateTime.TryParse(primeiraData, out DateTime data1);
            DateTime.TryParse(segundaData, out DateTime data2);

            bool sucesso = ValidaData(data1, data2);
            if (sucesso)
            {
                Console.WriteLine("As duas Datas são válidas !");
                return new DateTime?[] { this.data1, this.data2 };
            }
            else
                Console.WriteLine("Uma ou Ambas as Datas são Inválidas !!!");
            return null;
        }
        public bool ValidaData(DateTime? primeiraData, DateTime? segundaData)
        {
            bool primeiraDataInvalida = primeiraData == null || primeiraData < DateTime.MinValue 
                || primeiraData > DateTime.Now;
            if (primeiraDataInvalida)
                return false;
            bool segundaDataInvalida = segundaData == null || segundaData < DateTime.MinValue
                || segundaData > DateTime.Now;
            if (segundaDataInvalida)
                return false;

            bool primeiraDataMaior = primeiraData > segundaData;
            if (primeiraDataMaior)
            {
                this.data1 = segundaData;
                this.data2 = primeiraData;
            }
            else
            {
                this.data1 = primeiraData;
                this.data2 = segundaData; 
            }
            intervalo = segundaData - primeiraData;
            return true;
        }
        public void CalculaTempo()
        {
            if (data1 == null || data2 == null)
                return;
        }
    }
}
