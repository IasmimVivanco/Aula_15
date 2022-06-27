using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula_15_Checkpoint
{
    internal class Conversao
    {
        private ListaDeMoedas lm = new ListaDeMoedas();

        public void convertendo(string opcao)

        {
            try
            {
                Console.Write($"Quantos reais deseja converter?" + Environment.NewLine + ">");
                double valorReal = double.Parse(Console.ReadLine());

                if (lm.moedas.ContainsKey(double.Parse(opcao)))
                {
                    double resultado = valorReal * lm.moedas[double.Parse(opcao)];
                    Console.WriteLine($"Valor convertido será de:{resultado}");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Digite um valor valido.");
            }


        }



    }

}

