BankClientsManager manager = BankClientsManager.Instance;

bool running = true;

while (running)
{
    Console.WriteLine("Witaj w systemie zarządzania klientami banku");
    Console.WriteLine();
    Console.WriteLine("1. Dodaj nowego klienta");
    Console.WriteLine("2. Usuń istniejącego klienta");
    Console.WriteLine("3. Wyświetl listę klientów");
    Console.WriteLine("4. Wyjdź z aplikacji");
    Console.Write("Wybierz opcję: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine();
            Console.Write("Podaj imię nowego klienta: ");
            string firstName = Console.ReadLine();

            Console.Write("Podaj nazwisko nowego klienta: ");
            string lastName = Console.ReadLine();

            Console.Write("Podaj saldo konta nowego klienta: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            manager.AddClient(firstName, lastName, balance);

            Console.WriteLine("Nowy klient został dodany!");

            break;
        case "2":
            Console.WriteLine();
            Console.Write("Podaj ID klienta do usunięcia: ");
            int id = int.Parse(Console.ReadLine());

            bool removed = manager.RemoveClient(id);

            if (removed)
            {
                Console.WriteLine("Klient został usunięty.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono klienta o podanym ID.");
            }

            break;
        case "3":
            manager.DisplayClients();
            break;
        case "4":
            running = false;
            Console.WriteLine("Wyłączanie aplikacji...");
            break;
        default:
            Console.WriteLine("Nieprawidłowa opcja");
            break;
    }

    Console.WriteLine();
}