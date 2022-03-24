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
        int dia, semana, mes, ano;        
        TimeSpan? intervalo;
        public bool ObterData()
        {
            Console.WriteLine("Digite a data inicial : ");
            string primeiraData = Console.ReadLine();
            Console.WriteLine("Digite a data final : ");
            string segundaData = Console.ReadLine();

            DateTime? data1 = DateTime.Parse(primeiraData);
            DateTime? data2 = DateTime.Parse(primeiraData);

            bool sucesso = ValidaData(data1, data2);
            if (sucesso)
            {
                Console.WriteLine("As duas Datas são válidas !");
                this.data1 = data1;
                this.data2 = data2;
                return true;
            }
            else
                Console.WriteLine("Uma ou Ambas as Datas são Inválidas !!!");
            return false;
        }
        private bool ValidaData(DateTime? primeiraData, DateTime? segundaData)
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
        public int[] CalculaTempo()
        {
            if (data1 == null || data2 == null)
                return null;
            ano = data2.Value.Year - data1.Value.Year;
            if (data2.Value.Year - data1.Value.Year < 0)
                ano *= -1;
            mes = data2.Value.Month - data1.Value.Month;
            if (data2.Value.Month - data1.Value.Month < 0)
                mes *= -1;
            semana = (data2.Value.Day - data1.Value.Day) / 7;
            dia = (data2.Value.Day - data1.Value.Day) - semana * 7;
            if (data2.Value.Day - data1.Value.Day < 0)
                dia *= -1;
            return new int[4] { dia, semana, mes, ano };
        }
    }
}
