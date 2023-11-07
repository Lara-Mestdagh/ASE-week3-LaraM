namespace Ex1.Models;

public abstract class Collectible
{
    // PROPERTIES
    public string Name { get; set; }
    public int YearOfOrigin { get; set; }
    public double Price { get; set; }
    public double StartBidPrice => Price * 0.8; // Calculated property
    // Abstract property for CollectType
    public abstract string CollectType { get; }

    // CONSTRUCTORS
    public Collectible()
    {
        Name = "Default Name"; // Initialize the property in the constructor else you get an error
    }
}

public class Wine : Collectible
{
    public enum WineType
    {
    RED,
    WHITE,
    ROSE,
    SPARKLING
    }

    // PROPERTIES
    public double PricePerGlass { get; set; }          
    public string Country { get; set; }
    public WineType Type { get; set; }

    // Implement abstract property for Wine
    public override string CollectType => Type.ToString() + " wine";

    // CONSTRUCTORS
    public Wine(string name, int yearOfOrigin, double price, double pricePerGlass, string country, WineType type)
    {
        Name = name;
        YearOfOrigin = yearOfOrigin;
        Price = price;
        PricePerGlass = pricePerGlass;
        Country = country;
        Type = type;
    }

    // FUNCTIONS
    public override string ToString()
    {
        return $"{Name} ({Country})";
    }
}

public class PostStamp : Collectible
{
    // PROPERTIES
    public string Image { get; set; }
    // Implement abstract property for PostStamp
    public override string CollectType => "post stamp";

    // CONSTRUCTORS
    public PostStamp(string name, int yearOfOrigin, double price, string image)
    {
        Name = name;
        YearOfOrigin = yearOfOrigin;
        Price = price;
        Image = image;
    }

    // FUNCTIONS
    public override string ToString()
    {
        return Name;
    }
}

public class ComicBook : Collectible
{
    // PROPERTIES
    public string Publisher { get; set; }
    public string Author { get; set; }
    // Implement abstract property for ComicBook
    public override string CollectType => "comic book";

    // CONSTRUCTORS
    public ComicBook(string name, int yearOfOrigin, double price, string publisher, string author)
    {
        Name = name;
        YearOfOrigin = yearOfOrigin;
        Price = price;
        Publisher = publisher;
        Author = author;
    }

    // FUNCTIONS
    public override string ToString()
    {
        return $"{Name} ({Author})";
    }
}
