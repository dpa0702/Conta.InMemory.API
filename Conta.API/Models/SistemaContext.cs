using System;
using Microsoft.EntityFrameworkCore;

namespace Conta.API.Models
{
	public class SistemaContext : DbContext
	{
		public SistemaContext(DbContextOptions<SistemaContext> options): base(options)
		{
		}

        public DbSet<Usuario> Usuarios { get; set; }
    }
}

