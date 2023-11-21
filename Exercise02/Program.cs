using Ex2.Models;

// Replace "path/to/your/file.csv" with the actual path to your CSV file
string filePath = "../Data/educational.csv";

// Read productions from CSV
List<Production> productions = ReadProductionsFromCsv(filePath);

// Loop over the list
foreach (var production in productions)
{
    // Print each production-object
    Console.WriteLine($"Production Name: {production.Name}, Type: {production.Type}");

    // Place an order for each production
    production.OrderNow();

    Console.WriteLine(); // Add a newline for clarity
}



// static List<Production> ReadProductionsFromCsv(string filePath)
// {
//     var productions = new List<Production>();

//     using (TextFieldParser parser = new TextFieldParser(filePath))
//     {
//         parser.TextFieldType = FieldType.Delimited;
//         parser.SetDelimiters(";"); // Set your delimiter

//         while (!parser.EndOfData)
//         {
//             string[] fields = parser.ReadFields();

//             // Assuming the CSV columns are in order: Name, Timestamp, Price, [Additional Properties]
//             string name = fields[0];
//             long timestamp = long.Parse(fields[1]);
//             decimal price = decimal.Parse(fields[2]);

//             // Determine the type and create the corresponding production
//             Production production;

//             if (/* Check condition for EducationalProduction */)
//             {
//                 string educationalMaterialUrl = fields[3];
//                 production = new EducationalProduction(name, timestamp, price, educationalMaterialUrl);
//             }
//             else if (/* Check condition for GuestPerformance */)
//             {
//                 string guestAssociation = fields[3];
//                 production = new GuestPerformance(name, timestamp, price, guestAssociation);
//             }
//             else
//             {
//                 string genre = fields[3];
//                 production = new TheatreProduction(name, timestamp, price, genre);
//             }

//             productions.Add(production);
//         }
//     }

//     return productions;
// }
