// Lesson 3: Savings Calculator

// This is the data collection 
Console.WriteLine("What is your initial deposit (please use numbers only)?");
var depositString = Console.ReadLine();
var deposit = int.Parse(depositString);

Console.WriteLine("What is the monthly interest rate (please use numbers only)?");
var interestRateString = Console.ReadLine();
var interestRateAsPercentage = double.Parse(interestRateString);

Console.WriteLine("How many months will you save for (please use numbers only)?");
var monthsSavingString = Console.ReadLine();
var monthsSavingFor = int.Parse(monthsSavingString);

// This is the result
var savings = deposit * Math.Pow(1 + (interestRateAsPercentage/100),monthsSavingFor);
Console.WriteLine("Your savings will be:");
Console.WriteLine($"${savings}");

// Extension activity
Console.WriteLine("Would you like to save for longer? How many additional months?");
var extraMonthsSavingString = Console.ReadLine();
var extraMonthsSaving = int.Parse(extraMonthsSavingString);

// This is the extra months result
var extraMonths = (monthsSavingFor + extraMonthsSaving);
var savings2 = (deposit * Math.Pow(1 + (interestRateAsPercentage/100),extraMonths)); 
Console.WriteLine($"Saving for {extraMonths} months in total, means your saving will now be:");
Console.WriteLine($"${savings2}");

// This is the extra years result
Console.WriteLine("Would you like to save for longer? How many years in total?");
var yearsSavingString = Console.ReadLine();
var yearsSavingFor = int.Parse(yearsSavingString);

var yearsInMonths = (yearsSavingFor * 12);
var savingsYears = deposit * Math.Pow(1 + (interestRateAsPercentage/100),yearsInMonths);
Console.WriteLine($"Saving for {yearsSavingFor} years, means your savings will now be:");
Console.WriteLine($"${savingsYears}");