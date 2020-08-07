using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GunvorRecruitment
{
     public class InOutAmountsOnCount
     {
        public double amount { get; set; }
         public string IsInOrOut { get; set; }     
         public DateTime time { get; set; }
     }

     public class SavingsAccount
     {
        private readonly object AccountLock = new object();
        private CurrentAccount _account = new CurrentAccount() { OverDraft = 0};
        private List<InOutAmountsOnCount> _listoperations = new List<InOutAmountsOnCount>();
      
        public SavingsAccount(string personname)
        {
          _account.PersonName = personname;
        }


        public double InAmount(double amount)
        {
            lock (AccountLock)
            {
                var AbsAmount = Math.Abs(amount);
                _account.Deposit(AbsAmount);
                _listoperations.Add(new InOutAmountsOnCount() { amount = amount, IsInOrOut = "in", time = DateTime.Now});
            }
            return _account.Balance;
        }
            
        public double OneWithdrawPerMonth(double amount)
        {
            var beforeBalance = _account.Balance;
            var AbsAmount = Math.Abs(amount);
            var lastWithdraw = _listoperations
                                .Where(a => a.IsInOrOut == "out" && a.time > DateTime.Now.AddMonths(-1))
                                .Count();
                                
            
            lock (AccountLock)
            {

                    if (lastWithdraw == 0)
                    {
                        _account.Withdraw(AbsAmount);
                        _listoperations.Add(new InOutAmountsOnCount() { amount = AbsAmount, IsInOrOut = "out", time = DateTime.Now });
                        return _account.Balance;
                    }
                    else
                    {
                        throw new WithdrawForbbidenException();
                    }
       
            }
        }

        public double GetBalanceWithInterestOfXYears_OneYearByDefault(int numofyears=1)
        {
            var TotalAmountInYears = _account.Balance;

            for (int i=1; i<=numofyears; i++) 
            {
                TotalAmountInYears += ((double)TotalAmountInYears * 2) / 100 ; 
            }
            
            return Math.Round(TotalAmountInYears, 2);
        }


    }
}
