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
            ExcluirCliente = 4,
            ListarCliente = 5,

                       
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
                        EditarClientes();
                        break;
                    case OpcoesMenuPricipal.ExcluirCliente:
                        ExcluirCliente();
                        break;
                    case OpcoesMenuPricipal.ListarCliente:
                        ListarTodosClientes();
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

        // OK

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

            Endereco end = CadastrarEndereco();

            cli.EnderecoID = end.EnderecoID;
            
            return cli;

        }

        // OK
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

            ExibirDadosEndereco(cliente.EnderecoID);
            

            Console.WriteLine();
            Console.WriteLine();

        }


        // OK
        private static void ExcluirCliente()
        {
            Console.WriteLine("Digite o id do cliente que deseja excluir:");
            int idCliente = int.Parse(Console.ReadLine());

            ClienteController cc = new ClienteController();
            cc.ExcluirCliente(idCliente);               


        }

        // OK
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

        // OK
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


        // Ver dados cliente

        // OK
        private static void EditarClientes()
        {
            Console.WriteLine();
            Console.Write(" --- Editar os dados do Cliente --- ");

            int idCliente;
            ListarTodosClientes();            

            
            Console.WriteLine();
            Console.Write(" Digite o ID do Cliente --- ");
            Console.WriteLine();

            idCliente = int.Parse(Console.ReadLine());
            ClienteController cc = new ClienteController();

            Cliente cli = new Cliente();

            
            
                Console.WriteLine("Digite o nome desejado");
                cli.Nome = Console.ReadLine();

                Console.WriteLine("Digite o cpf desejado");
                cli.Cpf = Console.ReadLine();

                Endereco e = AlterarEndereco(cli.EnderecoID);

                cc.EditarCliente(idCliente, cli);

                
                if (cli != null)
                {
                    Console.WriteLine("Digite o nome desejado");
                    cli.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o cpf desejado");
                    cli.Cpf = Console.ReadLine();

                    Endereco e = AlterarEndereco(cli.EnderecoID);
                }
                else
                {
                    Console.WriteLine("Cliente não encontrado");
                }

            }
           
       

             // OK
            private static Endereco AlterarEndereco (int id)
            {
            EnderecoController ec = new EnderecoController();
            Endereco e = ec.PesquisarEnderecoPorId(id);

            Console.WriteLine("Informe o nome da rua: ");
            e.Rua = Console.ReadLine();

            Console.WriteLine("Informe o número: ");
            e.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o complemento: ");
            e.Complemento = Console.ReadLine();

            return e;

        }

        // OK
        private static Endereco CadastrarEndereco()

        {
            Endereco end = new Endereco();

            Console.Write("Digite a Rua: ");
            end.Rua = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite o Número: ");
            end.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o Complemento:");
            end.Complemento = Console.ReadLine();
            Console.WriteLine();

            EnderecoController ec = new EnderecoController();
            ec.SalvarEndereco(end);
            return end;

        }

        // OK
        private static void ExibirDadosEndereco(int ID)

        {
            EnderecoController ec = new EnderecoController();
            Endereco e = ec.PesquisarEnderecoPorId(ID);


            Console.Write("---ENDEREÇO---");
            Console.WriteLine();
            Console.Write(e.Rua);
            Console.WriteLine();
            Console.Write(e.Numero);
            Console.WriteLine();
            Console.Write(e.Complemento);

            Console.WriteLine();
            Console.WriteLine();

        }

         
        

    }
}
