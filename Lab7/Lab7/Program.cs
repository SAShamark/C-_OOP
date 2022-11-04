namespace Lab7
{
    public static class Task4
    {
        private static void Main()
        {
            Console.WriteLine("Set some checker number");
            var checkNumber = int.Parse(Console.ReadLine());

            var intNumbersList = new List<int>
            {
                7,
                4
            };


            FillingList(intNumbersList);
            SearchCorrespondingIndexes(intNumbersList, checkNumber);
            
            int[] intNumbersArray = Array.Empty<int>();
            
            ConvertListToArray(intNumbersList, intNumbersArray);
        }

        private static void FillingList(ICollection<int> intNumbers)
        {
            Console.WriteLine("Complete the list with numbers");
            Console.WriteLine("Just press (ENTER) to finish filling");
            while (true)
            {
                var newElement = Console.ReadLine();

                if (newElement == string.Empty)
                {
                    break;
                }

                intNumbers.Add(int.Parse(newElement));
            }
        }

        private static void SearchCorrespondingIndexes(IReadOnlyList<int> intNumbers, int checkNumber)
        {
            Console.WriteLine("Corresponding indexes of List with the check");

            for (var i = 0; i < intNumbers.Count; i++)
            {
                var number = intNumbers[i];
                if (number == checkNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void ConvertListToArray(List<int> intList, int[] intArray)
        {
            intArray = new int[intList.Count];
            
            int i = 0;
            
            foreach (var intNumber in intList)
            {
                intArray[i++] = intNumber;
            }
            
            Console.WriteLine("New Array");
            foreach (var intNumber in intArray)
            {
                Console.WriteLine(intNumber);
            }
        }
    }
}