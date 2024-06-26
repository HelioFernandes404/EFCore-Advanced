﻿namespace DominandoEFCore;

public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string RG { get; set; }
    public bool Excluido { get; set; }

    // FK Departamento
    //public int DepartamentoId { get; set; }
    public virtual Departamento Departamento { get; set; } // N1 Funcionario -> 1 Departamento
}
