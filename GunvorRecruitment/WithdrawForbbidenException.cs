using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunvorRecruitment
{
    public class WithdrawForbbidenException : Exception
    {
        public string InvalidWithDrawException()
        {
            return "Invalid Withdraw not time to get out amount";
        }

    }
}

