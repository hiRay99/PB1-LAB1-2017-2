using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProvaa.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public int Tipo { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public Boolean Disponivel { get; set; }
        public DateTime DataCadastro { get; set; }
    }  
}
