namespace SortPlay
{
    using System;
    using System.Diagnostics;
    using SortArray;
    using System.Text;

    /// <summary>
    /// Handle unsorted sequence of elements and produce output result with timestamp comparison
    /// </summary>
    public static class SortComparativeContext
    {
        private static readonly StringBuilder Output = new StringBuilder();
        private static readonly Stopwatch StopWatch = new Stopwatch();

        public static string GetResults<T>(
            this T[] items, bool toShowItems = false) where T : IComparable<T>
        {
            Output.Clear();
            #region Unsorted sequence
            if (toShowItems)
            {
                Output.AppendLine(
                    $"Unsorted numbers:{Environment.NewLine}{string.Join(", ", items)}");
            }
            #endregion
            #region Bubble Sort
            items.Sort(new BubbleSort());
            if (toShowItems)
            {
                Output.AppendLine(
                    $"{items.GetResultFromSortArray()}");
            }

            Output.AppendLine($"Bubble Sort elapsed time:    {StopWatch.ElapsedTicks}");
            StopWatch.Restart();
            #endregion
            #region Selection Sort
            items.Sort(new SelectionSort());
            if (toShowItems)
            {
                Output.AppendLine(
                    $"{items.GetResultFromSortArray()}");
            }

            Output.AppendLine($"Selection Sort elapsed time: {StopWatch.ElapsedTicks}");
            StopWatch.Restart();
            #endregion
            #region Insertion Sort
            items.Sort(new InsertionSort());
            if (toShowItems)
            {
                Output.AppendLine(
                    $"{items.GetResultFromSortArray()}");
            }

            Output.AppendLine($"Insertion Sort elapsed time: {StopWatch.ElapsedTicks}");
            StopWatch.Restart();
            #endregion
            #region Merge Sort
            items.Sort(new MergeSort());
            if (toShowItems)
            {
                Output.AppendLine(
                    $"{items.GetResultFromSortArray()}");
            }

            Output.AppendLine($"Merge Sort elapsed time:     {StopWatch.ElapsedTicks}");
            StopWatch.Restart();
            #endregion
            #region Quick Sort
            items.Sort(new QuickSort());
            if (toShowItems)
            {
                Output.AppendLine(
                    $"{items.GetResultFromSortArray()}");
            }

            Output.Append($"Quick Sort elapsed time:     {StopWatch.ElapsedTicks}");
            StopWatch.Restart();
            #endregion
            return Output.ToString();
        }

        private static void Sort<T>(
            this T[] items, ISortable sortableStrategy) where T : IComparable<T>
        {
            T[] copy = items.CopyArray();
            StopWatch.Start();
            sortableStrategy.Sort(copy);
            StopWatch.Stop();
        }

        private static string GetResultFromSortArray<T>(
            this T[] items) where T : IComparable<T>
        {
            return $"{Environment.NewLine}{string.Join(", ", items)}";
        }

        private static T[] CopyArray<T>(this T[] items) where T : IComparable<T>
        {
            T[] copyOfItems = new T[items.Length];
            items.CopyTo(copyOfItems, 0);
            return copyOfItems;
        }
    }
}