using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class EnderecoController
    {
        public static List<Endereco> Enderecos = new List<Endereco>();
        static int ultimoID = 0;


        public void SalvarEndereco(Endereco end)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            end.EnderecoID = id;
            Enderecos.Add(end);
        }

        public Endereco PesquisarEnderecoPorId(int id)
        {
            var end =
                from x in Enderecos
                where x.EnderecoID.Equals(id)
                select x;

            //retorna uma lista
            if (end != null)
                return end.FirstOrDefault();
            else
                return null;

        }

        

        //public void ExcluirEndereco(int idEndereco)
        //{
        //    Endereco end = PesquisarEnderecoPorId(idEndereco);

          //  if (end != null)
             //   Enderecos.Remove(end);

       // }


        public List<Endereco> ListarEndereco()
        {
            return Enderecos;
        }


        //public void EditarEndereco(int idEndereco)
       // {

           // Endereco end = PesquisarEnderecoPorId(idEndereco);

       // }



    }
}
