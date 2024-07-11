using Estacionamento;




//// Criar uma instância da classe Carro
//Carro meuCarro = new Carro();

//// Solicitar as informações do carro ao usuário
//meuCarro.SolicitarInformacoes();
//Console.WriteLine("------------------------------");

//// Exibir as informações do carro
//meuCarro.ExibirInformacoes();
//Console.WriteLine("------------------------------");



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
            tipoVaga= "Deficiente";
          
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
        string tipoVaga = string.Empty;

        Console.WriteLine("\nAgora digite o nome da vaga que deseja liberar");
        string vaga = Console.ReadLine();
        string formatada = $"Vaga {vaga} -{tipoVaga}"; 
        estacionamento.LiberarVaga(formatada);
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    }
    else if (opcao == "8")
    {
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
    }
}


//Console.WriteLine("Se quiser ocupar uma vaga de Deficiente digite o seguinte:  Vaga 1 a 10  - Deficiente\nExemplo: Vaga 1 - Deficiente\n\nSe quiser ocupar uma vaga de Carro digite o seguinte:  Vaga 11 a 20 - Carro\nExemplo: Vaga 11 - Carro\n\nSe quiser ocupar uma vaga de Moto digite o seguinte:  Vaga 21 a 30 - Moto\nExemplo: Vaga 21 - Moto\n");