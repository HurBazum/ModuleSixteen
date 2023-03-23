using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AdditionalSuccesfulTest()
        {
            var calculator = new ModuleSixteen.Calculator();
            Assert.That(calculator.Additional(10, 5) == 15);
        }
        [Test]
        public void AdditionalCallOverflowExceptionTest()
        {
            var calculator = new ModuleSixteen.Calculator();
            Assert.Throws<OverflowException>(() => calculator.Additional(int.MaxValue, int.MaxValue));
        }


        [Test]
        public void SubstractionSuccesfulTest()
        {
            var calculator = new ModuleSixteen.Calculator();
            Assert.That(calculator.Subtraction(10, 5) == 5);
        }
        [Test]
        public void SubstractionCallOverflowExceptionTest()
        {
            var calculator = new ModuleSixteen.Calculator();
            Assert.Throws<OverflowException>(() => calculator.Subtraction(int.MaxValue, int.MinValue));
        }


        [Test]
        public void MultiplicationSuccesfulTest()
        {
            var calculator = new ModuleSixteen.Calculator();
            Assert.That(calculator.Multiplication(10, 5) == 50);
        }
        [Test]
        public void MultiplicationCallOverflowExceptionTest()
        {
            var calculator = new ModuleSixteen.Calculator();
            Assert.Throws<OverflowException>(() => calculator.Additional(int.MaxValue, int.MaxValue));
        }


        [Test]
        public void DivisionSuccesfulTest()
        {
            var calculator = new ModuleSixteen.Calculator();
            Assert.That(calculator.Division(10, 5) == 2);
        }
        [Test]
        public void DivisionCallDivideByZeroExceptionTest()
        {
            var calculator = new ModuleSixteen.Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }
    }
}
