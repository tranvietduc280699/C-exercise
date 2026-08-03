using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lesson4.Model
{
    internal class SavingAccount: Account
    {
        private decimal Rate {  get; set; }

        // constructor
        public SavingAccount() { }

        public SavingAccount(decimal initialize, decimal Rate): base(initialize)
        {
            if(Rate > 0)
            {
                this.Rate = Rate;
            }

        }
        //
        public decimal GetInterest()
        {
            return Balance * Rate;
        }
    }
}
