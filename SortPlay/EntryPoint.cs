namespace SortPlay
{
    using System;
    using System.Diagnostics;
    using SortArray;

    public static class EntryPoint
    {
        public static void Main()
        {
            var sw = new Stopwatch();
            #region Unsorted sequence
            int[] nums = { 4, 6, 2 - 1, 67, 33, 992, -423 };            
            Console.WriteLine($"Unsorted numbers:{Environment.NewLine}{string.Join(", ", nums)}");
            #endregion
            #region Bubble Sort
            sw.Start();
            Console.WriteLine(
                $"Bubble Sort: {nums.GetResultFromSortArray(new BubbleSort())}");
            sw.Stop();
            Console.WriteLine($"Elapsed time: {sw.Elapsed}");
            #endregion
            sw.Restart();
            #region Selection Sort
            sw.Start();
            Console.WriteLine(
                $"Selection Sort: {nums.GetResultFromSortArray(new SelectionSort())}");
            sw.Stop();
            Console.WriteLine($"Elapsed time: {sw.Elapsed}");
            #endregion
            sw.Restart();
            #region Insertion Sort
            sw.Start();
            Console.WriteLine(
                $"Insertion Sort: {nums.GetResultFromSortArray(new InsertionSort())}");
            sw.Stop();
            Console.WriteLine($"Elapsed time: {sw.Elapsed}");
            #endregion
        }

        private static string GetResultFromSortArray(this int[] nums, ISortable sortableStrategy)
        {
            int[] copy = nums.CopyArray();
            sortableStrategy.Sort(copy);
            return $"{Environment.NewLine}{string.Join(", ", copy)}";
        }

        private static int[] CopyArray(this int[] nums)
        {
            int[] copyOfNums = new int[nums.Length];
            nums.CopyTo(copyOfNums, 0);
            return copyOfNums;
        }
    }
}