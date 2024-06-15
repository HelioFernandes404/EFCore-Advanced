using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DominandoEFCore;

public class ApplicationContext : DbContext // Class do EF core que gerencia o banco de dados
{
    public DbSet<Departamento> Departamentos { get; set; } 
    public DbSet<Funcionario> Funcionarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string strConnection = "Server=DESKTOP-KH946K7\\SQLEXPRESS;Database=DEFCore;Trusted_Connection=True;TrustServerCertificate=True;";
        optionsBuilder
            .UseSqlServer("Server=localhost,1433;Database=DevIO;User Id=sa;Password=!123Senha;Trusted_Connection=False;MultipleActiveResultSets=true")
            .LogTo(Console.WriteLine, LogLevel.Information) // Loga as informações no console
            .EnableSensitiveDataLogging(); // Habilita o log de informações sensíveis
    }
}
