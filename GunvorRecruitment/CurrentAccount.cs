using System;

namespace GunvorRecruitment
{
    public class CurrentAccount
    {
        public double Balance { get; private set; }

        public int OverDraft { get; set; }

        public string PersonName { get; set; }

        public void Deposit(double amount)
        {
            var tempValue = Balance;
            var newValue = tempValue + amount;
            Balance = newValue;
        }

        public void Withdraw(double amount)
        {       
           var newValue = Balance - Math.Abs(amount);
           if (Math.Abs(amount) > (OverDraft + Balance))
                throw new AccountOverDrawnException();
            Balance = newValue;
        }
    }
}
