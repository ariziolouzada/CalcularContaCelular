using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularContaCelular
{
    public class Conta
    {        

        //Propriedades
        public int QuantidadeMinutos { get; set; }
        public int TipoConta { get; set; }
        public decimal Total { get; set; }


        public Conta()
        {

        }

        public Conta(int quantidadeMinutos, int tipoConta)
        {
            QuantidadeMinutos = quantidadeMinutos;
            TipoConta = tipoConta;
        }
        


        //public static decimal CalculaValorCelular(int qtdeMinutos)
        //{
        //    decimal resultado = 0;

        //    if (qtdeMinutos <= 30)
        //        resultado = qtdeMinutos * VALOR_MIN_CEL;
        //    else
        //        resultado = qtdeMinutos * VALOR_PROM_MIN_CEL;

        //    return resultado;
        //}


        //public static decimal CalculaValorInterurbano(int qtdeMinutos)
        //{
        //    decimal resultado = 0;

        //    if (qtdeMinutos <= 30)
        //        resultado = qtdeMinutos * VALOR_MIN_INTERURBANO;
        //    else
        //        resultado = qtdeMinutos * VALOR_PROM_MIN_INTERURBANO;

        //    return resultado;
        //}

    }
}
