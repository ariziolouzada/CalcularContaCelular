using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularContaCelular.PlayGraud
{
    class Program
    {/*
      * CalcularContaCelular o valor da minha conta com base nos minutos para cada tipo de ligação,
      * com base nos valores de cada tipo.
      *         
      */

        static void Main(string[] args)
        {
            //Prototipação de código

            var consumo = new Consumo("Arizio", 1, 2 , 3);

            var plano = Plano("Smart", 0.10m, 0.35m, 0.75m, 30m);

            var promocao = new Promocao("Fale 30", 0.05m, 0.25m, 0.60m);

            plano.AdicionarPromocao(promocao);

            var conta = plano.

            //decimal total = 0;

            ////Calculo do valor da conta Fixa
            //Console.Write("ENTRE COM QUANTIDADE DE MINUTOS PARA FIXO: ");
            //var qtdeMinutosFixo = int.Parse(Console.ReadLine());

            //var valorContaFixa = Conta.CalculaValorFixo(qtdeMinutosFixo);
            //total = valorContaFixa;
            //Console.WriteLine("VALOR CONTA FIXA: " + valorContaFixa);

            ////Calculo do valor da conta Fixa
            //Console.Write("ENTRE COM QUANTIDADE DE MINUTOS PARA CELULAR: ");
            //var qtdeMinutosCelular = int.Parse(Console.ReadLine());
            //var valorContaCelular = Conta.CalculaValorCelular(qtdeMinutosCelular);
            //total = total + valorContaCelular;
            //Console.WriteLine("VALOR CONTA CELULAR: " + valorContaCelular);

            ////Calculo do valor da conta Fixa
            //Console.Write("ENTRE COM QUANTIDADE DE MINUTOS PARA INTERURBANO: ");
            //var qtdeMinutosInter = int.Parse(Console.ReadLine());
            //var valorContaInter = Conta.CalculaValorInterurbano(qtdeMinutosInter);
            //total = total + valorContaInter;
            //Console.WriteLine("VALOR CONTA INTERURBANO: " + valorContaInter);


            //Console.WriteLine();
            //Console.WriteLine("VALOR CONTA: " + total);


            Console.ReadLine();
        }

    }
}
