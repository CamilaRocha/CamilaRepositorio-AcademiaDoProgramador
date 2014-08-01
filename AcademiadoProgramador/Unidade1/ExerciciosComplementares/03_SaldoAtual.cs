using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosComplementares
{
    class SaldoAtual
    {
        /* 3) Faça um algoritmo para ler: número da conta do cliente, saldo, débito e crédito. Após, calcular e escrever o
         saldo atual (saldo atual = saldo - débito + crédito). Também testar se saldo atual for maior ou igual a zero
         escrever a mensagem 'Saldo Positivo', senão escrever a mensagem 'Saldo Negativo'. */

        static void Main3()
        {
            int numeroDaConta;
            double saldo, debito, credito, saldoAtual;

            Console.WriteLine("Numero da conta: ");
            numeroDaConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Saldo atual: ");
            saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Credito: ");
            credito = double.Parse(Console.ReadLine());
            Console.WriteLine("Debito: ");
            debito = double.Parse(Console.ReadLine());

            saldoAtual = saldo - debito + credito;
            Console.Clear();

            if (saldoAtual >= 0)
            {
                Console.WriteLine("Saldo Positivo!");
            }
            else
            {
                Console.WriteLine("Saldo Negativo!");
            }

            Console.ReadLine();
        }
    }
}
