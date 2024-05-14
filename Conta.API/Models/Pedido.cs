namespace Conta.API.Models
{
    public class Pedido
    {
        public Pedido()
        {
        }

        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; } = null!;
        public DateTime DataCriacao { get; set; }

        public Pedido(int id, int usuarioId, Usuario usuario)
        {
            Id = id;
            UsuarioId = usuarioId;
            Usuario = usuario;
            DataCriacao = DateTime.Now;
        }

        public override string ToString()
            => $"Pedido Id {Id}, Usuário {Usuario.Nome}" +
            $", Data de criação: {DataCriacao:dd/MM/yyyy}";
    }
}
