using System;
using System.Linq;

namespace GFT_Desafio2_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
            int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
            int totalDeFigurinhas = 0;

            int[] albumDeFigurinha = new int[numeroDeFigurinhasCompradas];

            // IMPLEMENTE AQUI A SOLUÇÃO

            //Ler do console número das figurinhas compradas.
            for (int i = 0; i < numeroDeFigurinhasCompradas; i++)
            {
                albumDeFigurinha[i] = int.Parse(Console.ReadLine());
            }

            //Contar número de figurinhas diferentes.
            int numeroFigurinhasDiferentes = albumDeFigurinha.Distinct().Count();

            //Calcular número de figurinhas restantes.
            totalDeFigurinhas = numeroDeFigurinhas - numeroFigurinhasDiferentes;
            
            //Escrever no console o número de figurinhas faltantes
            Console.WriteLine(totalDeFigurinhas);
        }
    }
}
