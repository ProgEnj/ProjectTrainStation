using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace ProjectTrainStation;

public class TicketStatistic
{
    public List<Ticket> TicketRecords;

    public TicketStatistic()
    {
        TicketRecords = new List<Ticket>();
    }

    public void AddRecord(Ticket newRecord)
    {
        this.TicketRecords.Add(newRecord);
    }

    public void RemoveRecord(Ticket toRemoveRecord)
    {
        TicketRecords.Remove(toRemoveRecord);
    }

    public int SoldForToday()
    {
        return TicketRecords
            .Where(ticket => ticket.creationData == DateTime.Today)
            .Count();
    }

    public int SoldForWeek()
    {
        DateTime Today = DateTime.Today;
        return TicketRecords
            .Where(ticket => ticket.creationData.Year == Today.Year &&
                             ticket.creationData.Month == Today.Month &&
                             (Math.Abs(ticket.creationData.Day - Today.Day) < 7))
            .Count();
    }

    public int SoldForQuarter()
    {
        DateTime Today = DateTime.Today;
        return TicketRecords
            .Where(ticket => ticket.creationData.Year == Today.Year &&
                             Math.Abs(ticket.creationData.DayOfYear - Today.DayOfYear) < 91)
            .Count();
    }

    public int SoldForYear()
    {
        DateTime Today = DateTime.Today;
        return TicketRecords
            .Where(ticket => ticket.creationData.Year == Today.Year)
            .Count();
    }
}