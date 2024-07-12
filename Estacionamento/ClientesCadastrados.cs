using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class ClientesCadastrados
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public ClientesCadastrados(string cpf, string nome, int idade)
        {
            CPF = cpf;
            Nome = nome;
            Idade = idade;
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
