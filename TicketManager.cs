public class TicketManager
{
    private string csvFilePath;

    public TicketManager(string filePath)
    {
        csvFilePath = filePath;
    }

    public void AddTicket(Ticket ticket)
    {
        using (StreamWriter sw = File.AppendText(csvFilePath))
        {
            sw.WriteLine(ticket.ToString());
        }

        Console.WriteLine("Record added successfully!");
    }
}
