namespace SortArray
{
    using System;

    public class QuickSort : ISortable
    {
        public void Sort<T>(T[] itemsToSort) where T : IComparable<T>
        {
            this.Sort(itemsToSort, 0, itemsToSort.Length - 1);
        }

        private void Sort<T>(T[] itemsToSort, int left, int right) where T : IComparable<T>
        {
            if (left >= right)
            {
                return;
            }

            T pivot = itemsToSort[((left + right) / 2)];
            int index = Partition(itemsToSort, left, right, pivot);
            this.Sort(itemsToSort, left, index - 1);
            this.Sort(itemsToSort, index, right);
        }

        private int Partition<T>(T[] itemsToSort, int leftIndex, int rightIndex, T pivot) where T : IComparable<T>
        {
            while (leftIndex <= rightIndex)
            {
                while (itemsToSort[leftIndex].CompareTo(pivot) < 0)
                {
                    leftIndex++;
                }

                while (itemsToSort[rightIndex].CompareTo(pivot) > 0)
                {
                    rightIndex--;
                }

                if (leftIndex <= rightIndex)
                {
                    this.Swap(itemsToSort, leftIndex, rightIndex);
                    leftIndex++;
                    rightIndex--;
                }
            }

            return leftIndex;
        }

        private void Swap<T>(
            T[] itemsToSort, int leftIndex, int rightIndex) where T : IComparable<T>
        {
            T temp = itemsToSort[leftIndex];
            itemsToSort[leftIndex] = itemsToSort[rightIndex];
            itemsToSort[rightIndex] = temp;
        }
    }
}