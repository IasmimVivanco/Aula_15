using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula15
{
    public class ConversorDeMoeda
    {
        // Criação dos Metodos com Valores da Moedas
        public decimal dolar = 4.50m;
        public decimal euro = 6.20m;
        public decimal iene = 0.052m;
        public decimal libra = 6.95m;
        public decimal real = 0.0m;

        // Criação Do Dicionario inteira e com o "Tipo" moeda
        public Dictionary<int, Moeda> moedas = new Dictionary<int, Moeda>();

        // Metodo para Cadastrar as Moedas de acordo com os Simbolos
        public void Cadastrar()
        {
            moedas.Add(1, new Moeda("Dolar", dolar, CultureInfo.CreateSpecificCulture("en-US")));
            moedas.Add(2, new Moeda("Euro", euro, CultureInfo.CreateSpecificCulture("en-PT")));
            moedas.Add(3, new Moeda("Iene", iene, CultureInfo.CreateSpecificCulture("en-JP")));
            moedas.Add(4, new Moeda("Libra esterlina", libra, CultureInfo.CreateSpecificCulture("en-GB")));
            moedas.Add(5, new Moeda("Real", real, CultureInfo.CreateSpecificCulture("en-BR")));
        }

        // Apresentação Inicial de acordo com o Horario 
        public void Apresentacao()
        {
            var hora = DateTime.Now; // Horário do Usuário
            string saudacao;
            if (hora.Hour < 12) //Condições para "saudacao" Receber
            {
                saudacao = "Bom dia";
            }
            else if (hora.Hour > 12 && hora.Hour < 18)
            {
                saudacao = "Boa tarde";
            }
            else
            {
                saudacao = "Boa noite";
            }
            // Exibir Mensagem de Boas-Vindas
            Console.WriteLine($"{saudacao}, seja bem vindo ao nosso conversor de moeda!");
            Console.WriteLine();
        }

        // Escolher Moeda com o "Tipo" Moeda
        public Moeda EscolherMoeda()
        {
            bool valorValido = false;
            foreach (var item in moedas) 
            {
                Console.WriteLine($"Digite {item.Key} para - {item.Value.Nome}");
            }
            
            // Tratamento de Erro (usuário irá digitar novamente o que deseja caso seja diferente do esperado)
            try
            {
                Console.WriteLine($"Digite 6 para encerrar o programa");
                int selecionarMoeda = int.Parse(Console.ReadLine());
                if (selecionarMoeda == 6) //Condição Digitada for 6
                {
                    Console.WriteLine("Programa encerrado, agradecemos a sua participação! ;D");
                    Environment.Exit(0); // Finalizar o Programa 
                }
                Console.WriteLine($"Você escolheu o {moedas[selecionarMoeda].Nome}");
                Console.WriteLine("------------------------------------");
                valorValido = true; 
                return moedas[selecionarMoeda];
            }
            catch (Exception)
            {
                Console.WriteLine("Digite uma opção valida!");
                return EscolherMoeda(); // Digitar Novamente Retornando "EscolherMoeda()"
            }
        }

        // Converção Da Moeda Escolhida
        public void ConverterMoeda() 
        {
            bool valorValido = false;
            do // Loop
            {
                Console.WriteLine("Qual moeda deseja converter?");
                var selecionarMoeda = EscolherMoeda();
                Console.WriteLine($"Para qual moeda deseja converter o {selecionarMoeda.Nome}");
                var selecionarMoeda2 = EscolherMoeda();
                do // Loop 
                {
                    try // Tratamento de Erro
                    {
                        Console.Write("Digite o valor a ser convertido: "); 
                        decimal Valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                        if (selecionarMoeda == moedas[5])// Condições de Converção  
                        {
                            Valor /= selecionarMoeda2.Valor;
                        }
                        else if (selecionarMoeda2 == moedas[5])
                        {
                            Valor *= selecionarMoeda.Valor;
                        }
                        else
                        {
                            Valor *= selecionarMoeda.Valor;
                            Valor /= selecionarMoeda2.Valor;
                        }
                        if (selecionarMoeda2 == moedas[3])
                        {
                            Console.WriteLine($"O valor de {selecionarMoeda.Nome} convertido para {selecionarMoeda2.Nome} é: {Valor.ToString("C3", selecionarMoeda2.Regiao)}");
                        }

                        else
                        {
                            Console.WriteLine($"O valor de {selecionarMoeda.Nome} convertido para {selecionarMoeda2.Nome} é: {Valor.ToString("C2", selecionarMoeda2.Regiao)}");
                        }
                        Console.WriteLine("------------------------------------");

                        valorValido = true;
                    }
                    catch (Exception) 
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("*** Digite um valor valido! ***");
                    }
                } while (!valorValido);

            } while (true);
        }
    }
}
