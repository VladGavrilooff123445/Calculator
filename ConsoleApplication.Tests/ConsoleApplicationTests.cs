using Calculator.ConsoleApplication;
using Calculator.Logic;
using NUnit.Framework;


namespace CalculatorUI.Tests
{
    public class ConsoleApplicationTests
    {
        private ConsoleApp app;
        private StringCalculator calculate;
        private ConsoleService service;

        public ConsoleApplicationTests(ConsoleService consoleService, StringCalculator calculator)
        {
            calculate = calculator;
            service = consoleService;
            app = new ConsoleApp(service, calculate);
        }


        
        
    }
}