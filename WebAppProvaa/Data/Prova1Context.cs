using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppProvaa.Models
{
    public class Prova1Context : DbContext
    {
        public Prova1Context (DbContextOptions<Prova1Context> options)
            : base(options)
        {
        }

        public DbSet<WebAppProvaa.Models.Veiculo> Veiculo { get; set; }
    }
}
