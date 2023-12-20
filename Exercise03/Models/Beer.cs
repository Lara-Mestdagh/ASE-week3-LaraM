namespace Ex3.Models
{
    // Define the Beer class
    public class Beer
    {
        // PROPERTIES
        private readonly string _name;
        private readonly string _brewery; 
        private readonly decimal _alcoholPercentage; 
        private readonly string _color; 

        // CONSTRUCTORS
        public Beer(string name, string brewery, decimal alcoholPercentage, string color)
        {
            // Check and assign the beer name, throwing a BeerException if it's null or empty
            _name = !string.IsNullOrEmpty(name) ? name : throw new BeerException("Name cannot be null or empty.", nameof(name), name);
            
            // Check and assign the brewery name, throwing a BeerException if it's null or empty
            _brewery = !string.IsNullOrEmpty(brewery) ? brewery : throw new BeerException("Brewery cannot be null or empty.", nameof(brewery), brewery);

            // Check and assign the alcohol percentage, throwing a BeerException if it's negative
            if (alcoholPercentage < 0)
            {
                throw new BeerException("Negative alcohol percentage is not allowed.", nameof(alcoholPercentage), alcoholPercentage);
            }

            // Check and assign the beer color, throwing a BeerException if it's null or empty
            _color = !string.IsNullOrEmpty(color) ? color : throw new BeerException("Color cannot be null or empty.", nameof(color), color);
        }

        // Methods
        public string Name => _name; 
        public string Brewery => _brewery;
        public decimal AlcoholPercentage => _alcoholPercentage;
        public string Color => _color; 
    }

    // Define a custom exception class for beer-related exceptions
    public class BeerException : Exception
    {
        // Properties to store information about the invalid field and its value
        public string WrongFieldName { get; } 
        public object WrongValue { get; } 

        // Constructor for creating a BeerException with custom properties
        public BeerException(string message, string wrongFieldName, object wrongValue) : base(message)
        {
            WrongFieldName = wrongFieldName; 
            WrongValue = wrongValue; 
        }
    }
}
