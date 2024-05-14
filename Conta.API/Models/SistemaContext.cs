using System;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Conta.API.Models
{
	public class SistemaContext : DbContext
	{
		public SistemaContext(DbContextOptions<SistemaContext> options): base(options)
		{
		}

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany<Pedido>()
                .WithOne()
                .HasForeignKey(e => e.UsuarioId);
        }
    }
}

