namespace ShoppingCart.Entities;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } 

    public string? Thumbnail { get; set; }

    public decimal Price { get; set; }

    public int Qty { get; set; }

    public string? Description { get; set; }
}