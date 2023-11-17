using Xunit;
using System;

namespace SimpleCalculator.Test.Unit
{
    public class InputConverterTests
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [Fact]
        public void ConvertValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);

            Assert.Equal(5, convertedNumber);
        }

        [Fact]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            var exception = Record.Exception(() => _inputConverter.ConvertInputToNumeric(inputNumber));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
        }
    }
}