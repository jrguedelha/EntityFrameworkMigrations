namespace EntityFrameworkMigrations;

public class Cliente
{
  public Nullable<long> Id { get; set; }
  public string Nome { get; set; }
  public string Email { get; set; }
  public IList<Pedido> Pedidos { get; set; }
  
  public Cliente() {}
}
