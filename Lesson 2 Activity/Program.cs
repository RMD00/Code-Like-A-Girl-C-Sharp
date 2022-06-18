Console.WriteLine("What is your name?");
var name = Console.ReadLine();
name = name.Trim();
var welcomeMessage = $"Hello {name}";
Console.WriteLine(welcomeMessage.Trim()+ "!"); 

Console.WriteLine("Pick an adverb, e.g. playfully, sadly?");
var adverb = Console.ReadLine();
adverb = adverb.Trim().ToLower();
Console.WriteLine("Write the name of your favourite animal");
var animal = Console.ReadLine();
animal = animal.Trim().ToLower();

Console.WriteLine("Here is your madlib:"); 
var madlib = $"One day, {name} was {adverb} walking along the road, and the neighbour's {animal} came out to say hello!";
Console.WriteLine(madlib);
