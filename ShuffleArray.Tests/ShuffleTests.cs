namespace ShuffleArray.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ShuffleIndices;

    [TestClass]
    public class ShuffleTests
    {
        private Shuffle shuffle;

        [TestInitialize]
        public void IntializeShuffleClass()
        {
            this.shuffle = new Shuffle();
        }

        [TestMethod]
        public void Test_NextIntInEnumerableRange_ShouldBeReturnsIndicesInArrayRange()
        {
            var indices = Enumerable.Range(0, 101).ToArray();
            for (int i = 0; i < indices.Length; i++)
            {
                int nextNumberInRange = this.shuffle.NextInt(i, indices.Length);
                Assert.IsTrue(nextNumberInRange >= i);
                Assert.IsTrue(nextNumberInRange < indices.Length);
            }
        }

        [TestMethod]
        public void Test_AfterShuffleElementsInArray_ShouldHaveExactLengthAsArrayBeforeShuffling()
        {
            var indices = Enumerable.Range(0, 5).ToArray();
            HashSet<int> nums = new HashSet<int>(indices);
            this.shuffle.ShuffleItems(indices);
            Assert.AreEqual(indices.Length, nums.Count);
            indices = Enumerable.Range(0, 50).ToArray();
            nums = new HashSet<int>(indices);
            this.shuffle.ShuffleItems(indices);
            indices = Enumerable.Range(0, 31).ToArray();
            nums = new HashSet<int>(indices);
            this.shuffle.ShuffleItems(indices);
            indices = Enumerable.Range(0, 47).ToArray();
            nums = new HashSet<int>(indices);
            this.shuffle.ShuffleItems(indices);
        }

        [TestMethod]
        public void Test_ExistenceOfFirst10ElementsInArrayAfterShuffling()
        {
            var indices = Enumerable.Range(0, 100).ToArray();
            HashSet<int> nums = new HashSet<int>(indices);
            this.shuffle.ShuffleItems(indices);
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(nums.Contains(indices[i]));
            }
        }

        [TestMethod]
        public void Test_ExistenceOfLast10ElementsInArrayAfterShuffling()
        {
            var indices = Enumerable.Range(0, 100).ToArray();
            HashSet<int> nums = new HashSet<int>(indices);
            this.shuffle.ShuffleItems(indices);
            for (int i = indices.Length - 10; i < indices.Length; i++)
            {
                Assert.IsTrue(nums.Contains(indices[i]));
            }
        }

        [TestMethod]
        public void Test_ExistenceOfMiddle10ElementsInArrayAfterShuffling()
        {
            var indices = Enumerable.Range(0, 100).ToArray();
            HashSet<int> nums = new HashSet<int>(indices);
            int midIndex = indices.Length / 2;
            this.shuffle.ShuffleItems(indices);
            for (int i = midIndex; i < midIndex + 10; i++)
            {
                Assert.IsTrue(nums.Contains(indices[i]));
            }
        }

        [TestMethod]
        public void Test_DifferenceBetweenFirst5ElementInArrayBeforeAndAfterShuffling()
        {
            var indices = Enumerable.Range(0, 15).ToArray();
            int[] nums = Enumerable.ToArray(indices);
            this.shuffle.ShuffleItems(indices);
            bool hasEqualsPosition = true;
            for (int i = 0; i < 5; i++)
            {
                if (indices[i] != nums[i])
                {
                    hasEqualsPosition = false;
                    break;
                }
            }

            Assert.IsFalse(hasEqualsPosition);
        }

        [TestMethod]
        public void Test_DifferenceBetweenLast5ElementInArrayBeforeAndAfterShuffling()
        {
            var indices = Enumerable.Range(0, 15).ToArray();
            int[] nums = Enumerable.ToArray(indices);
            this.shuffle.ShuffleItems(indices);
            bool hasEqualsPosition = true;
            for (int i = indices.Length - 1; i >= indices.Length - 6; i--)
            {
                if (indices[i] != nums[i])
                {
                    hasEqualsPosition = false;
                    break;
                }
            }

            Assert.IsFalse(hasEqualsPosition);
        }

        [TestMethod]
        public void Test_DifferenceBetweenMiddle5ElementInArrayBeforeAndAfterShuffling()
        {
            var indices = Enumerable.Range(0, 15).ToArray();
            int[] nums = Enumerable.ToArray(indices);
            int midIndex = indices.Length / 2;
            this.shuffle.ShuffleItems(indices);
            bool hasEqualsPosition = true;
            for (int i = midIndex; i < midIndex + 5; i++)
            {
                if (indices[i] != nums[i])
                {
                    hasEqualsPosition = false;
                    break;
                }
            }

            Assert.IsFalse(hasEqualsPosition);
        }
    }
}