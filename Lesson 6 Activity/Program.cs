// Lesson 6 Acivity - Basic Calculator

Console.WriteLine("Please enter your first number");
var firstNumber = Console.ReadLine();
var firstInteger = double.Parse(firstNumber);

Console.WriteLine("Please enter an operation (+, /, raise to the power)");
var chosenOperator = Console.ReadLine();

Console.WriteLine("Please enter your second number");
var secondNumber = Console.ReadLine();
var secondInteger = double.Parse(secondNumber);

{
switch (chosenOperator)
    {
        case "+":
            {
                // code to execute
                var a = firstInteger + secondInteger;
                Console.WriteLine($"{firstInteger} + {secondInteger} = {a}");
                break;
            }
        case "/":
            {
                // code to execute
                var d = firstInteger/secondInteger;
                Console.WriteLine($"{firstInteger} / {secondInteger} = {d}");
                break;
            }
        case "raise to the power":
            {
                // code to execute
                var p = Math.Pow(firstInteger, secondInteger);
                Console.WriteLine($"{firstInteger} to the power of {secondInteger} = {p}");
                break;
            }
    }

static int Add(int firstInteger, int secondInteger)
    {
        return (firstInteger + secondInteger);
        Console.WriteLine ("test");
    }
}