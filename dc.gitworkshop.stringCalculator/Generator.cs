using System;

namespace dc.gitworkshop.stringCalculator
{
    public class Generator
    {
        public static string Random(int count, string delimiter, bool allowNegatives = false)
        {
            if (count <= 0)
                throw new Exception("Variable count must be greater than 0.");

            Random r = new Random();
            string result = "";
           

            for (int i = 0; i < count; i++)
            {
                int j = (allowNegatives == true ? r.Next(-10000, 10000) : r.Next(0, 10000));
                result += j.ToString() + (i == count - 1 ? "" : delimiter);
            }

            return result;
        }
    }
}