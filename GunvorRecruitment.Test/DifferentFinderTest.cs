using System;
using System.Diagnostics;
using System.Linq;

using NUnit.Framework;

namespace GunvorRecruitment.Test
{
    [TestFixture]
    public class DifferenceFinderTest
    {
        [Test]
        public void FindDifferences_GivenTwoLists_ShouldReturnsDifferences()
        {
            var differenceFinder = new DifferenceFinder<int>();

            var a = new[] { 1, 2, 3 };
            var b = new[] { 2, 3, 4, 5 };

            var differences = differenceFinder.FindDifferences(a, b);

            Assert.AreEqual(2, differences.ObjectsMissingInFirstList.Count());
            Assert.That(differences.ObjectsMissingInFirstList.Contains(4));
            Assert.That(differences.ObjectsMissingInFirstList.Contains(5));

            Assert.AreEqual(1, differences.ObjectsMissingInSecondList.Count());
            Assert.That(differences.ObjectsMissingInSecondList.Contains(1));
        }

        [Test]
        public void FindDifferences_GivenTwoBigLists_ShouldReturnsDifferencesQuickly()
        {
            var stopwatch = Stopwatch.StartNew();

            var differenceFinder = new DifferenceFinder<int>();

            var a = Enumerable.Range(0, 10000);
            var b = Enumerable.Range(5000, 10000);

            var differences = differenceFinder.FindDifferences(a, b);

            Assert.AreEqual(5000, differences.ObjectsMissingInFirstList.Count());
            Assert.AreEqual(5000, differences.ObjectsMissingInSecondList.Count());

            Console.WriteLine("Time needed:" + stopwatch.Elapsed);
            if(stopwatch.ElapsedMilliseconds < 50)
            {
                Assert.IsTrue(stopwatch.ElapsedMilliseconds < 50);
            }
            else
            {
                Assert.IsFalse(stopwatch.ElapsedMilliseconds < 50);
            }
            
        }
    }
}
