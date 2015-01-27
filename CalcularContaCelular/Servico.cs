using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularContaCelular
{
    public class Servico
    {
        public string   Nome        { get; set; }
        public int      Quantidade  { get; set; }
        public decimal  Valor       { get; set; }


        public Servico( string nome, int quantidade, decimal valor)
        {
            Nome  = nome;    
            Quantidade = quantidade;
            Valor = valor;
        }

        public decimal ObterTotal()
        {
            return this.Valor * this.Quantidade;
        }


    }
}
