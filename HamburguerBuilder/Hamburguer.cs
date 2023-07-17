using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburguerBuilder
{
    public class Hamburguer
    {
        public string TipoPao { get; set; }
        public string TipoCarne { get; set; }
        public bool TemBacon { get; set; }
        public bool TemBatataPalha { get; set; }
        public bool TemQueijo { get; set; }
        public bool TemSalada { get; set; }


        public string getDescricao()
        {
            return $"Hambúguer com pão {TipoPao}" +
                $" e carne {TipoCarne}," +
                $" e Bacon {TemBacon}," +
                $" e Batata {TemBatataPalha}," +
                $" e Queijo {TemQueijo}," +
                $" e Salada {TemSalada}.";
        }

    }
}
