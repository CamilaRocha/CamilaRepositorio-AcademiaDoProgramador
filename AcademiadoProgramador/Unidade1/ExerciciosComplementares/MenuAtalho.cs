using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosComplementares
{
    class MenuAtalho
    {
        /*  Use seus conhecimentos para criar um programa que mostre um menu de atalho para os 5 padrões que acabamos de
         fazer */
        
        public static void Main4(string[] args)
        {
            int opção = 1;

            Console.WriteLine(" ************ Menu ********** ");
            Console.WriteLine();
            Console.WriteLine(" 1) Opção - 1 ");
            Console.WriteLine(" 2) Opção - 2 ");
            Console.WriteLine(" 3) Opção - 3 ");
            Console.WriteLine(" 4) Opção - 4 ");
            Console.WriteLine();

            Console.WriteLine("Informe a opção desejada: ");
            while (opção != 0)
            {
                
                string ValorTela = Console.ReadLine();
                opção = int.Parse(ValorTela);

                Console.Clear();

                if (opção == 1)
                {
                    Console.WriteLine("Seja bem vindo!");
                }
                else if (opção == 2)
                {
                    Console.WriteLine("Parabéns!");
                }
                else if (opção == 3)
                {
                    Console.WriteLine("hahaha!");
                }
                else if (opção == 4)
                {
                    Console.WriteLine("Boa Sorte!");
                }
            }



            Console.ReadLine();
        }
    }
}
