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
    Console.WriteLine("----------------------------------------------------");

    if (opcao == "1")
    {
        estacionamento.ExibirVagasDisponiveisPorTipo("Deficiente");
        Console.WriteLine("----------------------------------------------------");
    }
    else if (opcao == "2")
    {
        estacionamento.ExibirVagasDisponiveisPorTipo("Carro");
        Console.WriteLine("----------------------------------------------------");
    }
    else if (opcao == "3")
    {
        estacionamento.ExibirVagasDisponiveisPorTipo("Moto");
        Console.WriteLine("----------------------------------------------------");
    }
    else if (opcao == "4")
    {
        estacionamento.ExibirVagasDisponiveis();
        Console.WriteLine("----------------------------------------------------");
    }
    else if (opcao == "5")
    {
        estacionamento.ExibirVagasOcupadas();
        Console.WriteLine("----------------------------------------------------");
    }
    else if (opcao == "6")
    {
        Console.WriteLine("Se quiser ocupar uma vaga de Deficiente digite:  Vaga numero da vaga - Deficiente\nSe quiser ocupar uma vaga de Carro digite:  Vaga numero da vaga - Carro\nSe quiser ocupar uma vaga de Moto digite:  Vaga numero da vaga - Moto\n");
        string vaga = Console.ReadLine();
        estacionamento.OcuparVaga(vaga);
        Console.WriteLine("----------------------------------------------------");
    }
    else if (opcao == "7")
    {
        string vaga = Console.ReadLine();
        estacionamento.LiberarVaga(vaga);
        Console.WriteLine("----------------------------------------------------");
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


