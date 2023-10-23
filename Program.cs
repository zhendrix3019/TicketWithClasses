public class Program
{
    public static void Main()
    {
        string csvFilePath = "Tickets.csv";
        var ticketManager = new TicketManager(csvFilePath);

        while (true)
        {
            var ticket = new Ticket();

            Console.WriteLine("Enter Ticket ID:");
            ticket.TicketId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Summary:");
            ticket.Summary = Console.ReadLine();

            Console.WriteLine("Enter Status:");
            ticket.Status = Console.ReadLine();

            Console.WriteLine("Enter Priority:");
            ticket.Priority = Console.ReadLine();

            Console.WriteLine("Enter Submitter:");
            ticket.Submitter = Console.ReadLine();

            Console.WriteLine("Enter Assigned:");
            ticket.Assigned = Console.ReadLine();

            Console.WriteLine("Enter Watching (separated by '|'):");
            ticket.Watching = Console.ReadLine();

            ticketManager.AddTicket(ticket);
            
            Console.WriteLine("Do you want to add another record? (yes/no)");
            string anotherRecord = Console.ReadLine().ToLower();
            if (anotherRecord != "yes")
                break;
        }
    }
}