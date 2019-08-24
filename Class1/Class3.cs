using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class VeiculoTerrestre : Veiculo
    {
        public bool Is4x4 { get; set; }
        public VeiculoTerrestre(string cor, int quantidadePortas, string marca, string modelo, bool is4x4) : base(cor, quantidadePortas, marca, modelo)
        {
            Is4x4 = is4x4;
        }

        public override void Acelerar()
        {
            Console.WriteLine("Ligando motor");
        }

        public override void Freiar()
        {
            Console.WriteLine("Freiando turbinas");
        }
    }
}
