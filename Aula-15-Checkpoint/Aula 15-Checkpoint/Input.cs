using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_Checkpoint
{
    internal class Input
    {
        //private Convercao conversao;
        //public Imput()
        //{   
        //    this.convercao = new Conversao();
            
        //}
        public Conversao converter = new Conversao();

        public double resultado = 0;
        public void EscolherMoeda()
        {
            string opcao = "";
            do
            {
                
                

                    Console.WriteLine("");
                    Console.WriteLine("1 - Dolar");
                    Console.WriteLine("2 - Euro");
                    Console.WriteLine("3 - Iene");
                    Console.WriteLine("4 - Libra");
                    Console.WriteLine("5 - Sair da Convercao");
                    Console.WriteLine("");
                    Console.Write("Para qual moeda deseja converter?" + Environment.NewLine + ">");
                    opcao = Console.ReadLine();
                
         

                Conversao operacao = null;


                    switch (opcao)
                    {
                        case "1":
                            operacao = new Conversao();
                            break;
                        case "2":
                            operacao = new Conversao();
                            break;
                        case "3":
                            operacao = new Conversao();
                            break;
                        case "4":
                            operacao = new Conversao();
                            break;
                        default:
                            Console.WriteLine("Programa encerrado.");
                            break;
                    }

                    if (operacao != null)
                    {
                        operacao.convertendo(opcao);
                        Console.WriteLine("alguma coisa");

                    }
                

            } while (opcao != "5");

        }
    }
}
