using Microsoft.EntityFrameworkCore;
using project_product_orders.domain.Entities;

namespace project_product_orders.Infrastructure.Context

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // 🟢 DbSets
        public DbSet<Pedido> Pedidos => Set<Pedido>();
        public DbSet<ItemPedido> Itens => Set<ItemPedido>();
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 🔑 Chaves primárias
            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
            modelBuilder.Entity<ItemPedido>().HasKey(i => i.Id);

            // 🔗 Relacionamento 1:N entre Pedido e ItemPedido
            modelBuilder.Entity<Pedido>()
                        .HasMany(p => p.Itens)
                        .WithOne()
                        .HasForeignKey(i => i.PedidoId) // <-- Recomendado explicitar a FK
                        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
