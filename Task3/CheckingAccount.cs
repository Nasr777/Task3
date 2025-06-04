using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0) : base(name, balance)
        {

        }
        public override bool Withdraw(double amount)
        {
            if (Balance - amount - 1.5 >= 0)
            {
                Balance -= amount;
                Balance -= 1.5;
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
