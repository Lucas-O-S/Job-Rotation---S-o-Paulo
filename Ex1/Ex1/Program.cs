using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma=0, i=1,temp;
            bool pertence = false;
            Console.Write("Digite um valor para verificar se ele pertence a sequencia de fibonacci: ");
            num = Convert.ToInt32(Console.ReadLine());

            while(soma <= num)
            {

                temp = soma;
                soma = i;

                i += temp;

                if (i == num || num == 0)
                {
                    pertence=true;
                }
            }

            if (pertence == true)
            {
                Console.WriteLine($"Numero {num} esta presente na sequencia de fibonacci");
            }
            else
            {
                Console.WriteLine($"Numero {num} não esta presente na sequencia de fibonacci");

            }


        }
    }
}
