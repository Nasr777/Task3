using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double intRate = 0.0) : base(name, balance)
        {
            IntRate = intRate;
        }

        public double IntRate { get; set; }
    }
}
