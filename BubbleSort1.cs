namespace MAY2024JoseMariJaysonCayabyab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class BubbleSort1
    {
        public static string BubbleSort(string text)
        {
            char temp;
            char[] charstr = text.ToCharArray();

            for (int i = 0; i < charstr.Length - 1; i++)
            {
                for (int j = 0; j < charstr.Length - i - 1; j++)
                {
                    // Check if the current character should be swapped with the next one
                    // First, compare the characters as uppercase to sort alphabetically
                    if (char.ToUpper(charstr[j]) > char.ToUpper(charstr[j + 1]))
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }

                    // sort such that uppercase comes before lowercase
                    else if (char.ToUpper(charstr[j]) == char.ToUpper(charstr[j + 1]) && char.IsLower(charstr[j]) && char.IsUpper(charstr[j + 1]))
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }

            return new string(charstr);
        }
    }
}
