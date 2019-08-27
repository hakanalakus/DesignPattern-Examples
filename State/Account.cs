using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Account
    {
        private IAccountState _accountState;


        public Account()
        {
            _accountState = new NormalAccount();
        }

        
        public void GetMoney()
        {
            _accountState.GetMoney();
            
        }

        public void PayMoney()
        {
            _accountState.PayMoney();   
        }

        public void ChangeState(IAccountState state)
        {
            _accountState = state;
        }
    }
}
