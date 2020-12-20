using System;
using System.Collections.Generic;

namespace State
{
    class AccountBoxWithState
    {
        private Dictionary<string, IisBlocked> payments= new Dictionary<string, IisBlocked>();
        private string state;
       
        public AccountBoxWithState()
        {
            payments.Add("BLOCKED", new AccountBlocked());
            payments.Add("WORKING", new AccountWorking());
            
        }

        public List<string> States
        {
            get
            {
                List<string> result = new List<string>();
                foreach (string state in payments.Keys)
                {
                    result.Add(state);
                }
                return result;
            }
        }    
        public string State {
            set{
                if (States.Contains(value))
                    state = value;
                else
                    throw new Exception("Unknown state");
            }
        }
        public string CheckAccountBlocking( )
        {
            if (payments.TryGetValue(state, out var isBlocked))
            {
                return isBlocked.Pay();
            }

            return "None";
        }
    }
}