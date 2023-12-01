namespace ProjectTrainStation;

public class CouchetteCar : Carriage
{
    public CouchetteCar(int totalSeats) : base(50, CarriageType.CouchetteCar, totalSeats)
    {
        base.InitializeSeats();
    }
}