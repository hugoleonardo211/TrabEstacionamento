using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class ClientesCadastrados
    {
        public List<ClientesCadastrados> Cadastros { get; private set; }



        public ClientesCadastrados()
        {
            Cadastros = new List<ClientesCadastrados>();
            InicializarDados();
        }

        private void InicializarDados()
        {
            Cadastros.Add(new ClientesCadastrados());
            Cadastros.Add(new ClientesCadastrados());
            Cadastros.Add(new ClientesCadastrados());
            InicializarDados();

        }
    }
}
