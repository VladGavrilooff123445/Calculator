using Calculator.ConsoleApplication;
using Calculator.Logic;
using System;

namespace Calculator.ConsoleAplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calculator = new StringCalculator();
            var service = new ConsoleService();
            var app = new ConsoleApp(service, calculator);
            
            app.UsingUI();
        }
    }
}

