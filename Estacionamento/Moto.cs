using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Moto
    {

        // Propriedades da moto
        public int Cilindradas { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }

        // Método para solicitar e armazenar as informações da moto

        public void ExibirInformacoes()
        {
            Console.WriteLine("\nInformações da Moto:");
            Console.WriteLine($"Cilindardas da moto: {Cilindradas}");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
        }

        // Método para exibir as informações da moto 
        public void SolicitarInformacoes()
        {
            Console.Write("Digite a cilindardas da moto: ");
           Cilindradas = int.Parse(Console.ReadLine());

            Console.Write("Digite a placa da moto: ");
            Placa = Console.ReadLine();

            Console.Write("Digite o modelo da moto: ");
            Modelo = Console.ReadLine();

            Console.Write("Digite a cor da moto: ");
            Cor = Console.ReadLine();
        }



    }
}
