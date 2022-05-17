// Part 1: Write an application that generates a number from 1 to 10
// Extension task: Infinite Guesses

Random rnd = new Random ();
var randomNumber = rnd.Next(1,11);

Console.WriteLine(randomNumber);
Console.WriteLine("What number am I thinking of between 1 and 10? You can keep guessing until you are correct.");
var numberGuessed = Console.ReadLine();
int numberGuessedAsInt = int.Parse(numberGuessed);

while (randomNumber != numberGuessedAsInt)
    {
        Console.WriteLine($"You guessed: " + numberGuessedAsInt);
        Console.WriteLine("Sorry, that is not the number I am thinking of. Guess again...");
        numberGuessed = Console.ReadLine();
        numberGuessedAsInt = int.Parse(numberGuessed);
        if (randomNumber == numberGuessedAsInt)
            break;        
    }

Console.WriteLine("You are CORRECT! You WIN! YAAAAAY!");