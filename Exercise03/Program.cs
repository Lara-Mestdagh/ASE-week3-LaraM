using Ex3.Models;

try
{
    // Creating a Beer object with incorrect values
    var beer2 = new Beer("Example Beer", "Example Brewery", 5.0m, "");
}
catch (BeerException ex)
{
    // Print the message of each exception
    Console.WriteLine($"Exception: {ex.Message}, Field: {ex.WrongFieldName}, Value: {ex.WrongValue}");
}