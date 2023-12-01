namespace ProjectTrainStation;

public class СorridorCoach : Carriage
{
    public СorridorCoach(int totalSeats) : base(100, CarriageType.CorridorCoach, totalSeats)
    {
        base.InitializeSeats();
    }
}