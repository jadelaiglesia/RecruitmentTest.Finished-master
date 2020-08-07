using System;

namespace GunvorRecruitment
{
    public class AccountOverDrawnException : Exception
    {      
        public string InvalidAmountException()
        {  
            return "Invalid Amount"; 
        }

    }
}