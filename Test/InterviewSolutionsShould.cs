using HackerRank;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    public class InterviewSolutionsShould
    {
        [Test]
        [TestCase("wow", true)]
        [TestCase("aabb", false)]
        [TestCase("", true)]
        [TestCase("x", true)]
        [TestCase((string)null, false)]
        public void IsPalindrome(string word, bool answer)
        {
            // Arrange

            // Act
            var actual = Palindrome.IsPalindrome(word);

            //Assert
            Assert.That(answer, Is.EqualTo(actual));
        }

        [Test]
        [Ignore]
        [TestCase("a", new string[] { "a" })]
        [TestCase("aba", new string[] { "aba" })]
        [TestCase("aabba", new string[] { "a", "abba" })]
        [TestCase("ababbbabbababa", new string[] { "a", "babbbab", "b", "ababa" })]
        public void IsMinPartitions(string word, string[] answer)
        {
            // Arrange

            // Act
            var actual = Palindrome.MinPalindromePartitions(word);

            //Assert
            //CollectionAssert.AreEquivalent(answer, actual);\

            Assert.That(answer.Length -1, Is.EqualTo(actual));
        }
    }
}
