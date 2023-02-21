using Desafionet.Bulsiness.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNet.data.context
{
    public class Sqlcontext : DbContext 
    {
        public Sqlcontext(DbContextOptions options): base(options) 
        { 

        }
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Chave> Chaves { get; set; }
        public DbSet<Pagador> Pagadores { get; set; }
        public DbSet<Recebedor> Recebedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Sqlcontext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
