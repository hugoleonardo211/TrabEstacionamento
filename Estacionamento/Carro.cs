using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Carro
    {

        // Propriedades do carro
        public int QuantidadeDePortas { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }

        // Método para solicitar e armazenar as informações do carro

        public void ExibirInformacoes()
        {
            Console.WriteLine("\nInformações do Carro:");
            Console.WriteLine($"Quantidade de Portas: {QuantidadeDePortas}");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
        }

        // Método para exibir as informações do carro
        public void SolicitarInformacoes()
        {
            Console.Write("Digite a quantidade de portas: ");
            QuantidadeDePortas = int.Parse(Console.ReadLine());

            Console.Write("Digite a placa do carro: ");
            Placa = Console.ReadLine();

            Console.Write("Digite o modelo do carro: ");
            Modelo = Console.ReadLine();

            Console.Write("Digite a cor do carro: ");
            Cor = Console.ReadLine();
        }



    }

}
