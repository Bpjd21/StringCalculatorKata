using StringCalculatorKata;
using System;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Add_Returns_Zero_for_Empty_String()
        {
            var underTest = new StringCalculator();

            var result = underTest.Add("");

            Assert.Equal(0, result);

        }
    }
}
