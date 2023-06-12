namespace Company.Models;
public class Store
{
    public int Id {get; set;}
    public string Name {get; set; }
    public string Location{get; set;}
    public DateTime OpenTime {get; set;}
    public DateTime CloseTime {get; set;}

    public Store(int id, string name, string location, DateTime openTime, DateTime closeTime)
    {
        Id = id;
        Name = name;
        Location = location;
        OpenTime = openTime;
        CloseTime = closeTime;
    }
}