using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Task3
{
    public class  TrustAccount : SavingsAccount
    {
        int counttra;
        //DateTime date;
        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double intRate = 0.0, int counttra = 0 ) : base(name, balance,intRate)
        {
           this.counttra = counttra;
           //this.date = date;
        }
        public override bool Deposit(double amount)
        {

            if (amount < 0 )
                return false;
            else  
            {
                                            
                if (amount >= 5000)
            {
                Balance = amount + 50 ;
                return true;
            }
                Balance += amount;
               return true;
           }
        }
        public override bool Withdraw(double amount)
        {
            if (amount <=(Balance * 0.2))
            {
                if (counttra <=3 && counttra>= 0)
                {
                    Balance -= amount;
                    counttra++;
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

    }
}
