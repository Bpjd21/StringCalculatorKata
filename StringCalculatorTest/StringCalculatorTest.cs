using StringCalculatorKata;
using System;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTest
    {
        private StringCalculator underTest;

        public StringCalculatorTest()
        {
            underTest = new StringCalculator();
        }

        [Fact]
        public void Add_Returns_Zero_for_Empty_String()
        {          
            var result = underTest.Add("");

            Assert.Equal(0, result);
        }

        [Theory()]       
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void Add_Returns_Expected_Output(string input, int expected)
        {
            var result = underTest.Add(input);

            Assert.Equal(expected, result);
        }

        //[Fact]
        //public void Add_Returns_1_for_1()
        //{
        //    var result = underTest.Add("1");

        //    Assert.Equal(1, result);
        //}

        //[Fact]
        //public void Add_Returns_2_for_2()
        //{
        //    var result = underTest.Add("2");

        //    Assert.Equal(2, result);
        //}


    }
}
