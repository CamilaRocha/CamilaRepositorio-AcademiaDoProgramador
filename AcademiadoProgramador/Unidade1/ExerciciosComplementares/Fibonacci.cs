using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosComplementares
{
    class Fibonacci
    {
        /* Os números de Fibonacci são uma sequência de números definida recursivamente. O primeiro elemento da sequência é
         0 e o segundo é 1. Os outros elementos são calculados somando os dois antecessores. 
         0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233...  
         Crie um programa para imprimir os 30 primeiros números da sequência de Fibonacci.  */

        public static void Main3(string[] args)
        {
         
            int soma, valor1 = 0, valor2 = 1;
            Console.WriteLine("0");

            for (int i = 0; i < 30; i++)
            {
                soma = valor1 + valor2;
                valor1 = valor2;
                valor2 = soma;

                Console.WriteLine(soma);
                
               
            }
           
            Console.ReadLine();
        }
    }
}
