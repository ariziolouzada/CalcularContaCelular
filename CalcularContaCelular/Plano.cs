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

            var servicos = new List<Servico>();

            if (this.Promocao == null)
            {
                servicos.Add(new Servico("Assinatura", 1, this.ValorAssinatura));
                servicos.Add(new Servico("Fixo", consumo.MinutosParaFixo, this.ValorParaFixo));
                servicos.Add(new Servico("Celular", consumo.MinutosParaCelular, this.ValorParaCelular));
                servicos.Add(new Servico("Interurbano", consumo.MinutosParaInterurbano, this.ValorParaInterurbano));
            }
            else
            {
                var fixoPromocional = consumo.MinutosParaFixo > 30 ? : 0; 

            }

            conta.Total = servicos.Sum(s => s.ObterTotal());

            return conta;
        }

        public decimal Calc(decimal valor, int minutos)
        {
            return valor * minutos;
        }

    }
}
