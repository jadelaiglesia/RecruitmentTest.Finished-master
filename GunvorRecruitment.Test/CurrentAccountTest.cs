using NUnit.Framework;
using System;

namespace GunvorRecruitment.Test
{
    [TestFixture]
    public class CurrentAccountTest
    {
        private CurrentAccount _subject;

        [Test]
        public void ShouldDepositAmount()
        {
            _subject.Deposit(10);
            Assert.AreEqual(10, _subject.Balance);
        }

        [Test]
        public void ShouldWithdrawAmount()
        {
            _subject.Withdraw(20);
            Assert.AreEqual(-20, _subject.Balance);
        }

        [Test]
        public void WithdrawlBiggerThanOverDraft_ShouldThrowException()
        {
            Assert.Throws<AccountOverDrawnException>(() => _subject.Withdraw(-2000));
        }
        
        [SetUp]
        public void SetUp()
        {
            _subject = new CurrentAccount { OverDraft = 1000, PersonName = "Test Person" };
        }
    }
}
