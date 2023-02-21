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
    public class RecebedorMappings : IEntityTypeConfiguration<Recebedor>
    {
        public void Configure(EntityTypeBuilder<Recebedor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Nome).IsRequired()
            .HasColumnType("varchar(1000)");

            builder.ToTable("Recebedor");
        }
    }
}
