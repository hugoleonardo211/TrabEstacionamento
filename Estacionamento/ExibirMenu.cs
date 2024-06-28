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

                Console.WriteLine("Deseja usar seu cupom de desconto? Se sim digite 1.\n");
                Console.WriteLine("Se não digite 2.");
                resposta2= int.Parse(Console.ReadLine());
                
                if(resposta2 == 1)
                {
                    Console.WriteLine("Ok,vamos aplicar seu desconto no valor final.");
                }
                else if(resposta2 == 2)
                {
                    Console.WriteLine("Ok, você nao tera o desconto final.");
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
