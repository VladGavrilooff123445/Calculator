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
            string[] numbers = str.Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int result = 0;
            foreach (string num in numbers)
            {
                result += Convert.ToInt32(num);
            }
                
            string res = Convert.ToString(result);
               

            
            return res;
        }
    }
}
