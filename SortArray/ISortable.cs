namespace SortArray
{
    using System;

    public interface ISortable
    {
        void Sort<T>(T[] itemsToSort) where T : IComparable<T>;
    }
}