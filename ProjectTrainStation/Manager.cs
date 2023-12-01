using System.Runtime.InteropServices;

namespace ProjectTrainStation;

public class Manager
{
    public List<TrainStation> AvailableTS { get; }
    public List<Route> AvailableRoutes { get; }

    public Manager()
    {
        AvailableRoutes = new List<Route>();
        AvailableTS = new List<TrainStation>();
    }

    public void PrintAvailableRoutes()
    {
        for (int i = 0; i < AvailableRoutes.Count; i++)
        {
            Console.Write(AvailableRoutes[i].Title + $" index: {i}\n");
        }
    }

    public void PrintAvailableTS()
    {
        for (int i = 0; i < AvailableTS.Count; i++)
        {
            Console.Write(AvailableTS[i].Name + $" index: {i}\n");
        }
    }

    public void AddTS(string name)
    {
        AvailableTS.Add(new TrainStation(name));
    }

    public void AddRoute(int TS1, int TS2, DateTime departureTime, 
        DateTime arrivalTime, int gap, Enum carriageType, int numberOfCarriages)
    {
        AvailableRoutes.Add(new Route(new Train(carriageType, numberOfCarriages), AvailableTS[TS1], 
            AvailableTS[TS2], departureTime, arrivalTime, gap));
    }

    public void PrintAvailableSeats(int RouteIndex, int carriage)
    {
        int coupeNum = 0;
        foreach (var coupe in AvailableRoutes[RouteIndex].AssignedTrain.Carriages[carriage].Seats)
        {
            Console.Write($"Coupe: {coupeNum}\n");
            foreach (var seat in coupe)
            {
                Console.Write($"Seat: {seat.Key}, customer: ");
                if (seat.Value == null)
                {
                    Console.Write("Empty");
                }
                else
                {
                    Console.Write(seat.Value.ID);
                }
                Console.WriteLine();
            }
            coupeNum++;
        }
        Console.WriteLine();
    }
    
    public void IssueATicket(string firstName, string lastName, int routeIndex, int carriageIndex, int coupe, string seat)
    {
        Ticket ticket = new Ticket(firstName, lastName, AvailableRoutes[routeIndex], carriageIndex, coupe, seat);
        AvailableRoutes[routeIndex].AddTicket(ticket);
    }

    public void RetutnTheTicket(string ID, int routeIndex)
    {
        Ticket ticketToReturn =
            AvailableRoutes[routeIndex].TicketStatistic.TicketRecords.Find(ticket => ticket.ID == ID);
        AvailableRoutes[routeIndex].RemoveTicket(ticketToReturn);
    }
}