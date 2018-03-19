using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class EntregadorController
    {

        public static List<Entregador> Entregadores = new List<Entregador>();
        static int ultimoID = 0;


        public void SalvarEntregador(Entregador entregador)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            entregador.PessoaID = id;
            Entregadores.Add(entregador);
        }

        public Entregador PesquisarEntregadorPorNome(string nome)
        {
            var e =
                from x in Entregadores
                where x.Nome.ToLower().Equals(nome.Trim().ToLower())    
                select x;                                               
            
            //retorna uma lista
            if (e != null)
                return e.FirstOrDefault();
            else
                return null;

        }

        public Entregador PesquisarEntregadorPorId(int idEntregador)
        {

            var e =
                from x in Entregadores
                where x.PessoaID.Equals(idEntregador)
                select x;

            if (e != null)
                return e.FirstOrDefault();
            else
                return null;

        }

        public void ExcluirEntregador(int idEntregador)
        {
            Entregador entreg = PesquisarEntregadorPorId(idEntregador);

            if (entreg != null)
                Entregadores.Remove(entreg);

        }


        public List<Entregador> ListarEntregador()
        {

            return Entregadores;

        }


        public void EditarEntregador(int idEntregador)
        {

            Entregador entreg = PesquisarEntregadorPorId(idEntregador);



        }


    }
}
