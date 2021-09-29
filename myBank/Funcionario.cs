public class Funcionario 
{
    public string Nome {get;set;}
    public string CPF {get;set;}
    public string Cargo {get;set;}
    public double Salario {get;set;}
    public double Comissao {get;set;}

    public Funcionario () {}

    public Funcionario (string nome, string cpf, string cargo, double salario) 
    {
        Nome = nome;
        CPF = cpf;
        Cargo = cargo;
        Salario = salario; 
    }
}