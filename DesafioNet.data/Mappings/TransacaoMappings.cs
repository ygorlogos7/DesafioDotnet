using Desafionet.Bulsiness.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNet.data.Mappings
{
    public class TransacaoMappings : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(t => t.dataTransacao).IsRequired()
                .HasColumnType("date");

            builder.HasOne(p => p.Recebedor)
                .WithMany(p => p.transacoes)
                .IsRequired();

            builder.HasOne(p => p.Pagador)
               .WithMany(p => p.transacoes)
               .IsRequired();

            builder.ToTable("Transacoes");
        }
    }
}
