using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class FornecedorController
    {

        public static List<Fornecedor> Fornecedores = new List<Fornecedor>();
        static int ultimoID = 0;


        public void SalvarFornecedor(Fornecedor fornecedor)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            fornecedor.PessoaID = id;
            Fornecedores.Add(fornecedor);
        }

        public Fornecedor PesquisarFornecedorPorNome(string nome)
        {
            var f =
                from x in Fornecedores
                where x.Nome.ToLower().Equals(nome.Trim().ToLower())
                select x;

            //retorna uma lista
            if (f != null)
                return f.FirstOrDefault();
            else
                return null;

        }

        public Fornecedor PesquisarFornecedorPorId(int idFornecedor)
        {

            var f =
                from x in Fornecedores
                where x.PessoaID.Equals(idFornecedor)
                select x;

            if (f != null)
                return f.FirstOrDefault();
            else
                return null;

        }

        public void ExcluirFornecedor(int idFornecedor)
        {
            Fornecedor fornec = PesquisarFornecedorPorId(idFornecedor);

            if (fornec != null)
                Fornecedores.Remove(fornec);

        }


        public List<Fornecedor> ListarFornecedor()
        {
            return Fornecedores;
        }


        public void EditarFornecedor(int idFornecedor)
        {

            Fornecedor entreg = PesquisarFornecedorPorId(idFornecedor);

        }



    }
}
