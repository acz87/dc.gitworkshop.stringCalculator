using System;

namespace dc.gitworkshop.stringCalculator
{
    public class StringCalculator
    {
        public static string Compute(string input)
        {
            var isok = Validate(input, out string error);
            if (isok)
            {
                return Sum(input);
            }
            else
            {
                return error;
            }
        }

        private static bool Validate(string input, out string error)
        {
            error = null;
            return true;
        }

        private static string Sum(string input)
        {
            return "0";
        }
    }
}