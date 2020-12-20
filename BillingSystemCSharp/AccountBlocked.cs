using System;

namespace State
{
    class AccountBlocked : IisBlocked
    {
        
        public string Pay()
        {
            return "Account blocked";
        }
    }
}