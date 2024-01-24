using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Entities;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
    
    public virtual DbSet<Order> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

}