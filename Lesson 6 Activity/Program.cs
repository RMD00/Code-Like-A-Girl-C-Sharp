// Lesson 6 Acivity - Basic Calculator
while (true)
{
    Console.WriteLine("Please enter your first number");
    var firstNumber = Console.ReadLine();
    var firstInteger = double.Parse(firstNumber); // how do I do the .IsNullOrEmpty?

    Console.WriteLine("Please enter an operation (+, /, raise to the power)");
    var chosenOperator = Console.ReadLine();

    Console.WriteLine("Please enter your second number");
    var secondNumber = Console.ReadLine();
    var secondInteger = double.Parse(secondNumber); // how do I do the .IsNullOrEmpty?

    switch (chosenOperator)
        {
            case "+":
            var result = Add(firstInteger, secondInteger);
            break;
        }
}

double Add(double firstInteger, double secondInteger);
    {
        var add = firstInteger + secondInteger;
        Console.WriteLine($"{firstInteger} + {secondInteger} = {add}");
        return add;
    }

