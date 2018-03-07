﻿using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    class Program
    {
        enum OpcoesMenuPricipal      //enumerador funciona como o case 1,2,... usado no switch
        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            ExclucirCliente = 4,
            LimparTela = 5,
            Sair = 6,

        }

        
        private static OpcoesMenuPricipal Menu()
        {
            Console.WriteLine("Escolha sua opção");
            Console.WriteLine("");

            Console.WriteLine(" - Cliente - ");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");

            Console.WriteLine("- Geral -");
            Console.WriteLine("4 - Limpar Tela");
            Console.WriteLine("5 - Sair da Tela");            
            
            
            string opcao = Console.ReadLine();
            return (OpcoesMenuPricipal)int.Parse(opcao);           
               

        }



        static void Main(string[] args)
        {
            OpcoesMenuPricipal opcaoDigitada = OpcoesMenuPricipal.Sair;
           
            do
            {
                opcaoDigitada = Menu();

                switch (opcaoDigitada)
                {
                    case OpcoesMenuPricipal.CadastrarCliente:
                        CadastrarCliente();
                        //ExibirDadosCliente();
                        break;
                    case OpcoesMenuPricipal.PesquisarCliente:
                        PesquisarCliente();
                        break;
                    case OpcoesMenuPricipal.EditarCliente:
                        break;
                    case OpcoesMenuPricipal.ExclucirCliente:
                        break;
                    case OpcoesMenuPricipal.LimparTela:
                        break;
                    case OpcoesMenuPricipal.Sair:
                        break;
                    default:
                        break;
                }               

            } while (opcaoDigitada != OpcoesMenuPricipal.Sair);


            Menu();
            Console.ReadKey();


           // List<Cliente> listaClientes = new List<Cliente>();
           // Cliente cli = new Cliente();
           // listaClientes.Add(cli); 


            

        }

        private static Cliente CadastrarCliente()

        {
            Cliente cli = new Cliente();

            Console.Write("Digite o nome:");
            cli.Nome = Console.ReadLine();
            Console.WriteLine();
           
            Console.Write("Digite o CPF:");
            cli.Cpf = Console.ReadLine();
            Console.WriteLine();

            Endereco end = new Endereco();

            Console.Write("Digite a Rua:"); ;
            end.Rua = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite o Número:"); ;
            end.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o Complemento:"); ;
            end.Complemento = Console.ReadLine();
            Console.WriteLine();

            cli._Endereco = end;

            return cli;

        }


        private static Cliente ExibirDadosCliente()

        {

            Cliente exib = CadastrarCliente();

            Console.Write(exib.Nome);
            Console.WriteLine();

            Console.Write(exib.Cpf);
            Console.WriteLine();

            Endereco end2 = new Endereco();

            Console.Write(end2.Rua);
            Console.WriteLine();

            Console.Write(end2.Numero);
            Console.WriteLine();

            Console.Write(end2.Complemento); 
            Console.WriteLine();

            exib._Endereco = end2;

            return exib;

        }




        private static Cliente PesquisarCliente()
        {
            return new Cliente();
        }




    }
}
