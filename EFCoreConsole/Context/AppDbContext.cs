using EFCoreDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreConsole.Context;

public class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
         "Data Source=<<sua_conexao>>;TrustServerCertificate=True;")
         .LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>().HasData(
             new Cliente { Id = 1, Nome = "Macoratti",Idade=45, Email="macoratti@yahoo.com" }
             );

        modelBuilder.Entity<Pedido>().HasData(
        Enumerable.Range(1, 30).Select(i => new Pedido
        {
            Id = i,
            Descricao = $"Pedido {i}",ClienteId = 1}).ToArray()
        );
    }
}
