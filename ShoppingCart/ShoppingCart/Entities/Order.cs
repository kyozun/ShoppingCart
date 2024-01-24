namespace ShoppingCart.Entities;

public class Order
{

    public int Id { get; set; }
    
    public int ItemCode { get; set; }

    public string ItemName { get; set; } 

    public string ItemQty { get; set; }

    public string OrderDelivery { get; set; }

    public string OrderAddress { get; set; }

    public string PhoneNumber { get; set; }
    
    
}