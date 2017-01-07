namespace ShufflePlay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ShuffleIndices;

    public static class EntryPoint
    {
        private static readonly Shuffle Shuffle = new Shuffle();

        public static void Main()
        {
            StringBuilder builderToAppend = new StringBuilder();
            builderToAppend.TestShuffleWithNumbers();
            builderToAppend.TestShuffleWithString();
            Console.WriteLine(builderToAppend.ToString());
        }

        public static void TestShuffleWithNumbers(this StringBuilder builderToAppend)
        {
            var fiftyNumbers = Enumerable.Range(0, 50).ToArray();
            var inSet = new HashSet<int>(fiftyNumbers);

            Shuffle.ShuffleItems(fiftyNumbers);

            builderToAppend.AppendLine("TestShuffleWithNumbers");
            builderToAppend.AppendLine("======================");
            builderToAppend.AppendLine("Before shuffling");
            builderToAppend.AppendLine(string.Join(", ", inSet));
            builderToAppend.AppendLine("After shuffling");
            builderToAppend.AppendLine(string.Join(", ", fiftyNumbers));
            builderToAppend.AppendLine("======================");
        }

        public static void TestShuffleWithString(this StringBuilder builderToAppend)
        {
            builderToAppend.Append("The information about these names was courtesy of")
                .Append(" this link: ")
                .AppendLine(" \"https://en.wikipedia.org/wiki/List_of_most_popular_given_names\"");
            var names = new[]
            {
                "Santiago",
                "Daniel",
                "Miguel",
                "Liam",
                "Thomas",
                "Agustín",
                "Stevenson",
                "Jayden"
            };

            var inSet = new HashSet<string>(names);

            Shuffle.ShuffleItems(names);

            builderToAppend.AppendLine("TestShuffleWithString");
            builderToAppend.AppendLine("======================");
            builderToAppend.AppendLine("Before shuffling");
            builderToAppend.AppendLine(string.Join(", ", inSet));
            builderToAppend.AppendLine("After shuffling");
            builderToAppend.AppendLine(string.Join(", ", names));
            builderToAppend.Append("======================");
        }
    }
}