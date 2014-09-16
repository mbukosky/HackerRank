using HackerRank;
using HackerRank.Sorting;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class SortingSolutionsShould
    {

        [Test]
        [Ignore]
        [TestCase("1 1", new string[] { "2" })]
        public void InsertionSortCases(string input, string[] output)
        {
            // Arrange

            // Act
            var sut = new InsertionSortSolution(input);

            Assert.Fail();
            //Assert            
            //CollectionAssert.AreEqual(sut.Output, output);
        }

        [Test]
        [Ignore]
        [TestCase(new int[] { 5, 8, 1, 3, 7, 9, 2 }, new string[] { "2 3", "1 2 3", "7 8 9", "1 2 3 5 7 8 9" })]
        public void QuickSortCases(int[] input, string[] output)
        {
            // Arrange

            // Act
            var sut = new QuickSortSolution(input);

            //Assert            
            CollectionAssert.AreEqual(sut.Output, output);
        }
    }
}
