using Microsoft.EntityFrameworkCore;
using CrudCliente.Models;
using System.Collections.Generic;

namespace CrudCliente.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}