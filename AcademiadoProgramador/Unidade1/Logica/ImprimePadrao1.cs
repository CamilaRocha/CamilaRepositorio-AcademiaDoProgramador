using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.Logica
{
    class ImprimePadrao1
    {
        /*  Faça um programa que percorra todos os números de 1 até 100. Para os números ímpares, deve ser impresso um “*”,
         e para os números pares, deve ser impresso dois “**”. Veja o exemplo abaixo:
         * ** * ** * **  */ 

        public static void Main4(string[] args)
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 2;
                if (resto == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine("**");
                }
            }
            Console.ReadLine();
        }
    }
}
