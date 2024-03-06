using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class LottoContext : DbContext
    {
        public LottoContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LottoAPI.Data;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<ClassLibrary.Models.Jatekos> Jatekos { get; set; } = default!;

        public DbSet<ClassLibrary.Models.Tipp>? Tipp { get; set; }
    }
}