using Moq;
using Calculator.ConsoleApplication;
using Calculator.Logic;
using NUnit.Framework;


namespace CalculatorUI.Tests
{
    public class ConsoleApplicationTests
    {
        private ConsoleApp app;

        [Test]
        public void UsingUI_ShouldReturnConsoleReadLine()
        {
            // ARRANGE
            var consoleServiceMock = new Mock<ConsoleService>();
            consoleServiceMock.Setup(_ => _.WriteLine("Enter comma separated numbers"));
            consoleServiceMock.Setup(_ => _.ReadLine()).Returns("1,2,3,4");

            var consoleCalculatorMock = new Mock<StringCalculator>();
            consoleCalculatorMock.Setup(_ => _.Add("1,2,3,4")).Returns(10);

            consoleServiceMock.Setup(_ => _.WriteLine($"Result is: {10}"));

            consoleServiceMock.Setup(_ => _.IsESCPressed()).Returns(true);

            app = new ConsoleApp(consoleServiceMock.Object, consoleCalculatorMock.Object);

            // ACT
            app.UsingUI();

            // ASSERT
            consoleServiceMock.Verify(_ => _.ReadLine(), Times.Once);
            consoleServiceMock.Verify(_ => _.WriteLine("Enter comma separated numbers"), Times.Once);
            consoleServiceMock.Verify(_ => _.IsESCPressed(), Times.Once);
        }


    }
}