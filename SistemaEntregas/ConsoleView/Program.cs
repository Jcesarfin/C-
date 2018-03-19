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
            ListarCliente = 5,

            CadastrarEntregador = 11,
            PesquisarEntregador = 12,
            EditarEntregador = 13,
            ExclucirEntregador = 14,
            ListarEntregador = 15,

            CadastrarFornecedor = 21,
            PesquisarFornecedor = 22,
            EditarFornecedor = 23,
            ExclucirFornecedor = 24,
            ListarFornecedor = 25,


            LimparTela = 6,
            Sair = 7,

        }

        
        private static OpcoesMenuPricipal Menu()
        {
            Console.WriteLine("Escolha sua opção");
            Console.WriteLine("");

            Console.WriteLine(" - Cliente - ");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("4 - Excluir Cliente");
            Console.WriteLine("5 - Listar Clientes");
            Console.WriteLine("");
            Console.WriteLine(" - Entregador - ");
            Console.WriteLine("11 - Cadastrar Entregador");
            Console.WriteLine("12 - Pesquisar Entregador");
            Console.WriteLine("13 - Editar Entregador");
            Console.WriteLine("14 - Excluir Entregador");
            Console.WriteLine("15 - Listar Entregador");
            Console.WriteLine("");
            Console.WriteLine(" - Fornecedor - ");
            Console.WriteLine("21 - Cadastrar Fornecedor");
            Console.WriteLine("22 - Pesquisar Fornecedor");
            Console.WriteLine("23 - Editar Fornecedor");
            Console.WriteLine("24 - Excluir Fornecedor");
            Console.WriteLine("25 - Listar Fornecedor");

            Console.WriteLine("");
            Console.WriteLine("- Geral -");
            Console.WriteLine("6 - Limpar Tela");
            Console.WriteLine("7 - Sair da Tela");            
            
            
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
                        EditarDadosClientes();
                        break;
                    case OpcoesMenuPricipal.ExclucirCliente:
                        ExcluirCliente();
                        break;
                    case OpcoesMenuPricipal.ListarCliente:
                        ListarTodosClientes();
                        break;

                    case OpcoesMenuPricipal.CadastrarEntregador:
                        Entregador e = CadastrarEntregador();
                        EntregadorController ee = new EntregadorController();
                        ee.SalvarEntregador(e);
                        ExibirDadosEntregador(e);
                        break;
                    case OpcoesMenuPricipal.PesquisarEntregador:
                        PesquisarEntregador();
                        break;
                    case OpcoesMenuPricipal.EditarEntregador:
                        EditarDadosEntregador();
                        break;
                    case OpcoesMenuPricipal.ExclucirEntregador:
                        ExcluirEntregador();
                        break;
                    case OpcoesMenuPricipal.ListarEntregador:
                        ListarTodosEntregadores();
                        break;

                    case OpcoesMenuPricipal.CadastrarFornecedor:
                        Fornecedor f = CadastrarFornecedor();
                        FornecedorController ff = new FornecedorController();
                        ff.SalvarFornecedor(f);
                        ExibirDadosFornecedor(f);
                        break;
                    case OpcoesMenuPricipal.PesquisarFornecedor:
                        PesquisarFornecedor();
                        break;
                    case OpcoesMenuPricipal.EditarFornecedor:
                        EditarDadosFornecedor();
                        break;
                    case OpcoesMenuPricipal.ExclucirFornecedor:
                        ExcluirFornecedor();
                        break;
                    case OpcoesMenuPricipal.ListarFornecedor:
                        ListarTodosFornecedores();
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

        private static void ExcluirCliente()
        {
            Console.WriteLine("Digite o id do cliente que deseja excluir:");
            int idCliente = int.Parse(Console.ReadLine());

            ClienteController cc = new ClienteController();
            cc.ExcluirCliente(idCliente);

           
        }


        private static void PesquisarCliente()
        {
            Console.Write("Digite o nome do cliente:");
            string nomeCliente = Console.ReadLine();

            ClienteController cc = new ClienteController();
            Cliente cli = cc.PesquisarPorNome(nomeCliente);


            if (cli != null)
                ExibirDadosCliente(cli);
            else
                Console.WriteLine(" * Cliente não encontrado");            
          
        }

        private static void ListarTodosClientes()
        {

            Console.WriteLine();
            Console.Write(" --- Clientes cadastrados --- ");
            Console.WriteLine();

            ClienteController cc = new ClienteController();
            List<Cliente> lista = cc.ListarClientes();

            if (lista.Count == 0)
            {
                Console.WriteLine(" * Ainda não há Clientes cadastrados ");
            }
            else {

                foreach (Cliente cli in lista)
                {
                    ExibirDadosCliente(cli);
                }
                Console.WriteLine();
            }
        }

        private static void EditarDadosClientes()
        {
            Console.WriteLine();
            Console.Write(" --- Editar os dados do Cliente --- ");
            Console.WriteLine();

            ClienteController cc = new ClienteController();
           // cc.EditarCliente(p)




        }


        private static Entregador CadastrarEntregador()  
                                                   
        {
            Entregador entre = new Entregador();

            Console.Write("Digite o nome:");
            entre.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite o CPF:");
            entre.Cpf = Console.ReadLine();
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

            entre._Endereco = end;

            return entre;

        }


        private static void ExibirDadosEntregador(Entregador entregador)

        {
            Console.Write("---DADOS ENTREGADOR---");
            Console.WriteLine();                //pula linha
            Console.Write(entregador.PessoaID);
            Console.WriteLine();
            Console.Write(entregador.Nome);
            Console.WriteLine();
            Console.Write(entregador.Cpf);
            Console.WriteLine();

            Console.Write("---ENDEREÇO---");
            Console.WriteLine();
            Console.Write(entregador._Endereco.Rua);
            Console.WriteLine();
            Console.Write(entregador._Endereco.Numero);
            Console.WriteLine();
            Console.Write(entregador._Endereco.Complemento);

            Console.WriteLine();
            Console.WriteLine();

        }

        private static void ExcluirEntregador()
        {
            Console.WriteLine("Digite o id do entregador que deseja excluir:");
            int idEntregador = int.Parse(Console.ReadLine());

            EntregadorController ee = new EntregadorController();
            ee.ExcluirEntregador(idEntregador);


        }


        private static void PesquisarEntregador()
        {
            Console.Write("Digite o nome do entregador:");
            string nomeEntregador = Console.ReadLine();

            EntregadorController ee = new EntregadorController();
            Entregador entre = ee.PesquisarEntregadorPorNome(nomeEntregador);


            if (entre != null)
                ExibirDadosEntregador(entre);
            else
                Console.WriteLine(" * Entregador não encontrado");

        }

        private static void ListarTodosEntregadores()
        {

            Console.WriteLine();
            Console.Write(" --- Entregadores cadastrados --- ");
            Console.WriteLine();

            EntregadorController ee = new EntregadorController();
            List<Entregador> lista = ee.ListarEntregador();

            if (lista.Count == 0)
            {
                Console.WriteLine(" * Ainda não há Entrregadores cadastrados ");
            }
            else
            {

                foreach (Entregador entre in lista)
                {
                    ExibirDadosEntregador(entre);
                }
                Console.WriteLine();
            }
        }

        private static void EditarDadosEntregador()
        {
            Console.WriteLine();
            Console.Write(" --- Editar os dados do Cliente --- ");
            Console.WriteLine();

            EntregadorController cc = new EntregadorController();
            //cc.EditarEntregador(p)

            
        }

        private static Fornecedor CadastrarFornecedor()

        {
            Fornecedor forne = new Fornecedor();

            Console.Write("Digite o nome:");
            forne.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite o CPF:");
            forne.Cpf = Console.ReadLine();
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

            forne._Endereco = end;

            return forne;

        }


        private static void ExibirDadosFornecedor(Fornecedor fornecedor)

        {
            Console.Write("---DADOS FORNECEDOR---");
            Console.WriteLine();                //pula linha
            Console.Write(fornecedor.PessoaID);
            Console.WriteLine();
            Console.Write(fornecedor.Nome);
            Console.WriteLine();
            Console.Write(fornecedor.Cpf);
            Console.WriteLine();

            Console.Write("---ENDEREÇO---");
            Console.WriteLine();
            Console.Write(fornecedor._Endereco.Rua);
            Console.WriteLine();
            Console.Write(fornecedor._Endereco.Numero);
            Console.WriteLine();
            Console.Write(fornecedor._Endereco.Complemento);

            Console.WriteLine();
            Console.WriteLine();

        }

        private static void ExcluirFornecedor()
        {
            Console.WriteLine("Digite o id do fornecedor que deseja excluir:");
            int idFornecedor = int.Parse(Console.ReadLine());

            FornecedorController ff = new FornecedorController();
            ff.ExcluirFornecedor(idFornecedor);


        }


        private static void PesquisarFornecedor()
        {
            Console.Write("Digite o nome do fornecedor:");
            string nomeFornecedor = Console.ReadLine();

            FornecedorController ff = new FornecedorController();
            Fornecedor forne = ff.PesquisarFornecedorPorNome(nomeFornecedor);


            if (forne != null)
                ExibirDadosFornecedor(forne);
            else
                Console.WriteLine(" * Fornecedor não encontrado");

        }

        private static void ListarTodosFornecedores()
        {

            Console.WriteLine();
            Console.Write(" --- Fornecedores cadastrados --- ");
            Console.WriteLine();

            FornecedorController ff = new FornecedorController();
            List<Fornecedor> lista = ff.ListarFornecedor();

            if (lista.Count == 0)
            {
                Console.WriteLine(" * Ainda não há Fornecedores cadastrados ");
            }
            else
            {

                foreach (Fornecedor forne in lista)
                {
                    ExibirDadosFornecedor(forne);
                }
                Console.WriteLine();
            }
        }

        private static void EditarDadosFornecedor()
        {
            Console.WriteLine();
            Console.Write(" --- Editar os dados do Fornecedor --- ");
            Console.WriteLine();

            FornecedorController cc = new FornecedorController();
            //cc.EditarEntregador(p)


        }

    }
}
