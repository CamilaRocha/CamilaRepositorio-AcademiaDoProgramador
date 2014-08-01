using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosComplementares
{
    class JogoDeXadrez
    {
        /* 1) Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os minutos)
         e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é de 24 horas e que o jogo
         pode iniciar em um dia e terminar no dia seguinte. */

        static void Main1()
        {
            
            int horaInicial, horaFinal, totalHoras;

            Console.WriteLine("Em que horas foi inicializado seu jogo?" );
            horaInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Em que horas foi o término? ");
            horaFinal = int.Parse(Console.ReadLine());
            totalHoras = horaInicial + horaFinal;

            Console.Clear();

            if (horaInicial == horaFinal)
            {
                Console.WriteLine("Tempo máximo de jogo atendido!");
            }
            else if (totalHoras > 24)
            {
                Console.WriteLine("Tempo de jogo esgotado!");
            }
            else
            {
                Console.WriteLine("Seu jogo durou: " + totalHoras + " horas");
            }
            Console.ReadLine();

        }
    }
}
