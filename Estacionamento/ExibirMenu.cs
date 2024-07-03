using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
  public class ExibirMenu
    {
        public int Id { get; set; }
        public int Idade { get; set; }
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public int resposta { get; set; }
        
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
                resposta= int.Parse(Console.ReadLine());
                
                if(resposta == 1)
                {
                    Console.WriteLine("Ok,vamos aplicar seu desconto no valor final.");
                }
                else if(resposta == 2)
                {
                    Console.WriteLine("Ok, você nao tera o desconto final.");
                }

            }
            else if(resposta == 2){
               
                Console.WriteLine(" Vamos se cadastrar.");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" Digite seu nome.");
                Nome = Console.ReadLine();
                Console.WriteLine(" Qual sua Idade.");
                Idade = int.Parse(Console.ReadLine());
                Console.WriteLine(" Digite seu CPF.");
              Cpf= int.Parse(Console.ReadLine());
                Console.WriteLine(" Qual a ID do seu cadastro.");
                Id= int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------");
            } 
        }
        public void Editar()
        {
            Console.WriteLine("------------DESEJA EDITAR ALGO-------------");
            Console.WriteLine("ID:" + Id);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Qual campo deseja atualizar?");
            int campo = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Novo valor para o campo?");
            string respostaC = Console.ReadLine();
          
            


            Console.WriteLine("--------CADASTRO REALIZADO---------");
            Console.WriteLine("ID:" +Id);
            Console.WriteLine("Nome: "+Nome);
            Console.WriteLine("Idade: "+Idade);
            Console.WriteLine("CPF: "+Cpf);
            Console.WriteLine("-----------------");

            

          
        }
     }
     }

