using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;

namespace DominandoEFCore;

public class ApplicationContext : DbContext
{
    public DbSet<Funcao> Funcoes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string strConnection = "Server=localhost;Database=efcore-curso;User Id=sa;Password=Adminxyz22#;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=true;";
        optionsBuilder
            .UseSqlServer(strConnection)
            .LogTo(Console.WriteLine, LogLevel.Information)
            ;
    }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}

