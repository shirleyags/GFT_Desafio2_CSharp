using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos.VeiculosTipo
{
    public abstract class Veiculo
    {
       
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        public int Passageiros { get; set; }
        public bool Combustivel { get; set; }

    }
}
