namespace Ex2.Models;

public abstract class Production
{
    // PROPERTIES
    public string Name { get; set; }
    protected long Date { get; set; }
    public abstract string Type { get; }
    protected decimal Price { get; set; }
    protected string Description { get; set; }

    // CONSTRUCTORS
    protected Production(string name, long date, decimal price, string description)
    {
        Name = name;
        Date = date;
        Price = price;
        Description = description;
    }
    // FUNCTIONS
    public virtual void OrderNow()
    {
        // Make OrderNow virtual to allow overriding in derived classes
        Console.WriteLine($"Ticket ordered for production {Name} for the price of €{Price}.");
    }
    protected DateTime GetDateTimeFromTimestamp()
    {
        // This method converts the timestamp to a DateTime object
        return DateTimeOffset.FromUnixTimeSeconds(Date).UtcDateTime;
    }
}

public class EducationalProduction : Production
{
    // PROPERTIES
    public string EducationalMaterialUrl { get; set; }
    public override string Type => "Educational";

    // CONSTRUCTORS
    public EducationalProduction(string name, long date, decimal price, string description, string educationalMaterialUrl)
        : base(name, date, price, description)
    {
        EducationalMaterialUrl = educationalMaterialUrl;
    }

    // METHODS
    // Override OrderNow method to include additional information
    public override void OrderNow()
    {
        base.OrderNow(); // Call the base class implementation

        // Additional information for EducationalProduction
        Console.WriteLine($"Associated educational material can be found here: {EducationalMaterialUrl}");
    }
}

public class GuestPerformance : Production
{
    // PROPERTIES
    public string GuestAssociation { get; set; }
    public override string Type => "Guest";

    // CONSTRUCTORS
    public GuestPerformance(string name, long date, decimal price, string description, string guestAssociation)
        : base(name, date, price, description)
    {
        GuestAssociation = guestAssociation;
    }

    // METHODS
    // Override OrderNow method for GuestPerformance
    public override void OrderNow()
    {
        Console.WriteLine($"Please contact {GuestAssociation} to order tickets for the guest performance {Name}.");
    }
}

public class TheatreProduction : Production
{
    // PROPERTIES
    public string Director { get; set; }
    public string Genre { get; set; }
    public override string Type => Genre;

    // CONSTRUCTORS
    public TheatreProduction(string name, long date, decimal price, string description, string director, string genre)
        : base(name, date, price, description)
    {
        Genre = genre;
        Director = director;
    }
}