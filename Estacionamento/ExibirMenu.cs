using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
  public class ExibirMenu
    {
        public int resposta { get; set; }
        public int resposta2 { get; set; } 
        public void Exibirmenu()
        {

            Console.WriteLine("Olá, Seja Bem-Vindo ao nosso estacionamento.\n");
            Console.WriteLine("Se você ja e nosso cliente, digite 1.\n");
            Console.WriteLine("Se você deseja se cadastrar digite 2.");
            resposta = int.Parse(Console.ReadLine());

            if (resposta < 1 || resposta > 2)
            {
                Console.WriteLine("Digite um número valído.\n");
            }

            else if (resposta == 1) {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Você tem direito a um cupom de 5%\n");
                Console.WriteLine("Se deseja ultilizar digite 1");
                Console.WriteLine("Se não digite 2.");
                resposta= int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------");

                if (resposta == 1)
                {
                    Console.WriteLine("Você tera seu cupom adicionado no cauculo final");
                }
                else if(resposta == 2)
                {
                    Console.WriteLine("Ok, o preço do estacionamento permanecera o mesmo");
                }

            }
            else if(resposta == 2){
                Console.WriteLine("Vamos se cadastrar.");
                Console.WriteLine("Digite seu nome.\n");
                Console.WriteLine(" Qual sua Idade.\n");
                Console.WriteLine(" Digite seu CPF.");
            }

        }
    }
}
