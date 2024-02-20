namespace EFCoreDomain;

public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public int Idade { get; set; }
    public ICollection<Pedido>? Pedidos { get; set; }
}
