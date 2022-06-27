using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula15
{
    public class Moeda
    {
        public Moeda(string nome, decimal valor, CultureInfo regiao)
        {
            Nome = nome;
            Valor = valor;
            Regiao = regiao;
        }
        public string Nome { get; set; }
        public decimal Valor { get; set; }    

        public CultureInfo Regiao;

    }
}
