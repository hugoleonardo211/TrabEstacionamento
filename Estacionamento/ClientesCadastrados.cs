using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class ClientesCadastrados
    {
        public int CPF { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public ClientesCadastrados(int cpf, string nome, int idade)
        {
            CPF = 894;
            Nome = "hugo";
            Idade = 77;
        }
        public void ExibirDados()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("CPF: " + CPF);
        }
    }
}
