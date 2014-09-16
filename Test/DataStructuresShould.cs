using HackerRank.DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture, Category("DataStructures")]
    public class DataStructuresShould
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 10, 20, 30, 40 }, 100)]
        public void SubWeightingCases(int[] a, int[] w, int output)
        {
            // Arrange

            // Act
            var sut = new SubWeightingSolution(a, w);

            //Assert            
            Assert.That(sut.Output, Is.EqualTo(output));
        }
    }
}
