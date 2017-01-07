namespace SortArray
{
    using System;

    public class BubbleSort : ISortable
    {
        public void Sort<T>(T[] itemsToSort) where T : IComparable<T>
        {
            bool hasSwapped;
            do
            {
                hasSwapped = false;
                for (int index = 0; index < itemsToSort.Length; index++)
                {
                    for (int nextIndex = index + 1; nextIndex < itemsToSort.Length; nextIndex++)
                    {
                        if (itemsToSort[index].CompareTo(itemsToSort[nextIndex]) > 0)
                        {
                            T temp = itemsToSort[index];
                            itemsToSort[index] = itemsToSort[nextIndex];
                            itemsToSort[nextIndex] = temp;
                            hasSwapped = true;
                        }
                    }
                }
            } while (!hasSwapped);
        }
    }
}