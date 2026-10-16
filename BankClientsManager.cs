using System;
using System.Collections.Generic;

public class BankClientsManager
{
    private static BankClientsManager? instance;

    private List<Client> clients = new List<Client>();

    private int nextId = 1;

    private BankClientsManager()
    {
    }
    
    public static BankClientsManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new BankClientsManager();
            }
            return instance;
        }
    }

    public void AddClient(string firstName, string lastName, decimal balance)
    {
        Client client = new Client(nextId, firstName, lastName, balance);

        clients.Add(client);

        nextId++;
    }

    public bool RemoveClient(int id)
    {
        Client client = clients.Find(c => c.Id == id);
        if (client != null)
        {
            clients.Remove(client);
            return true;
        }
        return false;
    }

    public void DisplayClients()
    {
        if (clients.Count == 0)
        {
            Console.WriteLine("Brak klientów.");
            return;
        }

        foreach (Client client in clients)
        {
            Console.WriteLine();
            Console.WriteLine($"ID: {client.Id}\nImię i nazwisko: {client.FirstName} " + $"{client.LastName}\nSaldo: {client.Balance} PLN");
        }
    }
}