namespace SP3072118MVCDB.Models;

public class Cliente
{
    public int Id { get; set; }
    public string RG { get; set; }
    public string CPF { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }

    public Cliente() { }

    public Cliente(int id, string rg, string cpf, string nome, string endereco)
    {
        Id = id;
        Endereco = endereco;
        RG = rg;
        CPF = cpf;
        Nome = nome;
    }
}