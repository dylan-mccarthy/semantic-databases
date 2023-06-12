namespace Company.Models;

public class StockEntry
{
    public int Id {get; set;}
    public int StoreId {get; set;}
    public int ProductId {get; set;}
    public int Quantity {get; set;}

    public StockEntry(int id, int storeId, int productId, int quantity)
    {
        Id = id;
        StoreId = storeId;
        ProductId = productId;
        Quantity = quantity;
    }
}