namespace SortArray
{
    using System;

    public class MergeSort : ISortable
    {
        public void Sort<T>(T[] itemsToSort) where T : IComparable<T>
        {
            this.Sort(itemsToSort, new T[itemsToSort.Length], 0, itemsToSort.Length - 1);
        }

        private void Sort<T>(
            T[] itemsToSort, T[] temporary, int startIndex, int endIndex) where T : IComparable<T>
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int middleIndex = (startIndex + endIndex) / 2;
            this.Sort(itemsToSort, temporary, startIndex, middleIndex);
            this.Sort(itemsToSort, temporary, middleIndex + 1, endIndex);
            this.Merge(itemsToSort, temporary, startIndex, endIndex);
        }

        private void Merge<T>(
            T[] itemsToSort, T[] temporary, int startIndex, int endIndex) where T : IComparable<T>
        {
            int middleIndex = (endIndex + startIndex) / 2;
            int rightStartIndex = middleIndex + 1;
            int size = endIndex - startIndex + 1;

            int leftIndex = startIndex;
            int rightIndex = rightStartIndex;
            int index = leftIndex;
            while (leftIndex <= middleIndex && rightIndex <= endIndex)
            {
                if (itemsToSort[leftIndex].CompareTo(itemsToSort[rightIndex]) <= 0)
                {
                    temporary[index] = itemsToSort[leftIndex];
                    leftIndex++;
                }
                else
                {
                    temporary[index] = itemsToSort[rightIndex];
                    rightIndex++;
                }

                index++;
            }

            Array.Copy(itemsToSort, leftIndex, temporary, index, middleIndex - leftIndex + 1);
            Array.Copy(itemsToSort, rightIndex, temporary, index, endIndex - rightIndex + 1);
            Array.Copy(temporary, startIndex, itemsToSort, startIndex, size);
        }
    }
}