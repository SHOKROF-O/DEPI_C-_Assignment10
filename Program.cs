using System.Collections;

namespace Session_10
{
    internal class Program
    {
        #region Q3 Reverse ArrayList
        static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object? temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
        #endregion

        #region Q4 Even Numbers
        static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    result.Add(num);
            }

            return result;
        }
        #endregion

        #region Q6 First Non-Repeated Character
        static int FirstNonRepeatedChar(string str)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts.Add(c, 1);
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (counts[str[i]] == 1)
                    return i;
            }

            return -1;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1 (Optimized Bubble Sort is in Helper.cs)
            int[] arr = { 5, 3, 8, 1, 9, 2 };
            Helper<int>.BubbleSort(arr);
            foreach (int item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
            #endregion

            #region Q2
            Range<int> intRange = new Range<int>(10, 50);
            Console.WriteLine(intRange.IsInRange(30));   // True
            Console.WriteLine(intRange.IsInRange(60));   // False
            Console.WriteLine(intRange.Length());        // 40

            Range<double> doubleRange = new Range<double>(1.5, 4.5);
            Console.WriteLine(doubleRange.IsInRange(2.2)); // True
            Console.WriteLine(doubleRange.Length());       // 3
            #endregion

            #region Q3
            ArrayList list = new ArrayList() { 1, "two", 3.5, 'D', 5 };
            ReverseArrayList(list);
            foreach (var item in list)
                Console.Write(item + " ");
            Console.WriteLine();
            #endregion

            #region Q4
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evens = GetEvenNumbers(numbers);
            foreach (int item in evens)
                Console.Write(item + " ");
            Console.WriteLine();
            #endregion

            #region Q5
            FixedSizeList<string> names = new FixedSizeList<string>(2);
            names.Add("Omar");
            names.Add("Ali");

            Console.WriteLine(names.Get(1));

            try
            {
                names.Add("Ahmed");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                names.Get(5);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Q6
            Console.WriteLine(FirstNonRepeatedChar("leetcode"));     // 0
            Console.WriteLine(FirstNonRepeatedChar("loveleetcode")); // 2
            Console.WriteLine(FirstNonRepeatedChar("aabb"));         // -1
            #endregion
        }
    }
}
