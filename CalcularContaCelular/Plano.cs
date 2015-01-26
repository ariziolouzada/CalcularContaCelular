using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularContaCelular
{
    public class Plano
    {
        public string Usuario { get; set; }
        public decimal ValorParaFixo { get; set; }
        public decimal ValorParaCelular { get; set; }
        public decimal ValorParaInterurbano { get; set; }
        public decimal ValorAssinatura { get; set; }

        public Plano(string usuario, decimal valorParaFixo, decimal valorParaCelular, 
                        decimal valorParaInterurbano, decimal valorAssinatura)
        {
            Usuario = usuario;
            ValorParaFixo = valorParaFixo;
            ValorParaCelular = valorParaCelular;
            ValorParaInterurbano = valorParaInterurbano;
            ValorAssinatura = valorAssinatura;
        }



        public Conta CalcularConta(Consumo consumo)
        {
            var conta = new Conta();

            var valorFixo = this.Calc(ValorParaFixo, consumo.MinutosParaFixo);


            return conta;
        }

        public decimal Calc(decimal valor, int minutos)
        {
            return valor * minutos;
        }

    }
}
