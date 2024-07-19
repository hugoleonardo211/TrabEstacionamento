using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Estacionamentos
    {
        private int totalVagas;
        private List<string> vagasDisponiveis;
        private List<string> vagasOcupadas;

        public Estacionamentos(int totalVagas)
        {
            this.totalVagas = totalVagas;
            vagasDisponiveis = new List<string>();
            vagasOcupadas = new List<string>();
            InicializarVagas();
        }

        private void InicializarVagas()
        {
            // Adicionar 10 vagas para deficientes
            for (int i = 0; i < 10; i++)
            {
                vagasDisponiveis.Add($"Vaga {i + 1} -Deficiente");
            }

            // Adicionar 10 vagas para carros
            for (int i = 0; i < 10; i++)
            {
                vagasDisponiveis.Add($"Vaga {i + 11} -Carro");
            }

            // Adicionar 10 vagas para motos
            for (int i = 0; i < 10; i++)
            {
                vagasDisponiveis.Add($"Vaga {i + 21} -Moto");
            }
        }

        public void OcuparVaga(string vaga)
        {
            if (vagasDisponiveis.Contains(vaga))
            {
                vagasDisponiveis.Remove(vaga);
                vagasOcupadas.Add(vaga);
                Console.WriteLine($"{vaga} foi ocupada.");
            }
            else
            {
                Console.WriteLine($"{vaga} não está disponível.");
            }
        }

        public void LiberarVaga(string vaga)
        {
            if (vagasOcupadas.Contains(vaga))
            {
                vagasOcupadas.Remove(vaga);
                vagasDisponiveis.Add(vaga);
                Console.WriteLine($"{vaga} foi liberada.");
            }
            else
            {
                Console.WriteLine($"{vaga} não está ocupada.");
            }
        }

        public void ExibirVagasDisponiveis()
        {
            Console.WriteLine("Vagas Disponíveis:");
            foreach (var vaga in vagasDisponiveis)
            {
                Console.WriteLine(vaga);
            }
        }

        public void ExibirVagasDisponiveisPorTipo(string tipo)
        {
            Console.WriteLine($"Vagas Disponíveis para {tipo}:");
            foreach (var vaga in vagasDisponiveis)
            {
                if (vaga.Contains(tipo))
                {
                    Console.WriteLine(vaga);
                }
            }
        }

        public void ExibirVagasOcupadas()
        {
            Console.WriteLine("Vagas Ocupadas:");
            foreach (var vaga in vagasOcupadas)
            {
                Console.WriteLine(vaga);
            }
        }

    }
}
