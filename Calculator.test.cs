using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator;

namespace calc.test
{
    public class CalculatorTest
    {
        //Addition
        [Theory]
        [InlineData(26, 14, 12)]
        [InlineData(0, 0, 0)]
        [InlineData(14, 14, 0)]
        [InlineData(0, 14, -14)]
        [InlineData(26, 38, -12)]
        public void addCheck(double expected, double num1, double num2)
        {
            double result = Calculator_.add( num1, num2 );
            Assert.Equal(expected, result);
        }
        //Addition with array
        [Theory]
        [MemberData(nameof(additionData))]
        public void addArrayCheck(double expected, params double[] addArray)
        {
            double num1 = addArray[0];
            double num2 = 0;
            for (int i = 1; i < addArray.Length; i++)
            {
                num2 += addArray[i];
            }
            double result = Calculator_.add(num1, num2);
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> additionData()
        {
            yield return new object[] { 12, new double[] { 1, 2, 3, 4, 3, -1 } };
            yield return new object[] { 12, new double[] { 6, 6 } };
            yield return new object[] { 12, new double[] { 12, 0, 0, 0 } };
        }

        //Subtraction
        [Theory]
        [InlineData(2, 14, 12)]
        [InlineData(0, 0, 0)]
        [InlineData(14, 14, 0)]
        [InlineData(28, 14, -14)]
        [InlineData(50, 38, -12)]
        public void subCheck(double expected, double num1, double num2)
        {
            double result = Calculator_.sub(num1, num2);
            Assert.Equal(expected, result);
        }
        //Subtraction with array
        [Theory]
        [MemberData(nameof(subtractionData))]
        public void subArrayCheck(double expected, params double[] subArray)
        {
            double num1 = subArray[0];
            double num2 = 0;
            for (int i = 1; i < subArray.Length; i++)
            {
                num2 += subArray[i];
            }
            double result = Calculator_.sub(num1, num2);
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> subtractionData()
        {
            yield return new object[] { -10, new double[] { 1, 2, 3, 4, 3, -1 } };
            yield return new object[] { 0, new double[] { 6, 6 } };
            yield return new object[] { 12, new double[] { 12, 0, 0, 0 } };
        }

        //Multiplication
        [Theory]
        [InlineData(144, 12, 12)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 14, 0)]
        [InlineData(-144, 12, -12)]
        [InlineData(36, -6, -6)]
        public void multCheck(double expected, double num1, double num2)
        {
            double result = Calculator_.mult(num1, num2);
            Assert.Equal(expected, result);
        }

        //Division
        [Theory]
        [InlineData(1, 12, 12)]
        [InlineData(0, 0, 14)]
        [InlineData(0, 14, 0)]
        [InlineData(-1, 14, -14)]
        [InlineData(1, -12, -12)]
        public void divCheck(double expected, double num1, double num2)
        {
            double result = Calculator_.div(num1, num2);
            Assert.Equal(expected, result);
        }
    }
}
