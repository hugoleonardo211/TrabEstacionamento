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
            FuncionariosMarketing.Add(new Marketing(1, "Paulo", 24, 1500));
            FuncionariosMarketing.Add(new Marketing(1, "Vinicius", 24, 1600));
            FuncionariosMarketing.Add(new Marketing(1, "Samuel", 24, 1100));

        }
    }
}
