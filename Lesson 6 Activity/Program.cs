// Lesson 6 Acivity - Basic Calculator

while (true)
{
    Console.WriteLine("Please enter your first number");
    var firstNumber = Console.ReadLine();
    var firstDouble = double.Parse(firstNumber); // how do I do the .IsNullOrEmpty?

    Console.WriteLine("Please enter an operation (+, /, raise to the power)");
    var chosenOperator = Console.ReadLine();

    Console.WriteLine("Please enter your second number");
    var secondNumber = Console.ReadLine();
    var secondDouble = double.Parse(secondNumber); // how do I do the .IsNullOrEmpty?

    switch (chosenOperator)
        {
            case "+":
            var result = Add(firstDouble, secondDouble);
            break;
        }
        
    static extern double Add(double firstDouble, double secondDouble);
    {
        var add = firstDouble + secondDouble;
        Console.WriteLine($"{firstDouble} + {secondDouble} = {add}");
    }
}



