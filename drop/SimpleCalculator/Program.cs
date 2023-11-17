using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                double firstNumber, secondNumber;

                Console.Write("First number: ");
                firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Second number: ");
                secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Operation: ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
