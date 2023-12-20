// Provide the paths to your CSV files
const string educationalCsvPath = "../Exercise02/Data/educational.csv";
const string guestCsvPath = "../Exercise02/Data/guestperformance.csv";
const string theatreCsvPath = "../Exercise02/Data/theatre.csv";

// Read all paths and put them into lists
List<EducationalProduction>educationalProductions = ReadEducationalProductions(educationalCsvPath);
List<GuestPerformance>guestPerformances = ReadGuestPerformances(guestCsvPath);
List<TheatreProduction>theatreProductions = ReadTheatreProductions(theatreCsvPath);

// Loop over the list of educational productions
foreach (var production in educationalProductions)
{
    // Print each production-object
    Console.WriteLine($"Production Name: {production.Name}, Type: {production.Type}");

    // Place an order for each production
    production.OrderNow();

    Console.WriteLine(); // Add a newline for clarity
}

// Loop over the list of guest performances
foreach (var production in guestPerformances)
{
    // Print each production-object
    Console.WriteLine($"Production Name: {production.Name}, Type: {production.GuestAssociation}");

    // Place an order for each production
    production.OrderNow();

    Console.WriteLine(); // Add a newline for clarity
}

// Loop over the list of theatre productions
foreach (var production in theatreProductions)
{
    // Print each production-object
    Console.WriteLine($"Production Name: {production.Name}, Type: {production.Type}");

    // Place an order for each production
    production.OrderNow();

    Console.WriteLine(); // Add a newline for clarity
}

// function to read the csv file and return a list of EducationalProduction objects
List<EducationalProduction> ReadEducationalProductions(string path)
{
    List<EducationalProduction> productions = new List<EducationalProduction>();
    string[] educationalText = File.ReadAllLines(path);
    
    // Skip the first line (headers) and start processing from the second line
    for (int i = 1; i < educationalText.Length; i++)
    {
        string line = educationalText[i];

        // Split the line into values using a semicolon as the delimiter
        string[] values = line.Split(';'); // Use semicolon as the delimiter

        // Check if there are at least 5 values (assuming 5 columns in the CSV)
        if (values.Length >= 5)
        {
            // Create a new instance of EducationalProduction and add it to the list
            var educationalProduction = new EducationalProduction(
                values[0],
                long.Parse(values[1]),
                decimal.Parse(values[2].Replace(',', '.')), // Replace comma with dot for decimal values
                values[3],
                values[4]);

            productions.Add(educationalProduction);
        }
        else
        {
            Console.WriteLine($"Skipping line with insufficient data: {line}");
        }
    }
    return productions;
}

// function to read the csv file and return a list of GuestPerformance objects
List<GuestPerformance> ReadGuestPerformances(string path)
{
    List<GuestPerformance> performances = new List<GuestPerformance>();
    string[] guestText = File.ReadAllLines(path);
    
    // Skip the first line (headers) and start processing from the second line
    for (int i = 1; i < guestText.Length; i++)
    {
        string line = guestText[i];

        // Split the line into values using a semicolon as the delimiter
        string[] values = line.Split(';'); // Use semicolon as the delimiter

        // Check if there are at least 5 values (assuming 5 columns in the CSV)
        if (values.Length >= 5)
        {
            // Create a new instance of GuestPerformance and add it to the list
            var guestPerformance = new GuestPerformance(
                values[0],
                long.Parse(values[1]),
                decimal.Parse(values[2].Replace(',', '.')), // Replace comma with dot for decimal values
                values[3],
                values[4]);

            performances.Add(guestPerformance);
        }
        else
        {
            Console.WriteLine($"Skipping line with insufficient data: {line}");
        }
    }
    return performances;
}

// function to read the csv file and return a list of TheatreProduction objects
List<TheatreProduction> ReadTheatreProductions(string path)
{
    List<TheatreProduction> productions = new List<TheatreProduction>();
    string[] theatreText = File.ReadAllLines(path);
    
    // Skip the first line (headers) and start processing from the second line
    for (int i = 1; i < theatreText.Length; i++)
    {
        string line = theatreText[i];

        // Split the line into values using a semicolon as the delimiter
        string[] values = line.Split(';'); // Use semicolon as the delimiter

        // Check if there are at least 5 values (assuming 5 columns in the CSV)
        if (values.Length >= 5)
        {
            // Create a new instance of TheatreProduction and add it to the list
            var theatreProduction = new TheatreProduction(
                values[0],
                long.Parse(values[1]),
                decimal.Parse(values[2].Replace(',', '.')), // Replace comma with dot for decimal values
                values[3],
                values[4],
                values[5]);

            productions.Add(theatreProduction);
        }
        else
        {
            Console.WriteLine($"Skipping line with insufficient data: {line}");
        }
    }
    return productions;
}