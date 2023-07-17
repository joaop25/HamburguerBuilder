using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburguerBuilder
{
    public class HamburguerBuilder
    {
        private readonly Hamburguer _hamburguer;

        public HamburguerBuilder()
        {
            _hamburguer = new Hamburguer();
        }

        public HamburguerBuilder SetTipoPao(string pao)
        {
            _hamburguer.TipoPao = pao;
            return this;
        }

        public HamburguerBuilder SetTipoCarne(string carne)
        {
            _hamburguer.TipoCarne = carne;
            return this;
        }

        public HamburguerBuilder TemBacon()
        {
            _hamburguer.TemBacon = true;
            return this;
        }

        public HamburguerBuilder TemBatataPalha()
        {
            _hamburguer.TemBatataPalha = true;
            return this;
        }

        public HamburguerBuilder TemQueijo()
        {
            _hamburguer.TemQueijo = true;
            return this;
        }

        public HamburguerBuilder TemSalada()
        {
            _hamburguer.TemSalada = true;
            return this;
        }

        //Vai voltar uma instancia de _hamburguer
        public Hamburguer Buid() => _hamburguer;

    }
}
