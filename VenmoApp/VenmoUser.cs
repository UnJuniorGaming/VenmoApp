using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenmoApp
{
    class VenmoUser
    {
      public string FirstName {get; set;}
      public string LastName { get; set; }
      public string Email { get; set; }


      private SavingsAccount savings;

      private CheckingAccount checking;
        
      public VenmoUser(string firstName, string lastName, string email)
      {
          FirstName = firstName;
          LastName = lastName;
          Email = email;
      }

      public bool AddPaymentMethod(Account account)
      {
         if (account is SavingsAccount)
         {
             savings = (SavingsAccount) account;
         }
         if (account is CheckingAccount)
         {
            checking = (CheckingAccount)account;
         }
         else
         {
            return false;
         }
          return true;
      }

      public bool acceptPayment(VenmoUser payee,decimal amount, Object account)
      {
         
         if (account is "Checking Account")
         {
            payee.checking.deposit(amount);
         }
         if (account is "Savings Account")
         {
            payee.savings.deposit(amount);
         }
         else
         {
            return false;
         }
         return true;
      }

      public bool payWithSavings(VenmoUser payer,VenmoUser payee, decimal amount)
      {
         //bool success = false;
         if (payer.savings.withdrawal(amount))
         {
             return true;
         }
         else
         {
            return false;
         }
      }

      public bool payWithChecking(VenmoUser payer,VenmoUser payee, decimal amount)
      {
         //bool success = false;
         
         if (payer.checking.withdrawal(amount))
         {
            return true;
         }
         else
         {
            return false;
         }
      }

      public decimal getSavBalance()
      {
          return savings.Balance;
      }

      public decimal getCheckBalance()
      {
         return checking.Balance;
      }

      public override string ToString()
      {
         String s = "\n" + FirstName + " " + LastName + "\n";
         if (savings != null)
         {
            s += "\t savings:" + getSavBalance().ToString("C") + " ";
         }
         if (checking != null)
         {
            s += "\t checking:" + getCheckBalance().ToString("C") + "\n";
         }
         return s;
      }
    }
}
