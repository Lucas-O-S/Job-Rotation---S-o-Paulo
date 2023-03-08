using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.Write("Digite algo: ");
            texto = Console.ReadLine();
            Console.Write($"O texto invertido é: ");
            
            for(int i = texto.Length -1 ; i >= 0;i--)
            {
                Console.Write(texto[i]);
            }
        }
    }
}
