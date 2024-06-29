using System.Reflection;
using Fina.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Fina.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options) // Isso substitui o uso do construtor.
{
    public DbSet<Category> Categories { get; set; } = null!; // o Null Not diz que a propriedade não pode ser nullable e que ela vai ter um valor no futuro. Serve para o .Net não reclamar da propriedade poder ser nula.
    public DbSet<Transaction> Transactions { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Isso vai varrer todo o projeto e procurar pelas classes que implementa a interface "IEntityTypeConfiguration". Isso para pegar os mappings dos models.
}