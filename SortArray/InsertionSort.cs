namespace SortArray
{
    using System;

    public class InsertionSort : ISortable
    {
        public void Sort<T>(T[] itemsToSort) where T : IComparable<T>
        {
            T[] sortedItems = new T[itemsToSort.Length];
            sortedItems[0] = itemsToSort[0];
            int sortedItemsCount = 1;
            do
            {
                if (sortedItemsCount < itemsToSort.Length)
                {
                    T nextItem = itemsToSort[sortedItemsCount];
                    this.MakeInsertion(nextItem, sortedItemsCount, sortedItems);
                }

                sortedItemsCount++;
            } while (sortedItemsCount != itemsToSort.Length);
            sortedItems.CopyTo(itemsToSort, 0);
        }

        private void MakeInsertion<T>(
            T nextItem, int sortedItemsCount, T[] sortedItems) where T : IComparable<T>
        {
            int max = sortedItemsCount;
            for (int index = sortedItemsCount - 1; index > -1; index--)
            {
                if (nextItem.CompareTo(sortedItems[index]) < 0)
                {
                    max = index;
                }
            }

            if (max != sortedItemsCount)
            {
                for (int index = sortedItemsCount; index > max; index--)
                {
                    sortedItems[index] = sortedItems[index - 1];
                }

                sortedItems[max] = nextItem;
            }
            else
            {
                sortedItems[sortedItemsCount] = nextItem;
            }
        }
    }
}