using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string input)
        {
            double convertedNumber;
            bool isConversionSuccessfull = double.TryParse(input, out convertedNumber);

            if (!isConversionSuccessfull)
            {
                throw new ArgumentException("Expected a numeric value.");
            }

            return convertedNumber;
        }
    }
}