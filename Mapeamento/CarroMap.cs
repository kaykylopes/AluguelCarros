﻿using AluguelCarros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarros.Mapeamento
{
    public class CarroMap : IEntityTypeConfiguration<Carro>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Carro> builder)
        {
            builder.HasKey(c => c.CarroId);

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Marca).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Foto).IsRequired();
            builder.Property(c => c.PrecoDiaria).IsRequired();

            builder.HasMany(c => c.Alugueis).WithOne(c => c.Carro).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Carros");
        }
    }
}