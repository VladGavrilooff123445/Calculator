using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    public class Calculator
    {
        public string Add(string str)
        {
            string[] numbers = str.Split(new char[] { '+' });
            foreach (string s in numbers)
            {
                Console.WriteLine(s);
            }
            return "That's all";
        }
    }
}
