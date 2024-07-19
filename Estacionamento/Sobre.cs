using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Sobre
    {
        public DateTime HorarioEntrada { get; private set; }
        public DateTime? HorarioSaida { get; private set; }

        public void RegistrarEntrada()
        {
            HorarioEntrada = DateTime.Now;
            Console.WriteLine($"Horário de entrada registrado: {HorarioEntrada}");
        }

        public bool ConfirmarSaida()
        {
            Console.Write("Deseja sair? (sim/não): ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                HorarioSaida = DateTime.Now;
                Console.WriteLine($"Horário de saída registrado: {HorarioSaida}");
                return true;
            }
            else
            {

                Console.WriteLine("Saída não registrada.");

                return false;
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nHorário de entrada: {HorarioEntrada}");

            if (HorarioSaida.HasValue)
            {
                Console.WriteLine($"Horário de saída: {HorarioSaida}");
                Console.WriteLine($"Duração total: {HorarioSaida - HorarioEntrada}");
            }
            else
            {
                Console.WriteLine("Saída ainda não registrada.\n");
            }
        }
    }
}
