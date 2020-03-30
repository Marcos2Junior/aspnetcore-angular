using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreAngular.Model;

namespace AspNetCoreAngular.Data
{
    public class AspNetCoreAngularContext : DbContext
    {
        public AspNetCoreAngularContext (DbContextOptions<AspNetCoreAngularContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCoreAngular.Model.Evento> Evento { get; set; }
    }
}
