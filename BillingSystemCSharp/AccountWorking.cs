using System;

namespace State
{
    class AccountWorking : IisBlocked
    {
        public string Pay()
        {
            return "Account working";
        }
    }
}