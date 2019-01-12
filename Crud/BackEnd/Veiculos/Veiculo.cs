using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos
{
    public class Veiculo : BaseDomain
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string AnoFabricacao { get; set; }
        public string AnoModelo { get; set; }
        public string Chassi { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }
        public int Portas { get; set; }
        public string Valor { get; set; }
    }
}
