using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace LottoAPI.Data
{
    public class LottoAPIContext : DbContext
    {
        public LottoAPIContext (DbContextOptions<LottoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ClassLibrary.Models.Jatekos> Jatekos { get; set; } = default!;

        public DbSet<ClassLibrary.Models.Tipp>? Tipp { get; set; }
    }
}
