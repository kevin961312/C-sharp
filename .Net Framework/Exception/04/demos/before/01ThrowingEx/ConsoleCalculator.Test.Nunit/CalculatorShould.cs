using System;
using NUnit.Framework;

namespace ConsoleCalculator.Test.Nunit
{
    public class CalculatorShould
    {
        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Calculate(1, 1, "+"),
                Throws.TypeOf<CalculationOperationNotSupportedException>());
            Assert.That(() => sut.Calculate(1, 1, "+"),
                Throws.TypeOf<CalculationOperationNotSupportedException>()
                .With
                .Property("Operation").EqualTo("+"));
        }
    }
}
