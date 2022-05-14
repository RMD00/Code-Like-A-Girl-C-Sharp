// Part 1: Write an application that generates a number from 1 to 10

var random = new Random ();
int randomNumber = random.Next(1,11);

// Ask the user to guess the number
Console.WriteLine("Guess what number (from 1 to 10) I am thinking of. You get one guess only!");
int numberGuessed = int.Parse(Console.ReadLine());
Console.WriteLine($"You guessed: " + numberGuessed);

// Is the user's guess correct?
Console.WriteLine($"The correct number is: " + randomNumber);
if (randomNumber == numberGuessed)
    {
        Console.WriteLine("YOU ARE CORRECT! YAY!");
    }
else
    {
        Console.WriteLine("You are incorrect... sorry :(");
    }

// Update your code to allow the user a maximum of three guesses

// Ask the user to guess the number three times

var newRandom = new Random ();
int newRandomNumber = newRandom.Next(1,11);
Console.WriteLine("Let's play again. This time I'll give you three guesses.");
Console.WriteLine("What new number (from 1 to 10) I am thinking of?");
int firstNumberGuessed = int.Parse(Console.ReadLine());
int numberOfGuesses = 3;
Console.WriteLine($"You guessed: " + firstNumberGuessed);

// Are the user's guesses correct?
if (newRandomNumber == firstNumberGuessed)
    {
        Console.WriteLine("YOU ARE CORRECT! The number is " + randomNumber + " YAY!");
    }
else
    {
        Console.WriteLine("Sorry, that is not the number I am thinking of :(");
            if (firstNumberGuessed > newRandomNumber)
            {
                Console.WriteLine("The number I am thinking of is lower than your last guess.");
            }
            else
            {
                Console.WriteLine("The number I am thinking of is higher than your last guess.");
            }
    }
Console.WriteLine($"You still have " + --numberOfGuesses + " guesses left. What's your next guess?");
int secondNumberGuessed = int.Parse(Console.ReadLine());

if (newRandomNumber == secondNumberGuessed)
    {
        Console.WriteLine("YOU ARE CORRECT! The number is " + randomNumber + " YAY!");
    }
else
    {
        Console.WriteLine("Sorry, that is not the number I am thinking of :(");
            if (secondNumberGuessed > newRandomNumber)
            {
                Console.WriteLine("The number I am thinking of is lower than your last guess.");
            }
            else
            {
                Console.WriteLine("The number I am thinking of is higher than your last guess.");
            }
    }
Console.WriteLine($"You still have " + --numberOfGuesses + " guess left. What's your next guess?");
int thirdNumberGuessed = int.Parse(Console.ReadLine());
Console.WriteLine($"You guessed: " + thirdNumberGuessed);

if (newRandomNumber == thirdNumberGuessed)
    {
        Console.WriteLine("YOU ARE CORRECT! The number is " + randomNumber + " YAY!");
    }
else
    {
        Console.WriteLine("Sorry, that is not the number I am thinking of :(");
    }
Console.WriteLine($"You have " + --numberOfGuesses + " guesses left. You LOSE! MWahahahah!!");
// 






