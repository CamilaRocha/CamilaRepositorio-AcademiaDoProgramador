using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosComplementares
{
    class Estoque
    {
        /* 4) Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque e quantidade mínima 
         em estoque de um produto. Calcular e escrever a quantidade média 
         ((quantidade média = quantidade máxima + quantidade mínima) /2). Se a quantidade em estoque for maior ou igual a
         quantidade média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar compra'. */

        static void Main4()
        {
            int quantidadeAtual, quantidadeMaxima, quantidadeMinima;
            double quantidadeMedia;

            Console.WriteLine("Informe a quantidade atual de produtos no estoque: ");
            quantidadeAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade máxima: ");
            quantidadeMaxima = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade minima: ");
            quantidadeMinima = int.Parse(Console.ReadLine());

            quantidadeMedia = (quantidadeMaxima + quantidadeMinima) / 2;
            Console.Clear();

            if (quantidadeAtual >= quantidadeMedia)
            {
                Console.WriteLine("Não efetuar compra!");
            }
            else
            {
                Console.WriteLine("Efetuar compra!");
            }

            Console.ReadLine();
            
        }
    }
}
