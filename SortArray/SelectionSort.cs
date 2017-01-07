namespace SortArray
{
    using System;

    public class SelectionSort : ISortable
    {
        public void Sort<T>(T[] itemsToSort) where T : IComparable<T>
        {
            for (int index = 0; index < itemsToSort.Length; index++)
            {
                int min = index;
                for (int nextIndex = index + 1; nextIndex < itemsToSort.Length; nextIndex++)
                {
                    if (itemsToSort[min].CompareTo(itemsToSort[nextIndex]) > 0)
                    {
                        min = nextIndex;
                    }
                }

                if (min != index)
                {
                    T temp = itemsToSort[index];
                    itemsToSort[index] = itemsToSort[min];
                    itemsToSort[min] = temp;
                }
            }
        }
    }
}