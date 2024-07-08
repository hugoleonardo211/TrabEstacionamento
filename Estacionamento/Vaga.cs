using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Vaga
    {
        public int Id { get; set; }
        public bool Ocupada { get; set; }  
        public string TipoVaga { get; set; }
        public string Veiculo { get; set; }
        public int Quantidade { get; set; }
        public string carro { get; set; }



        public void Ocupacao(int vaga, string veiculo, string tipovaga, string Carro)
        {
            if (veiculo == Carro)
            {
                Console.WriteLine($"Tem disponiveis {tipovaga} para esse veiculo  ");
            }
            else
            {
                Console.WriteLine($"Tem disponiveis {tipovaga} para esse veiculo");
            }
        }

     
    }
}
