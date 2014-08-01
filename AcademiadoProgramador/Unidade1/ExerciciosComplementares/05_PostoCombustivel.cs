using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosComplementares
{
    class PostoCombustivel
    {
        /* 5) Um posto está vendendo combustíveis com a seguinte tabela de descontos:

        Álcool até 20 litros, desconto de 3% por litro:

        Acima de 20 litros, desconto de 5% por litro.

        Gasolina até 20 litros, desconto de 4% por litro:

        Acima de 20 litros, desconto de 6% por litro.

        Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado da seguinte forma:
        A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente sabendo-se que o preço do litro da gasolina
        é R$ 3,30 e o preço do litro do álcool é R$ 2,90. */

        static void Main5()
        {
            string opcaoDeCombustivel;
            double quantidadeCombustivel, valorAPagar;

            Console.WriteLine("Alcool ou gasolina? ");
            opcaoDeCombustivel = Console.ReadLine();
            Console.WriteLine("Deseja quantos litros? ");
            quantidadeCombustivel = double.Parse(Console.ReadLine());

            if (opcaoDeCombustivel == "G" || opcaoDeCombustivel == "g")
            {
                if (quantidadeCombustivel <= 20)
                {
                    valorAPagar = (quantidadeCombustivel * 3.30) - (quantidadeCombustivel * 3.30 * 0.4);
                }
                else
                {
                    valorAPagar = (quantidadeCombustivel * 3.30) - (quantidadeCombustivel * 3.30 * 0.6);
                }
            }
            else
            {
                if (quantidadeCombustivel <= 20)
                {
                    valorAPagar = (quantidadeCombustivel * 2.90) - (quantidadeCombustivel * 3.30 * 0.3);
                }
                else
                {
                    valorAPagar = (quantidadeCombustivel * 2.90) - (quantidadeCombustivel * 3.30 * 0.5);
                }
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Total a pagar R$" + valorAPagar);
            Console.ReadLine();
        }
    }
}
