using System;
using System.IO;
using Newtonsoft.Json;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float maior = 0, menor = 999999, Soma=0, media;
            int count, countAcimaMedia=0;
          

            string json = File.ReadAllText("dados.json");
            dynamic info = JsonConvert.DeserializeObject(json);

            int[] dia = new int[info.Count];
            float[] valor = new float[info.Count];
            count = info.Count;


            for (int i = 0; i< info.Count; i++)
            {
                dia[i] = info[i].dia;
                valor[i] = info[i].valor;


                if(valor[i] > maior)
                {
                    maior = valor[i];

                }

                if (valor[i] < menor)
                {
                    menor = valor[i];

                }

                if (valor[i] == 0){
                    count--;
                }
                Soma += valor[i];


            }

            media = Soma / count;

            for(int i = 0; i < info.Count; i++)
            {
                if (valor[i] > media)
                {
                    countAcimaMedia += 1;
                }
            }

            Console.WriteLine("dias: " + string.Join(", ", dia));
            Console.WriteLine("dias: " + string.Join(", ", valor));
            Console.WriteLine("media: " + string.Join(", ", media));


            Console.WriteLine($"Maior faturamento foi: {maior}\nMenor faturamento foi: {menor}\nHouve {countAcimaMedia} dias com faturamento acima da media");




        }
    }
}
