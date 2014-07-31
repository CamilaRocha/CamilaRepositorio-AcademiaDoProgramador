using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosComplementares
{
    class Triangulo
    {
        /* 1) Crie umprograma que imprima na tela um triângulo de “*”.*/
        public static void Main1(string[] args)
        {
            Console.WriteLine("     *        ");
            Console.WriteLine("    ***       ");
            Console.WriteLine("   *****      ");
            Console.WriteLine("  *******     ");
            Console.WriteLine(" *********    ");
            Console.WriteLine("***********   ");
            Console.ReadLine();


            // outra forma


            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
