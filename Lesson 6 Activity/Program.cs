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
                var resultAdd = Add(firstDouble, secondDouble);
                break;

            case "/":
                var resultDiv = Div(firstDouble, secondDouble);
                break;

            case "raise to the power":
                var resultPow = Pow(firstDouble, secondDouble);
                break;
        }

        static extern double Add(double firstDouble, double secondDouble);
        {
            var add = firstDouble + secondDouble;
            Console.WriteLine($"{firstDouble} + {secondDouble} = {add}");
            return add;
        }

        static extern double Div(double firstDouble, double secondDouble);
        {
            var div = firstDouble / secondDouble;
            Console.WriteLine($"{firstDouble} / {secondDouble} = {div}");
            return div;
        }

        static extern double Pow(double firstDouble, double secondDouble);
        {
            var pow = Math.Pow(firstDouble, secondDouble);
            Console.WriteLine($"{firstDouble} to the power of {secondDouble} = {pow}");
            return pow;
        }
    }