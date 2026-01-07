namespace learn_object_oriented_programming_in_c_sharp
{
    public class Calculator
    {
        public void Run()
        {
            Console.WriteLine("======================================= Simple Calculator =======================================");

            // Taking input from the user
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation: +, -, *, /, %");
            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            double result = 0;

            // Switch to perform operation
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;

                case "/":
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                    else
                        Console.WriteLine("Error: Division by zero!");
                    break;

                case "%":
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1} % {num2} = {num1 % num2}");
                    else
                        Console.WriteLine("Error: Division by zero!");
                    break;

                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }
        }
    }
}
