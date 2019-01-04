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
            var splitter = Convert.ToChar(",");

            string[] elements;
            elements = input.Split(splitter);

            int elementsLen = 0;
            if (elements.Length > 0 && elements[0]!="")
            {
                elementsLen = elements.Length;

                var i = 0;

                for (i = 0; i < elementsLen; i++)
                {
                    int result;
                    bool parsed = int.TryParse(elements[i], out result);


                    if (parsed == false)

                        return false;
                    else
                    {
                        if (result < 0)
                        {
                            error = "negatives not allowed";
                            return false;
                        }
                    }

                }

                //error = null;
                return true;
            }
            else if (elements.Length == 1 && elements[0] == "")
                return true;
            else
                return false;

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

            return "0";
        }
    }
}