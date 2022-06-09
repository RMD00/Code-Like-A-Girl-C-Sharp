// Lesson 6 Acivity - Basic Calculator

while (true)
    {
        Console.WriteLine("Please enter your first number");
        var firstNo = double.Parse(Console.ReadLine());
                            
        Console.WriteLine("Please enter an operation (+, /, raise to the power)");
        var chosenOperator = Console.ReadLine();

        Console.WriteLine("Please enter your second number");
        var secondNo = double.Parse(Console.ReadLine());
        
        switch (chosenOperator)
        {
            case "+":
                var resultAdd = Add(firstNo, secondNo);
                break;

            case "/":
                var resultDiv = Div(firstNo, secondNo);
                break;

            case "raise to the power":
                var resultPow = Pow(firstNo, secondNo);
                break;
        }
    }

        double Add(double firstNo, double secondNo)
        {
            var add = firstNo + secondNo;
            Console.WriteLine($"{firstNo} + {secondNo} = {add}");
            return add; 
        }

        double Div(double firstNo, double secondNo)
        {
            var div = firstNo / secondNo;
            Console.WriteLine($"{firstNo} / {secondNo} = {div}");
            return div; 
        }

        double Pow(double firstNo, double secondNo)
        {
            var pow = Math.Pow(firstNo, secondNo);
            Console.WriteLine($"{firstNo} to the power of {secondNo} = {pow}");
            return pow; 
        }