namespace ProjectTrainStation;

public class Ticket
{
    private string ID { get; }

    private string _customerFirstName;
    private string _customerLastName;
    
    private string CustomerFullName => $"{_customerFirstName} {_customerLastName}";
    
    private Route  Route { get; }
    
    
}