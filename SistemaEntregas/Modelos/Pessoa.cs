using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class Pessoa      // pessoa é uma classe abstrata porque não pode criar um generico e sim como cliente, um fornecedor ou entrregador.
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        //relacionamento com a classe endereço
        public int EnderecoID { get; set; }
        public Endereco _Endereco { get; set; }     


    }
}
