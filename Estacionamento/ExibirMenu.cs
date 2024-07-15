namespace Estacionamento
{
    public class ExibirMenu
    {
        public List<ClientesCadastrados> Clientes { get; private set; }
        public string respostaC { get; set; }
        public int Id { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
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
            Clientes.Add(new ClientesCadastrados("132", "Hugo", 23));
            Clientes.Add(new ClientesCadastrados("155", "Vini", 60));
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

            Console.WriteLine("<------- BEM VINDO AO ESTACIONAMENTO ------->");
            Console.WriteLine("1 - Logar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("0 - Sair do Sistema");
            Console.WriteLine("<-------------------------------->");

            resposta = int.Parse(Console.ReadLine());
        }

        public void RealizarCadastro()
        {
            if (resposta < 1 || resposta > 2)
            {
                Console.WriteLine("Digite um número valído.\n");
                Exibirmenu();
            }

            else if (resposta == 1)
            {
                return Login();
            }
            else if (resposta == 2)
            {
                {
                    Gerenciador.AdicionarUsuario();
                    return Login()
                }
            }

            private Usuario Login()
            {
                Console.WriteLine("<------------ LOGIN ------------>");
                bool verificacaoSenha = false;
                int id = 0;
                string senha = string.Empty;
                while (!verificacaoSenha)
                {
                    Console.WriteLine("Digite o número id da conta:");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a senha do login da conta:");
                    senha = Console.ReadLine();
                    if (Gerenciador.LoginSenha(senha, id))
                    {
                        Console.Clear();
                        Console.WriteLine("Login efetuado com sucesso.");
                        verificacaoSenha = true;
                    }
                    else
                    {
                        Console.WriteLine("Id ou Senha incorreto(s).");
                    }
                }
                Console.WriteLine("<------------------------------->");
                return Gerenciador.BuscarUsuario(senha, id);
            }
        }
    }
}