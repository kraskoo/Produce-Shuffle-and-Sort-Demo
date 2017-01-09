namespace CondtionsPlay
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using Conditions;
    using Conditions.Interfaces;

    public class EntryPoint
    {
        public static void Main()
        {
            IOddCheckable binaryOddChecker = new BinaryOddCheck();
            IOddCheckable normalOddChecker = new NormalOddCheck();
            var endValue = int.MaxValue / 10;
            Console.WriteLine(endValue);
            var stopwatch = new Stopwatch();
            var elementsToCheck = Enumerable.Range(1, endValue).ToArray();
            ExecuteBigOddCheck(elementsToCheck, stopwatch, binaryOddChecker);
            Console.WriteLine($"Binary elapsed time: {stopwatch.ElapsedTicks}"); // 4196403
            stopwatch.Restart();
            ExecuteBigOddCheck(elementsToCheck, stopwatch, normalOddChecker);
            Console.WriteLine($"Normal elapsed time: {stopwatch.ElapsedTicks}"); // 6801205
            stopwatch.Restart();
        }

        private static void ExecuteBigOddCheck(int[] array, Stopwatch stopwatch, IOddCheckable checkable)
        {
            stopwatch.Start();
            for (int i = 0; i < array.Length; i++)
            {
                checkable.IsOdd(array[i]);
            }

            stopwatch.Stop();
        }
    }
}