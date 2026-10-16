public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Balance { get; set; }

    public Client(int id, string firstName, string lastName, decimal balance)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }
}