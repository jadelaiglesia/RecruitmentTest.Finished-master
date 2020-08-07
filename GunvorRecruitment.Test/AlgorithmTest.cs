using NUnit.Framework;

namespace GunvorRecruitment.Test
{
    [TestFixture]
    public class AlgorithmTest
    {
        [Test]
        public void ShouldReverseEveryOtherWord()
        {
            const string InputString = "Every other word in this sentence should be reversed";
            const string ExpectedOutput = "Every rehto word ni this ecnetnes should eb reversed";

            var algorithm = new Algorithm();

            var result = algorithm.ReverseEveryOtherWord(InputString);

            Assert.AreEqual(ExpectedOutput, result);
        }
    }
}
