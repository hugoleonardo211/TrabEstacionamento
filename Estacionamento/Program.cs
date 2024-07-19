using Estacionamento;




Sobre sobre = new Sobre();

Moto m = new Moto();
Carro c = new Carro();

Cliente cliente = new Cliente();
cliente.Cadastro();




// Marcar o tempo de início
DateTime startTime = DateTime.Now;


Console.WriteLine("--------------------------------------------------------------------------------------------------------\n");
Console.WriteLine("Registro de Entrada e Saída do Usuario");

// Registrar entrada do veículo
sobre.RegistrarEntrada();
Console.WriteLine("\n");





string respostas = string.Empty;
Console.WriteLine("Qual seu tipo de veiculo Moto ou Carro");
respostas = Console.ReadLine();
if (respostas == "Moto" || respostas == "moto")
{
    m.SolicitarInformacoes();
    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    m.ExibirInformacoes();
    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
}
else if (respostas == "Carro" || respostas == "carro")
{
    c.SolicitarInformacoes();
    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    c.ExibirInformacoes();
    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
}



Estacionamentos estacionamento = new Estacionamentos(30);

while (true)
{

    Console.WriteLine("Digite 1 para exibir vagas para Deficiente.");
    Console.WriteLine("Digite 2 para exibir vagas para Carro.");
    Console.WriteLine("Digite 3 para exibir vagas para Moto.");
    Console.WriteLine("Digite 4 para exibir todas vagas disponiveis");
    Console.WriteLine("Digite 5 para exibir todas vagas ocupadas");
    Console.WriteLine("Digite 6 para ocupar uma vaga");
    Console.WriteLine("Digite 7 para liberar uma vaga");
    Console.WriteLine("Digite 8 para sair.");
    string opcao = Console.ReadLine();
    Console.WriteLine("--------------------------------------------------------------------------------------------------------");

    if (opcao == "1")
    {
        estacionamento.ExibirVagasDisponiveisPorTipo("Deficiente");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    }
    else if (opcao == "2")
    {
        estacionamento.ExibirVagasDisponiveisPorTipo("Carro");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    }
    else if (opcao == "3")
    {
        estacionamento.ExibirVagasDisponiveisPorTipo("Moto");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    }
    else if (opcao == "4")
    {
        estacionamento.ExibirVagasDisponiveis();
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    }
    else if (opcao == "5")
    {
        estacionamento.ExibirVagasOcupadas();
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    }
    else if (opcao == "6")
    {
        Console.WriteLine("Qual vaga deseja ocupar\nDeficiente = 1\nCarro = 2\nMoto = 3");
        int resposta = int.Parse(Console.ReadLine());
        string tipoVaga = string.Empty;
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        if (resposta == 1)
        {
            estacionamento.ExibirVagasDisponiveisPorTipo("Deficiente");
            tipoVaga = "Deficiente";

        }
        else if (resposta == 2)
        {
            estacionamento.ExibirVagasDisponiveisPorTipo("Carro");
            tipoVaga = "Carro";

        }
        else if (resposta == 3)
        {
            estacionamento.ExibirVagasDisponiveisPorTipo("Moto");
            tipoVaga = "Moto";

        }

        Console.WriteLine("\nAgora digite o nome da vaga que deseja ocupar");
        string vaga = Console.ReadLine();
        string formatada = $"Vaga {vaga} -{tipoVaga}";
        estacionamento.OcuparVaga(formatada);
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    }
    else if (opcao == "7")
    {

        Console.WriteLine("Qual vaga deseja liberar\nDeficiente = 1\nCarro = 2\nMoto = 3");
        int resposta = int.Parse(Console.ReadLine());
        string tipoVaga = string.Empty;
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        if (resposta == 1)
        {
            estacionamento.ExibirVagasOcupadas();
            tipoVaga = "Deficiente";

        }
        else if (resposta == 2)
        {
            estacionamento.ExibirVagasOcupadas();
            tipoVaga = "Carro";

        }
        else if (resposta == 3)
        {
            estacionamento.ExibirVagasOcupadas();
            tipoVaga = "Moto";

        }

        Console.WriteLine("\nDigite a vaga que deseja liberar");
        string vaga = Console.ReadLine();
        string formatada = $"Vaga {vaga} -{tipoVaga}";
        estacionamento.LiberarVaga(formatada);
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");


    }
    else if (opcao == "8")
    {
        // Confirmar e registrar saída do veículo
        bool result = sobre.ConfirmarSaida();
        if (result == true)
        {
            // Exibir informações
            sobre.ExibirInformacoes();

            // Marcar o tempo de fim
            DateTime endTime = DateTime.Now;

            // Informar ao usuário que o programa começou
            Console.WriteLine("Pressione qualquer tecla para finalizar e calcular o preço.");

            // Esperar que o usuário pressione uma tecla
            Console.ReadKey();



            // Calcular a diferença de tempo em minutos
            double totalMinutes = (endTime - startTime).TotalMinutes;

            // Calcular o preço total
            double price = totalMinutes * 2.0;

            // Mostrar o tempo total e o preço para o usuário
            Console.WriteLine($"Tempo total no programa: {totalMinutes:F2} minutos");
            Console.WriteLine($"Preço a ser pago: R${price:F2}");

            break;
        }
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
    }
}
