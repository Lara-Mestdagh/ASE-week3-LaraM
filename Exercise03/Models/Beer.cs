namespace Ex3.Models;
public class Beer
{
    // Properties
    private readonly string _name;
    private readonly string _brewery;
    private readonly decimal _alcoholPercentage;
    private readonly string _color;

    // CONSTRUCTOR
    public Beer(string name, string brewery, decimal alcoholPercentage, string color)
    {
        _name = !string.IsNullOrEmpty(name) ? name : throw new ArgumentNullException(nameof(name));
        _brewery = !string.IsNullOrEmpty(brewery) ? brewery : throw new ArgumentNullException(nameof(brewery));

        if (alcoholPercentage < 0)
        {
            throw new BeerException("Negative alcohol percentage is not allowed.", nameof(alcoholPercentage), alcoholPercentage);
        }

        _alcoholPercentage = alcoholPercentage;
        _color = !string.IsNullOrEmpty(color) ? color : throw new ArgumentNullException(nameof(color));
    }

    // Methods
    public string Name => _name;
    public string Brewery => _brewery;
    public decimal AlcoholPercentage => _alcoholPercentage;
    public string Color => _color;
}

public class BeerException : Exception
{
    public string WrongFieldName { get; }
    public object WrongValue { get; }

    public BeerException(string message, string wrongFieldName, object wrongValue) : base(message)
    {
        WrongFieldName = wrongFieldName;
        WrongValue = wrongValue;
    }
}
