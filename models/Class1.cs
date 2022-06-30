namespace models;
public class Ticket
{
    //This is an empty constructor
    public Ticket() {}

    public int ID{get; set;}
    public int Author{get; set;}
    public int Resolver{get; set;}
    public string Description{get; set;}
    public string Status{get; set;}
    public decimal Amount{get; set;}
}
