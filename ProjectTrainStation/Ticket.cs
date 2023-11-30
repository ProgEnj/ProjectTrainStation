namespace ProjectTrainStation;

public class Ticket
{
    private string ID { get; }

    private string _customerFirstName;
    private string _customerLastName;
    public string CustomerFullName => $"{_customerFirstName} {_customerLastName}";
    
    private Route Route { get; }
    private string Seat { get; set; }
    
    public DateTime creationData { get; }
    
    
    
}