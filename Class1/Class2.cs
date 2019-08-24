using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class VeiculoAereo: Veiculo
    {
        public double TamanhoAsa { get; set; }
        public VeiculoAereo(string cor, int quantidadePortas, string marca, string modelo, double tamanhoAsa) 
            :base(cor, quantidadePortas, marca, modelo)
        {
            TamanhoAsa = tamanhoAsa;
        }

        public override void Acelerar()
        {
            Console.WriteLine("Ligando turbinas");
        }

        public override void Freiar()
        {
            Console.WriteLine("Desligando turbinas");
        }
    }
}
