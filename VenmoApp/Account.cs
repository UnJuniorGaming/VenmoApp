using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenmoApp
{
    abstract class Account
    {
        public int AccountNumber {get;  private set;}
        public decimal Balance { get; protected set; }

        public Account()
        {
            Random random = new Random();
            Balance = 100m;
            AccountNumber = random.Next(1001, 5999);
        }
        public bool deposit(decimal amount)
        {
            Balance += amount;
            return true;
        }
        public abstract bool withdrawal(decimal amount);



        
    }
}
