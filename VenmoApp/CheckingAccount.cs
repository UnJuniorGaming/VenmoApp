using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenmoApp
{
	class CheckingAccount : Account
	{
		private decimal checkFee = 1.25m;

		public override bool withdrawal(decimal amount)
		{
			if (amount > Balance)
			{
				return false;
			}
			else
			{
				Balance -= amount;
				Balance -= checkFee;
				if (Balance < 0)
				{
					Balance += amount;
					Balance += checkFee;
					return false;
				}
				return true;
			}
		}
	}
}
