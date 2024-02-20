using EFCoreConsole.Context;
using Microsoft.EntityFrameworkCore;

using (AppDbContext context = new AppDbContext())
{
    Console.WriteLine("Criando banco de dados e tabelas... Aguarde ...\n");
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();
}

Consulta1();
Console.ReadKey();

void Consulta1()
{
    using var ctx = new AppDbContext();
    //var resultado = ctx.Clientes.Include(b => b.Pedidos).ToList();
    var resultado = ctx.Clientes.AsSplitQuery().Include(b => b.Pedidos).ToList();
    Console.WriteLine("Consulta2 executada");
}