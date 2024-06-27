using System.Reflection;
using DominandoEFCore.Domain;
using EFcore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;

namespace DominandoEFCore;

public class ApplicationContext : DbContext // Class do EF core que gerencia o banco de dados
{
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Conversor> Conversors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string strConnection = "Server=DESKTOP-KH946K7\\SQLEXPRESS;Database=DevIO-02;Trusted_Connection=True;TrustServerCertificate=True;";
        optionsBuilder
            .UseSqlServer(strConnection)
            .LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging()
            ;
    }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        // 1. forma de aplicar as configura de entidades 
        modelBuilder.ApplyConfiguration(new ClienteConfiguration());

        // 2. forma de aplicar para todas as configura de todas entidades 
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // 3. forma de aplicar para todas as configura de todas entidades
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
    }

}

