using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    public static class InputValidator
    {
        public static bool IsInputValid(string input)
        {
            string pattern = @"^\d+$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsOperationValid(string input)
        {
            string pattern1 = @"ADD";
            string pattern2 = @"SUB";
            string pattern3 = @"MUL";
            string pattern4 = @"DIV";
            var result1 = Regex.IsMatch(input, pattern1);
            var result2 = Regex.IsMatch(input, pattern2);
            var result3 = Regex.IsMatch(input, pattern3);
            var result4 = Regex.IsMatch(input, pattern4);

            if (result4 || result3 || result2 || result1)
            {
                return true;
            }
            else return false;
        }
    }
}
