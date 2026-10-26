namespace Session_10
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count;

        public int Capacity { get; }

        public FixedSizeList(int capacity)
        {
            Capacity = capacity;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == Capacity)
                throw new InvalidOperationException($"The list is full, capacity is {Capacity}");

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException($"Invalid index {index}, the list has {count} element(s)");

            return items[index];
        }
    }
}
