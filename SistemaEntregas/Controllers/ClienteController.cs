using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ClienteController
    {

        public static List<Cliente> MeusClientes = new List<Cliente>();
        static int ultimoID = 0;
        
        
        public void SalvarCliente(Cliente cliente)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            cliente.PessoaID = id;
            MeusClientes.Add(cliente);
        }

        public Cliente PesquisarPorNome(string nome)
        {
            var c =
                from x in MeusClientes
                where x.Nome.ToLower().Equals(nome.Trim().ToLower())    //Trim - remove espaço em excesso, ToLower - converte tudo para minusculo, desta forma fica casesensitive.
                select x;                                               // Se trocar o Equals por Contains, a pequisa irá verificar por nome e sobrenome.

                                            //retorna uma lista
            if (c != null)
                return c.FirstOrDefault();
            else
                return null;

        }

        public Cliente PesquisarPorId(int idCliente)
        {

            var c =
                from x in MeusClientes
                where x.PessoaID.Equals(idCliente)    
                select x;                                               
            
            if (c != null)
                return c.FirstOrDefault();
            else
                return null;

        }

        public void ExcluirCliente(int idCliente)
        {
            Cliente cli = PesquisarPorId(idCliente);

            if (cli != null)
                MeusClientes.Remove(cli);

        }

    }
}
