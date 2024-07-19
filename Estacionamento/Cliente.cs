using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Cliente
    {

        public void Cadastro()
        {
            List<string> cpfsCadastrados = new List<string>
            {
                "12345678901",
                "23456789012",
                "34567890123"
            }; 

            string nome = string.Empty;
            string cpf = string.Empty;
            int idade = 0;




            Console.WriteLine("Você já possui um cadastro? (sim/não)");
            string resposta = Console.ReadLine().ToLower();


            if (resposta == "não" || resposta == "nao")
            {
                Console.WriteLine("Vamos fazer seu registro!");

                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.Write("Digite seu CPF: ");
                cpf = Console.ReadLine();

                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Registro completo!");
                cpfsCadastrados.Add(cpf);

                ExibirInformacoes(nome, cpf, idade);

                Console.WriteLine("Você gostaria de editar alguma informação? (sim/não)");
                string editar = Console.ReadLine().ToLower();

                if (editar == "sim")
                {
                    EditarInformacoes(ref nome, ref cpf, ref idade);
                    ExibirInformacoes(nome, cpf, idade);
                }
            }

            else if (resposta == "sim")
            {
                Console.Write("Digite seu CPF: ");
                cpf = Console.ReadLine();

                if (cpfsCadastrados.Contains(cpf))
                {
                    Console.WriteLine("Bem-vindo de volta!\n");
                }

                else
                {
                    Console.WriteLine("Você não está cadastrado tente novamente.\n");
                    Cadastro();

                }

            }




            static void ExibirInformacoes(string nome, string cpf, int idade)
            {
                Console.WriteLine("\nInformações do usuário:");
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"CPF: {cpf}");
                Console.WriteLine($"Idade: {idade}");
            }

            static void EditarInformacoes(ref string nome, ref string cpf, ref int idade)
            {
                Console.WriteLine("Qual informação você gostaria de editar?");
                Console.WriteLine("1. Nome");
                Console.WriteLine("2. CPF");
                Console.WriteLine("3. Idade");
                Console.WriteLine("Digite o número da opção que você deseja editar:");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o novo nome: ");
                        nome = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Digite o novo CPF: ");
                        cpf = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Digite a nova idade: ");
                        idade = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
