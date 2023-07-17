using System;

namespace HamburguerBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            HamburguerBuilder hamburguerBuilder = new HamburguerBuilder();

            //X-Salada
            var xSalada =
                hamburguerBuilder
                .SetTipoPao("Branco")
                .SetTipoCarne("Bovina")
                .TemSalada()
                .Buid();

            hamburguerBuilder = new HamburguerBuilder();
            //X-Bacon
            var xBacon =
                hamburguerBuilder
                .SetTipoPao("Americano")
                .SetTipoCarne("Bovina")
                .TemBacon()
                .TemQueijo()
                .Buid();

            hamburguerBuilder = new HamburguerBuilder();
            //X-Tudo
            var xTudo =
                hamburguerBuilder
                .SetTipoPao("Italiano")
                .SetTipoCarne("Bovina")
                .TemBacon()
                .TemSalada()
                .TemQueijo()
                .Buid();

            Console.WriteLine(xSalada.getDescricao());
            Console.WriteLine("=============================================================================");
            Console.WriteLine(xBacon.getDescricao());
            Console.WriteLine("=============================================================================");
            Console.WriteLine(xTudo.getDescricao());

           
        }
    }
}
