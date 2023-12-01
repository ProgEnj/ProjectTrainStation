using ProjectTrainStation;

Manager man = new Manager();
man.AddTS("КривийРігГоловний");
man.AddTS("КиївПасажирський");

man.AddRoute(0, 1, DateTime.Now.AddDays(10), DateTime.Now.AddDays(11), 10, CarriageType.CorridorCoach, 3);

man.PrintAvailableRoutes();
Console.WriteLine();
man.PrintAvailableTS();
Console.WriteLine();
man.PrintAvailableSeats(0, 0);

man.IssueATicket("Good", "Man", 0, 0, 0, "b1");

Console.WriteLine("Statistic: " + man.AvailableRoutes[0].TicketStatistic.SoldForToday() + "\n");

man.PrintAvailableSeats(0, 0);
