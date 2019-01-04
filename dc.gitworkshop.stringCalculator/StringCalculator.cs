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
            int y=0;
            string[] table;
            table = input.Split(',');
            if (input.Length != 0)
            {
                for (int i = 0; i < table.Length; i++)
                {
                    int parsed;
                    if (int.TryParse(table[i], out parsed))
                    {
                        y += parsed;
                    }

                }
            }
            return y.ToString();
        }
    }
}