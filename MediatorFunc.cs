namespace MAY2024JoseMariJaysonCayabyab
{
    internal class MediatorFunc
    {
        public static string SelectorFunction(string userSelection, string userValue)
        {
            string sortedValue = string.Empty;

            // Checks which sorting algorithm was selected by the user
            if (userValue == string.Empty)
            {
                sortedValue = "Please input at least 2 characters";
            }
            else if (string.Equals(userSelection, "BubbleSort", StringComparison.OrdinalIgnoreCase))
            {
                // Store the Bubble sorted text in sortedValue variable
                sortedValue = BubbleSort1.BubbleSort(userValue);
            }
            else if (string.Equals(userSelection, "MergeSort", StringComparison.OrdinalIgnoreCase))
            {
                // Store the Merge sorted text in sortedValue variable
                sortedValue = MergeSort1.MergeSort(userValue);
            }
            else
            {
                // Handle unexpected input
                MessageBox.Show("Select a Sorting Algorithm");
            }

            return sortedValue;
        }
    }
}
