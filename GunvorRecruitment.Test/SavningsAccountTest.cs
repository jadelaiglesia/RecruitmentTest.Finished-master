using NUnit.Framework;
using System;

namespace GunvorRecruitment.Test
{
    [TestFixture]
    public class  SavningsAccountTest
    {
        private SavingsAccount _subject;

        [Test]
        public void ShouldWithdrawOnePerMonth_OK_AND_KO()
        {
            _subject.InAmount(35.00);
            var res = _subject.OneWithdrawPerMonth(35);
            Assert.AreEqual(100, res);
            Assert.Throws<WithdrawForbbidenException>(() => _subject.OneWithdrawPerMonth(45));
        }

        [Test]
        public void ShouldBalanceWithnteresInOneYear()
        {

            Assert.AreEqual(102, _subject.GetBalanceWithInterestOfXYears_OneYearByDefault());
        }

        [Test]
        public void ShouldBalanceWithnteresInTenYears()
        {

            Assert.AreEqual(121.90, _subject.GetBalanceWithInterestOfXYears_OneYearByDefault(10));
        }


        [SetUp]
        public void SetUp()
        {
            _subject = new SavingsAccount("Test Person" );
            _subject.InAmount(100.00);
        }

    }
}

