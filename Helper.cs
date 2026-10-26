namespace Session_10
{
    internal class Helper<T> where T : IComparable<T>
    {
        public static void Swap(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        // Optimized Bubble Sort
        // 1) swapped flag: if a full pass has no swaps the array is already sorted, so we stop
        // 2) the biggest element goes to its place after each pass, so the inner loop gets shorter (arr.Length - i - 1)
        // Worst case is still O(N^2) but the best case (sorted array) becomes O(N)
        public static void BubbleSort(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool swapped = false;

                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }
    }
}
