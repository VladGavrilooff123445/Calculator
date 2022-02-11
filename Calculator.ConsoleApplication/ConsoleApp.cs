using Calculator.Logic;

namespace Calculator.ConsoleApplication
{
    public class ConsoleApp
    {
        private const string FirstMessage = "Enter comma separated numbers";
        private const string ChoiceMessage = "Press esc to exit or enter to continue";        
        private string _numbers;
        private int _result = 0;
        private bool _pressESC = false;
        private StringCalculator calculate;
        private ConsoleService serviceConsole;


        public ConsoleApp(ConsoleService consoleService, StringCalculator calculator)
        {
            serviceConsole = consoleService;
            calculate = calculator;
        }

        public void UsingUI()
        {
            while (true)
            {
                serviceConsole.WriteLine(FirstMessage);
             
                _numbers = serviceConsole.ReadLine();
                _result = calculate.Add(_numbers);

                serviceConsole.WriteLine($"Result is: {_result}");
                serviceConsole.WriteLine(ChoiceMessage);

                _pressESC = serviceConsole.IsESCPressed();

                if (_pressESC)
                {
                    break;
                }

            }
        }

    }
}

