// Lesson 3: Savings Calculator

// This is the data collection 
Console.WriteLine("What is your initial deposit (please use numbers only?");
var depositString = Console.ReadLine();
var deposit = int.Parse(depositString);

Console.WriteLine("What is the monthly interest rate (please use numbers only?");
var interestRateString = Console.ReadLine();
var interestRateAsPercentage = double.Parse(interestRateString);

Console.WriteLine("How many months will you save for (please use numbers only?");
var monthsSavingString = Console.ReadLine();
var monthsSavingFor = int.Parse(monthsSavingString);

// This is the result
var savings = deposit * Math.Pow(1 + (interestRateAsPercentage/100),monthsSavingFor);
Console.WriteLine("Your savings will be:");
Console.WriteLine($"${savings}");
