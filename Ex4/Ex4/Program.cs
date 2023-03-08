using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] local = new string[5] { "SP","RJ","MG","ES","Outros" };
            double[] faturamento = new double[5] { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };
            double[] porcent = new double[5];
            double Soma = 0;

            for (int i=0; i <local.Length;i++)
            {
                Soma += faturamento[i];
            }

            for (int i = 0; i < local.Length; i++)
            {
                porcent[i] = (faturamento[i]/Soma)*100;
                Console.WriteLine($"Local: {local[i]}, Faturmento R${faturamento[i]}, Porcentagem {porcent[i]:F2}%");
            }
        }
    }
}
