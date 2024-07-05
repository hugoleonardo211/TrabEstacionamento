namespace Estacionamento
{
    public class ExibirMenu
    {
        public string respostaC { get; set; }
        public int Id { get; set; }
        public int Idade { get; set; }
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public int resposta { get; set; }

        public void Exibirmenu()
        {

            Console.WriteLine("Olá, Seja Bem-Vindo ao nosso estacionamento.\n");
            Console.WriteLine("Se você ja e nosso cliente, digite 1.");
            Console.WriteLine("Se você deseja se cadastrar digite 2.");
            resposta = int.Parse(Console.ReadLine());

            if (resposta < 1 || resposta > 2)
            {
                Console.WriteLine("Digite um número valído.\n");
            }

            else if (resposta == 1)
            {

                Console.WriteLine("Deseja usar seu cupom de desconto? Se sim digite 1.\n");
                Console.WriteLine("Se não digite 2.");
                resposta = int.Parse(Console.ReadLine());

                if (resposta == 1)
                {

                    Console.WriteLine("Ok,vamos aplicar seu desconto no valor final.");
                }
                else if (resposta == 2)
                {
                    Console.WriteLine("Ok, você nao tera o desconto final.");
                }

            }
            else if (resposta == 2)
            {

                Console.WriteLine(" Vamos se cadastrar.");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" Digite seu nome.");
                Nome = Console.ReadLine();
                Console.WriteLine(" Qual sua Idade.");
                Idade = int.Parse(Console.ReadLine());
                Console.WriteLine(" Digite seu CPF.");
                Cpf = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------");
            }
        }
        public void Editar()
        {
            Console.WriteLine("------------DESEJA EDITAR ALGO-------------");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Deseja editar algum dos dados?  Se sim digite 1/  Se nao digite 2.");
            int dado = int.Parse(Console.ReadLine());

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
}

