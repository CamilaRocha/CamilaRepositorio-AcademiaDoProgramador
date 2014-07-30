using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.Logica
{
    class ImprimePadrao2
    {
        /* Faça um programa que percorra todos os números de 1 até 100. Para os números múltiplos de 4, imprima a palavra “PI”,
         e para os outros, imprima o próprio número. Veja o exemplo abaixo: 1 2 3 PI 5 */

        public static void Main5(string[] args)
        {
            for (int contador = 0; contador <= 100; contador++)
            {
                int resto = contador % 4;
                if (resto == 4)
                {
                    Console.WriteLine("PI");
                }
                else
                {
                    Console.WriteLine(contador);
                }
            }
            Console.ReadLine();
        }
    }
}
