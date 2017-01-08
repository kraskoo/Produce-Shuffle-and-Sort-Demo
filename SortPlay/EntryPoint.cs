namespace SortPlay
{
    using ShuffleIndices;
    using System;
    using System.Linq;

    public static class EntryPoint
    {
        private static readonly Shuffle Shuffle = new Shuffle();

        public static void Main()
        {
            DefaultResults();
            Console.WriteLine("50 Items");
            Console.WriteLine("----------------");
            ResultWithArrayOf50Items();
            Console.WriteLine($"{Environment.NewLine}100 Items");
            Console.WriteLine("----------------");
            ResultWithArrayOf100Items();
            Console.WriteLine($"{Environment.NewLine}150 Items");
            Console.WriteLine("----------------");
            ResultWithArrayOf150Items();
            Console.WriteLine($"{Environment.NewLine}200 Items");
            Console.WriteLine("----------------");
            ResultWithArrayOf200Items();
        }

        private static void ResultWithArrayOf200Items(bool toShowItems = false)
        {
            var items = Enumerable.Range(1, 200).ToArray();
            Shuffle.ShuffleItems(items);
            items.Print(toShowItems);
        }

        private static void ResultWithArrayOf150Items(bool toShowItems = false)
        {
            var items = Enumerable.Range(1, 150).ToArray();
            Shuffle.ShuffleItems(items);
            items.Print(toShowItems);
        }

        private static void ResultWithArrayOf100Items(bool toShowItems = false)
        {
            var items = Enumerable.Range(1, 100).ToArray();
            Shuffle.ShuffleItems(items);
            items.Print(toShowItems);
        }

        private static void ResultWithArrayOf50Items(bool toShowItems = false)
        {
            var items = Enumerable.Range(1, 50).ToArray();
            Shuffle.ShuffleItems(items);
            items.Print(toShowItems);
        }

        private static void DefaultResults(bool toShowItems = false)
        {
            int[] nums = { 4, 6, 2 - 1, 67, 33, 992, -423 };
            if (toShowItems)
            {
                nums.Print(toShowItems);
            }
            else
            {
                nums.GetResults(toShowItems);
            }
        }

        private static void Print<T>(this T[] items, bool toShowItems = false)
            where T : IComparable<T>
        {
            Console.WriteLine(items.GetResults(toShowItems));
        }
    }
}