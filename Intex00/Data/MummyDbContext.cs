using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Intex00.Data
{
    public class MummyDbContext : DbContext
    {
      public MummyDbContext(DbContextOptions<MummyDbContext> options)
        : base(options)
        {
        }
    }
}
