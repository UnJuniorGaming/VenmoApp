using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenmoApp
{
    class SavingsAccount: Account 
    {
      decimal minimumBalance = 25;
      decimal lowBalanceFee = 5;
      public override bool withdrawal(decimal amount)
      {
         bool success = false;

         if (Balance > amount)
         {
            success = true;
            if (success && (Balance - amount) > minimumBalance)
            {
               Balance -= amount;
            }
            if (success && (Balance - amount) < minimumBalance)
            {
               if ((Balance - amount - lowBalanceFee) > 0)
               {
                  Balance -= (amount + lowBalanceFee);
               }
               else
               {
                  success = false;
               }
            }
         }

         return success;
      }
        
    }
}
