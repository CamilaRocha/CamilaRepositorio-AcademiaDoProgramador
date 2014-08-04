using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.OrientaçãoAObjetos.ExerciciosFixação
{
    class TestaCliente
    {
        public static void Main()
        {
            Cliente c1 = new Cliente();
            c1.nome = "Camila Silva";
            c1.codigo = 1;

            Cliente c2 = new Cliente();
            c2.nome = "Diego Sperandio";
            c2.codigo = 2;

            Console.WriteLine(c1.nome);
            Console.WriteLine(c1.codigo);

            Console.WriteLine(c2.nome);
            Console.WriteLine(c2.codigo);

            Console.ReadLine();
        }
    }
}
