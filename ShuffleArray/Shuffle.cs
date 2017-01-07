namespace ShuffleIndices
{
    using System;

    public class Shuffle
    {
        private static readonly Random Random = new Random();

        public void ShuffleItems<T>(T[] array)
        {
            for (int index = array.Length - 1; index >= 0; index--)
            {
                var nextIndex = this.NextInt(0, index);
                var temporary = array[index];
                array[index] = array[nextIndex];
                array[nextIndex] = temporary;
            }
        }

        public int NextInt(int min, int max)
        {
            return Random.Next(min, max);
        }
    }
}