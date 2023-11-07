using Ex1.Models;

// Create objects of each class
Wine wine1 = new Wine("Red Wine", 2020, 50.0, 10.0, "France", Wine.WineType.RED);
Wine wine2 = new Wine("White Wine", 2019, 45.0, 9.0, "Italy", Wine.WineType.WHITE);
Wine wine3 = new Wine("Rosé Wine", 2021, 55.0, 11.0, "Spain", Wine.WineType.ROSE);

PostStamp postStamp1 = new PostStamp("Rare Stamp", 1950, 100.0, "Image1");
PostStamp postStamp2 = new PostStamp("Historical Stamp", 1930, 80.0, "Image2");
PostStamp postStamp3 = new PostStamp("Collectible Stamp", 1970, 120.0, "Image3");

ComicBook comicBook1 = new ComicBook("Super Comic", 1990, 20.0, "Marvel", "Stan Lee");
ComicBook comicBook2 = new ComicBook("Adventure Comic", 1985, 18.0, "DC Comics", "Frank Miller");
ComicBook comicBook3 = new ComicBook("Sci-Fi Comic", 2000, 25.0, "Image Comics", "Robert Kirkman");

// Create separate lists for each class
List<Wine> wines = new List<Wine> { wine1, wine2, wine3 };
List<PostStamp> postStamps = new List<PostStamp> { postStamp1, postStamp2, postStamp3 };
List<ComicBook> comicBooks = new List<ComicBook> { comicBook1, comicBook2, comicBook3 };

// Iterate over the lists and check the properties
Console.WriteLine("Wines:");
foreach (var wine in wines)
{
    Console.WriteLine(wine.ToString());
}

Console.WriteLine("\nPost Stamps:");
foreach (var postStamp in postStamps)
{
    Console.WriteLine(postStamp.ToString());
}

Console.WriteLine("\nComic Books:");
foreach (var comicBook in comicBooks)
{
    Console.WriteLine(comicBook.ToString());
}

// Create a list of Collectible objects
List<Collectible> collectibles = new List<Collectible>();

// Add objects of each class to the list
collectibles.Add(wine1);
collectibles.Add(wine2);
collectibles.Add(wine3);
collectibles.Add(postStamp1);
collectibles.Add(postStamp2);
collectibles.Add(postStamp3);
collectibles.Add(comicBook1);
collectibles.Add(comicBook2);
collectibles.Add(comicBook3);

// Check the StartBidPrice and CollectType values for a few items in the list
foreach (var collectible in collectibles)
{
    Console.WriteLine($"Name: {collectible.Name}, StartBidPrice: {collectible.StartBidPrice:C}, CollectType: {collectible.CollectType}");
}

// Sort the list of Collectible items
collectibles.Sort();

// Print the sorted list
Console.WriteLine("\nSorted Collectibles:");
foreach (var collectible in collectibles)
{
    Console.WriteLine($"Name: {collectible.Name}, CollectType: {collectible.CollectType}");
}