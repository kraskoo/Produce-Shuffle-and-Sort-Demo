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
            Console.WriteLine("500 Items");
            Console.WriteLine("----------------");
            ResultWithArrayOf500Items();
            Console.WriteLine($"{Environment.NewLine}1000 Items");
            Console.WriteLine("----------------");
            ResultWithArrayOf1000Items();
            Console.WriteLine($"{Environment.NewLine}1500 Items");
            Console.WriteLine("----------------");
            ResultWithArrayOf1500Items();
            Console.WriteLine($"{Environment.NewLine}2000 Items");
            Console.WriteLine("----------------");
            ResultWithArrayOf2000Items();
        }

        private static void ResultWithArrayOf2000Items(bool toShowItems = false)
        {
            var items = Enumerable.Range(1, 2000).ToArray();
            Shuffle.ShuffleItems(items);
            items.Print(toShowItems);
        }

        private static void ResultWithArrayOf1500Items(bool toShowItems = false)
        {
            var items = Enumerable.Range(1, 1500).ToArray();
            Shuffle.ShuffleItems(items);
            items.Print(toShowItems);
        }

        private static void ResultWithArrayOf1000Items(bool toShowItems = false)
        {
            var items = Enumerable.Range(1, 1000).ToArray();
            Shuffle.ShuffleItems(items);
            items.Print(toShowItems);
        }

        private static void ResultWithArrayOf500Items(bool toShowItems = false)
        {
            var items = Enumerable.Range(1, 500).ToArray();
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