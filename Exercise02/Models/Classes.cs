namespace Ex2.Models;

public abstract class Production
{
    // PROPERTIES
    public abstract string Type { get; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public long _date;
    public DateTime Date => DateTimeOffset.FromUnixTimeSeconds(_date).UtcDateTime;

    // CONSTRUCTORS
    public Production(string name, long date, decimal price)
        {
            Name = name;
            _date = date;
            Price = price;
        }

    // FUNCTIONS
    public virtual void OrderNow()
    {
        Console.WriteLine($"Ticket ordered for production {Name} for the price of €{Price}.");
    }
}

public class EducationalProduction : Production
{
    // PROPERTIES
    public string EducationalMaterialUrl { get; set; }
    public override string Type => "Educational";

    // CONSTRUCTORS
    public EducationalProduction(string name, long date, decimal price, string educationalMaterialUrl)
        : base(name, date, price)
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
    public GuestPerformance(string name, long date, decimal price, string guestAssociation)
        : base(name, date, price)
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
    public string Genre { get; set; }
    public override string Type => Genre;

    // CONSTRUCTORS
    public TheatreProduction(string name, long date, decimal price, string genre)
        : base(name, date, price)
    {
        Genre = genre;
    }
}