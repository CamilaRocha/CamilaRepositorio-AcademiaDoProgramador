using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ExerciciosComplementares
{
    class JornadaDeTrabalho
    {
        /* 2) A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40 horas
         receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%. Escreva um algoritmo que leia
         o número de horas trabalhadas em um mês, o salário por hora e escreva o salário total do funcionário, que deverá 
         ser acrescido das horas extras, caso tenham sido trabalhadas (considere que o mês possua 4 semanas exatas). */

        static void Main2()
        {
            double horaSemanal, salarioPorHora;
            double salarioSemanal, salarioMensal = 0;


            Console.WriteLine("Qual o salário por hora? ");
            salarioPorHora = double.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Informe quantas horas trabalhadas nesta semana: ");
                horaSemanal = double.Parse(Console.ReadLine());
                Console.Clear();

                if (horaSemanal > 40)
                {
                    salarioSemanal = (salarioPorHora * horaSemanal) + (salarioPorHora * 0.5);
                }
                else
                {
                    salarioSemanal = salarioPorHora * horaSemanal;
                }

                salarioMensal += salarioSemanal;
            }
            Console.WriteLine(" O seu salario no mês será R$" + salarioMensal);
            Console.ReadLine();
        }
    }
}
