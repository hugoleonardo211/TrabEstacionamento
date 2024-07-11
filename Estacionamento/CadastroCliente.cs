using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Estacionamento
{
  public class CadastroCliente
    {

        public void Editar()
        {
            Console.WriteLine("------------DESEJA EDITAR ALGO-------------");
            Listar();
            Console.WriteLine("Deseja editar algum dos dados?\nSe sim digite 1\nSe nao digite 2.");
            int dado = int.Parse(Console.ReadLine());

            if (dado > 2 || dado <= 0)
            {
                Editar();
            }

            if (dado == 1)
            {
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("Digite 1 para editar Nome.");
                Console.WriteLine("Digite 2 para editar Idade.");
                Console.WriteLine("Digite 3 para editar CPF.");
                string respostaA = Console.ReadLine();
                if (respostaA == "1")
                {
                    Console.WriteLine("Digite o novo Nome que deseja.");
                    string respostac = Console.ReadLine();
                    respostaC = respostac;


                    Console.WriteLine("--------CADASTRO REALIZADO---------");
                    Console.WriteLine("Nome: " + respostaC);
                    Console.WriteLine("Idade: " + Idade);
                    Console.WriteLine("CPF: " + Cpf);
                    Console.WriteLine("-----------------------------------");
                }
                else if (respostaA == "2")
                {
                    Console.WriteLine("Digite a nova Idade que deseja.");
                    string respostac = Console.ReadLine();
                    respostaC = respostac;

                    Console.WriteLine("--------CADASTRO REALIZADO---------");
                    Console.WriteLine("Nome: " + Nome);
                    Console.WriteLine("Idade: " + respostaC);
                    Console.WriteLine("CPF: " + Cpf);
                    Console.WriteLine("-----------------------------------");
                }
                else if (respostaA == "3")
                {
                    Console.WriteLine("Digiite o novo CPF que deseja.");
                    string respostac = Console.ReadLine();
                    respostaC = respostac;

                    Console.WriteLine("--------CADASTRO REALIZADO---------");
                    Console.WriteLine("Nome: " + Nome);
                    Console.WriteLine("Idade: " + Idade);
                    Console.WriteLine("CPF: " + respostaC);
                    Console.WriteLine("-----------------------------------");

                }


            }

            else if (dado == 2)
            {
                Console.WriteLine("--------CADASTRO REALIZADO---------");
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("Idade: " + Idade);
                Console.WriteLine("CPF: " + Cpf);
                Console.WriteLine("-----------------");
            }
        }
}
