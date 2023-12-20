// This namespace is named "Ex1.Models."
namespace Ex1.Models;

public abstract class Collectible : IComparable<Collectible>
{
    // This is an abstract base class for collectible items.
    // PROPERTIES
    public string Name { get; set; }
    public int YearOfOrigin { get; set; }
    public double Price { get; set; }
    public double StartBidPrice => Price * 0.8; // Calculated property for the starting bid price, which is 80% of the Price property.
    // Abstract property for CollectType
    public abstract string CollectType { get; } // Abstract property that should be implemented by derived classes to specify the type of collectible.
    public int CompareTo(Collectible? other)
    {
        // Implementation of the IComparable<Collectible> interface.
        if (other == null)
            return 1;
            // If 'other' is null, consider this object greater.
        return string.Compare(Name, other.Name, StringComparison.Ordinal);
        // Compare collectibles based on their names.
    }

    // CONSTRUCTORS
    public Collectible()
    {
        // Default constructor for the Collectible class.
        Name = "Default Name"; // Initialize the property in the constructor else you get an error
    }
}

public class Wine : Collectible
{
    // This class represents a collectible item of type Wine.
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
    // Implementation of the abstract CollectType property, specifying the type of collectible as a wine type.

    // CONSTRUCTORS
    public Wine(string name, int yearOfOrigin, double price, double pricePerGlass, string country, WineType type)
    {
        // Constructor to create a Wine collectible.
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
        // Override the ToString method to provide a custom string representation of the Wine collectible.
        return $"{Name} ({Country})";
    }
}

public class PostStamp : Collectible
{
    // This class represents a collectible item of type PostStamp.
    // PROPERTIES
    public string Image { get; set; }
    // Implement abstract property for PostStamp
    public override string CollectType => "post stamp";
    // Implementation of the abstract CollectType property, specifying the type of collectible as a post stamp.

    // CONSTRUCTORS
    public PostStamp(string name, int yearOfOrigin, double price, string image)
    {
        // Constructor to create a PostStamp collectible.
        Name = name;
        YearOfOrigin = yearOfOrigin;
        Price = price;
        Image = image;
    }

    // FUNCTIONS
    public override string ToString()
    {
        // Override the ToString method to provide a custom string representation of the PostStamp collectible.
        return Name;
    }
}

public class ComicBook : Collectible
{
    // This class represents a collectible item of type ComicBook.
    // PROPERTIES
    public string Publisher { get; set; }
    public string Author { get; set; }
    // Implement abstract property for ComicBook
    public override string CollectType => "comic book";
    // Implementation of the abstract CollectType property, specifying the type of collectible as a comic book.

    // CONSTRUCTORS
    public ComicBook(string name, int yearOfOrigin, double price, string publisher, string author)
    {
        // Constructor to create a ComicBook collectible.
        Name = name;
        YearOfOrigin = yearOfOrigin;
        Price = price;
        Publisher = publisher;
        Author = author;
    }

    // FUNCTIONS
    public override string ToString()
    {
        // Override the ToString method to provide a custom string representation of the ComicBook collectible.
        return $"{Name} ({Author})";
    }
}
