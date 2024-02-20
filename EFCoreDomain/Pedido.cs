namespace EFCoreDomain;

public class Pedido
{
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }
}
