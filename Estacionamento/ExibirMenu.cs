namespace Estacionamento
{
    public class ExibirMenu
    {
        public List<ClientesCadastrados> Clientes { get; private set; }
        public string respostaC { get; set; }
        public int Id { get; set; }
        public int Idade { get; set; }
        public int Cpf  { get; set; }
        public int acao { get; set; }   
    public string Nome { get; set; }
        public int resposta { get; set; }
        public ExibirMenu()
        {
            Clientes = new List<ClientesCadastrados>();
            AdClientes();
        }
        public void AdClientes()
        {
            Clientes.Add(new ClientesCadastrados(132,"Hugo",23));
            Clientes.Add(new ClientesCadastrados(155, "Vini", 60));
        }
        public void Listar()
        {
            foreach (ClientesCadastrados c in Clientes)
            {
                c.ExibirDados();
            }
        }
        public void Exibirmenu()
        {

            Console.WriteLine("Olá, Seja Bem-Vindo ao nosso estacionamento.\n");
            Console.WriteLine("Se você ja e nosso cliente, digite 1.");
            Console.WriteLine("Se você deseja se cadastrar digite 2.");
            resposta = int.Parse(Console.ReadLine());
        }

        public void RealizarCadastro()
        { 
            if (resposta < 1 || resposta > 2)
            {
                Console.WriteLine("Digite um número valído.\n");
                Exibirmenu();
            }

         else   if (resposta == 1)
            {
                Console.WriteLine("Digite seu CPF,para encontrarmos seu login.");
                resposta = int.Parse(Console.ReadLine());

                foreach (ClientesCadastrados m in Clientes)
                {
                    if (resposta == m.CPF)
                    {
                        Console.WriteLine("Ok, você ja e nosso clinete.");
                        Console.WriteLine("Você tera um desconto de 5% no valor final do estacionamento.\n");

                    }
                    else if (resposta != m.CPF)
                    {
                        Console.WriteLine("Login não encontrado");
                        RealizarCadastro();
                    }
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
    
   
        }
    }
}
   