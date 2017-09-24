using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProvaa.Models
{
    public class Veiculo
    {
        public Boolean Disponivel { get; set; }
        public Boolean Indisponivel { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
