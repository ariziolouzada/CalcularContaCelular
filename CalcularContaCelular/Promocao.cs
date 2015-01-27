using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularContaCelular
{
    public class DescontoSobreConsumo
    {
        public string Nome { get; set; }
        public int ConsumoReferencia { get; set; }
        public decimal ValorMinutosParaFixo { get; set; }
        public decimal ValorMinutosParaCelular { get; set; }
        public decimal ValorMinutosParaInterurbano { get; set; }

        public DescontoSobreConsumo(string nome, decimal valorMinutosParaFixo, decimal valorMinutosParaCelular, decimal valorMinutosParaInterurbano)
        {
            this.Nome = nome;
            this.ValorMinutosParaFixo = valorMinutosParaFixo;
            this.ValorMinutosParaCelular = valorMinutosParaCelular;
            this.ValorMinutosParaInterurbano = valorMinutosParaInterurbano;
        }


    }
}
