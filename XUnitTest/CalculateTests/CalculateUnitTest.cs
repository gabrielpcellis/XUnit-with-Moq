using System;
using Xunit;
using Calculators.XUnitTestMoq;
using Moq;

namespace CalculateTests.XUnitTest
{
    public class CalculateUnitTest
    {
        [Fact]
        public void Sum_Two_Numbers()
        {
            // Arrange
            Moq.Mock<ICalculator> mock = new Moq.Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("sum", 7.7));
            CalculatorMachine machine = new CalculatorMachine(mock.Object);
            // Act
            (string operation, double result) op = machine.Calculate("sum", 3.2, 4.5);
            // Assert
            Assert.Equal("sum", op.operation);
            Assert.Equal(7.7, op.result);
        }

        [Fact]
        public void Subtract_Two_Numbers()
        {
            // Arrange
            Moq.Mock<ICalculator> mock = new Moq.Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("subtract", -1.3));
            CalculatorMachine maqCalc = new CalculatorMachine(mock.Object);
            // Act
            (string operation, double result) op = maqCalc.Calculate("subtract", 3.2, 4.5);
            // Assert
            Assert.Equal("subtract", op.operation);
            Assert.Equal(-1.3, op.result);
        }
        [Fact]
        public void Multiply_Two_Numbers()
        {
            // Arrange
            Moq.Mock<ICalculator> mock = new Moq.Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("multiply", 14.4));
            CalculatorMachine maqCalc = new CalculatorMachine(mock.Object);
            // Act
            (string operation, double result) op = maqCalc.Calculate("multiply", 3.2, 4.5);
            // Assert
            Assert.Equal("multiply", op.operation);
            Assert.Equal(14.4, op.result);
        }
        [Fact]
        public void Divide_Two_Numbers()
        {
            // Arrange
            Moq.Mock<ICalculator> mock = new Moq.Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("divide", 0.71));
            CalculatorMachine maqCalc = new CalculatorMachine(mock.Object);
            // Act
            (string operation, double result) op = maqCalc.Calculate("multiply", 3.2, 4.5);
            // Assert
            Assert.Equal("divide", op.operation);
            Assert.Equal(0.71, op.result);
        }
    }

}
