namespace MAY2024JoseMariJaysonCayabyab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class MergeSort1
    {
        public static string MergeSort(string text)
        {
            char[] charArray = text.ToCharArray();
            MergeSort(charArray, 0, charArray.Length - 1);
            return new string(charArray);
        }

        private static void MergeSort(char[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + ((right - left) / 2);
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        private static void Merge(char[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            char[] l = new char[n1];
            char[] r = new char[n2];

            for (int o = 0; o < n1; ++o)
            {
                l[o] = array[left + o];
            }

            for (int p = 0; p < n2; ++p)
            {
                r[p] = array[middle + 1 + p];
            }

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                // Change the condition to sort uppercase letters before lowercase
                if (char.ToUpper(l[i]) < char.ToUpper(r[j]) || (char.ToUpper(l[i]) == char.ToUpper(r[j]) && char.IsUpper(l[i]) && char.IsLower(r[j])))
                {
                    array[k] = l[i];
                    i++;
                }
                else
                {
                    array[k] = r[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                array[k] = l[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = r[j];
                j++;
                k++;
            }
        }
    }
}