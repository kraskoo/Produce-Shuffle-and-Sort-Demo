namespace SortArray
{
    using System;

    /// <summary>
    /// Probably the best explanation, I ever seen
    /// https://www.youtube.com/watch?v=kPRA0W1kECg
    /// </summary>
    public interface ISortable
    {
        void Sort<T>(T[] itemsToSort) where T : IComparable<T>;
    }
}