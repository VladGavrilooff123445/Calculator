using System;

namespace CalculatorLogic
{
    public class Calculator
    {
        
        public int Add(string str)
        {
            if (str.EndsWith("\n"))
            {
                return 0;
            }


            if (str.StartsWith("//"))
            {
                string[] cust = str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string[] delimiters = cust[0].Split(new char[] { '[', ']', '/' }, StringSplitOptions.RemoveEmptyEntries);

                

                
                


                string[] numbers = cust[1].Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                

                int result = 0;

                foreach (string num in numbers)
                {
                    if (num.StartsWith("-"))
                    {
                        throw new Exception("negatives not allowed");
                    }


                    if (!(Convert.ToInt32(num) >= 1000))
                    {
                        result += Convert.ToInt32(num);
                    }

                }

                return result;
            }

            else
            {

                char[] delimiters = { ',' };
                string[] numbers = str.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                int result = 0;

                foreach (string num in numbers)
                {
                    if (num.StartsWith("-"))
                    {
                        throw new Exception("negatives not allowed");
                    }


                    if ((Convert.ToInt32(num) >= 1000) == false)
                    {
                        result += Convert.ToInt32(num);
                    }

                }

                return result;
            }

            
        }
    }
}
