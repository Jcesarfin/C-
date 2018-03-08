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
        
        
        public void SalvarCliente(Cliente cliente)
        {
            // todo: Persistir os dados do cliente
            MeusClientes.Add(cliente);
        }

    }
}
