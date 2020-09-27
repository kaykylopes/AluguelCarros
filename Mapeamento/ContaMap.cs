using AluguelCarros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarros.Mapeamento
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Conta> builder)
        {
            builder.HasKey(c => c.ContaId);
            builder.Property(c => c.Saldo).IsRequired();

            builder.HasOne(c => c.Usuario).WithOne(c => c.Conta).HasForeignKey<Conta>(c => c.UsuarioId);

            builder.ToTable("Contas");
        }
    }
}
