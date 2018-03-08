using Controllers;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    class Program
    {
        enum OpcoesMenuPricipal      //enumerador funciona como o case 1,2,... usado em conjunto no switch
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
            Console.WriteLine("4 - Excluir Cliente");

            Console.WriteLine("- Geral -");
            Console.WriteLine("5 - Limpar Tela");
            Console.WriteLine("6 - Sair da Tela");            
            
            
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
                        Cliente c = CadastrarCliente();

                        ClienteController cc = new ClienteController();
                        cc.SalvarCliente(c);


                        ExibirDadosCliente(c);
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
            

        }

        private static Cliente CadastrarCliente()  // esta função cadastrarcliente deveria ir para o controller, porém em virtude do "Console" não é possivel migra-la
                                                    //sera ajustada qdo do projeto em WPF
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


        private static void ExibirDadosCliente(Cliente cliente)

        {
            Console.Write("---DADOS CLIENTE---");
            Console.WriteLine();                //pula linha
            Console.Write(cliente.PessoaID);
            Console.WriteLine();
            Console.Write(cliente.Nome);
            Console.WriteLine();
            Console.Write(cliente.Cpf);
            Console.WriteLine();

            Console.Write("---ENDEREÇO---");
            Console.WriteLine();
            Console.Write(cliente._Endereco.Rua);
            Console.WriteLine();
            Console.Write(cliente._Endereco.Numero);
            Console.WriteLine();
            Console.Write(cliente._Endereco.Complemento);
            
            Console.WriteLine();
            Console.WriteLine();

        }




        private static Cliente PesquisarCliente()
        {
            return new Cliente();
        }




    }
}
