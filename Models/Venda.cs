namespace SP3072118MVCDB.Models;

public class Venda
{
    public int VendaId { get; set; }
    public int PedidoId { get; set; }
    public int ClienteId { get; set; }
    public string DataVenda { get; set; }
    public float Desconto { get; set; }
    public float ValorBruto { get; set; }

    public Venda() { }

    public Venda(int vendaId, int pedidoId, int clienteId, string dataVenda, float desconto, float valorBruto)
    {
        VendaId = vendaId;
        PedidoId = pedidoId;
        ClienteId = clienteId;
        DataVenda = dataVenda;
        Desconto = desconto;
        ValorBruto = valorBruto;
    }
}