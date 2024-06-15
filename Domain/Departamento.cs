namespace DominandoEFCore;

public class Departamento
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public bool Ativo { get; set; } 

    //1N Departamento 1 -> N Funcionario (lista de navegação)
    public List<Funcionario> Funcionarios { get; set; }
}
