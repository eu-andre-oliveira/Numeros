using Olivas.Numeros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Olivas.Numeros.DAO
{
    public class NumerosContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<Cliente>().HasRequired(m => m.Usuario);
        }
    }
}